using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model.Modules.ProductOrderModel;

namespace Service.Application.Order.Queries
{
    public class CountInfoQuery : IRequest<CountOrderInfo>
    {
        public CountInfoQuery()
        {
        }

        public class Handler : BaseHandler, IRequestHandler<CountInfoQuery, CountOrderInfo>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<CountOrderInfo> Handle(CountInfoQuery request, CancellationToken cancellationToken)
            {
                //var orderRepo = _unitOfWork.OrderRepository;
                var productOrderRepo = _unitOfWork.ProductOrderRepository;

                IQueryable<ProductOrder> quertListProductOrder = productOrderRepo.All();

                IQueryable<CountOrderInfo> rawSqlDay = quertListProductOrder.Include(p => p.Product)
                .Where(po => po.Time.Date == DateTime.Now.Date)

                     .Select(po =>
                       new CountOrderInfo()
                       {
                           dailyProfit = po.Quantity * po.Product.Price,
                           dailySoldNumber = po.Quantity,
                       }

                     );

                IQueryable<CountOrderInfo> rawSqlMonth = quertListProductOrder.Include(p => p.Product)
                 .Where((po => po.Time.Date >= DateTime.Now.Date.AddDays(-30)))

                    .Select(po =>
                      new CountOrderInfo()
                      {
                          monthlyProfit = po.Quantity * po.Product.Price,
                          monthlySoldNumber = po.Quantity,
                      }

                    );

                return new CountOrderInfo()
                {
                    dailyProfit = rawSqlDay.Sum(newValue => newValue.dailyProfit),
                    dailySoldNumber = rawSqlDay.Sum(newValue => newValue.dailySoldNumber),
                    monthlyProfit = rawSqlMonth.Sum(newValue => newValue.monthlyProfit),
                    monthlySoldNumber = rawSqlMonth.Sum(newValue => newValue.monthlySoldNumber)
                };
            }
        }
    }
}