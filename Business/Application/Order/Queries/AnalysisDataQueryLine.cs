using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;

namespace Service.Application.Order.Queries
{
    public class AnalysisDataQueryLine : IRequest<GroupAnalysisDataLineInfo>
    {
        private readonly int _dayNumber;

        public AnalysisDataQueryLine(int dayNumber)
        {
            _dayNumber = dayNumber;
        }

        public class Handler : BaseHandler, IRequestHandler<AnalysisDataQueryLine, GroupAnalysisDataLineInfo>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<GroupAnalysisDataLineInfo> Handle(AnalysisDataQueryLine request, CancellationToken cancellationToken)
            {
                var daysToInclude = new List<DateTime>();

                for (int i = 0; i < request._dayNumber; i++)

                {
                    daysToInclude.Add(DateTime.Now.Date.AddDays(-i));
                }

                //var orderRepo = _unitOfWork.OrderRepository;
                var orderRepo = _unitOfWork.OrderRepository;
                var productRepo = _unitOfWork.ProductReponsitory;
                var productOrderRepo = _unitOfWork.ProductOrderRepository;

                IQueryable<Model.Modules.OrderModel.Order> quertListOrder = orderRepo.All();
                IQueryable<Model.Modules.ProductModel.Product> quertListProduct = productRepo.All();
                IQueryable<Model.Modules.ProductOrderModel.ProductOrder> quertListProductOrder = productOrderRepo.All();

                var orderNumbers =

                (
                 from po in quertListProductOrder
                 join p in quertListProduct on po.ProductId equals p.Id
                 join o in quertListOrder on po.OrderId equals o.Id
                 where po.Time.Date >= DateTime.Now.Date.AddDays(-request._dayNumber)
                 && o.Status == DtoShared.Enums.StatusOrder.Success

                 group new { p, po } by new { po.Time.Date } into grouped
                 select new AnalysisDataLineInfo
                 {
                     time = grouped.Key.Date,
                     orderNumber = grouped.Sum(x => x.po.Quantity)
                 });

                var orderCancle =

              (
               from po in quertListProductOrder
               join p in quertListProduct on po.ProductId equals p.Id
               join o in quertListOrder on po.OrderId equals o.Id
               where po.Time.Date >= DateTime.Now.Date.AddDays(-request._dayNumber)
               && o.Status == DtoShared.Enums.StatusOrder.Cancle

               group new { p, po } by new { po.Time.Date } into grouped
               select new AnalysisDataLineInfo
               {
                   time = grouped.Key.Date,
                   orderNumber = grouped.Sum(x => x.po.Quantity)
               });


                var orderNumbersResult = (
                    from date in daysToInclude
                    join qr1 in orderNumbers on date equals qr1.time.Value.Date
                    into joined
                    from qr1 in joined.DefaultIfEmpty()

                    orderby date
                    select new AnalysisDataLineInfo
                    {
                        time = date,
                        orderNumber = qr1?.orderNumber ?? 0
                    }
                    );

                var orderCancleResult = (
                 from date in daysToInclude
                 join qr1 in orderCancle on date equals qr1.time.Value.Date
                 into joined
                 from qr1 in joined.DefaultIfEmpty()

                 orderby date
                 select new AnalysisDataLineInfo
                 {
                     time = date,
                     orderNumber = qr1?.orderNumber ?? 0
                 }
                 );

                return new GroupAnalysisDataLineInfo
                {
                    Data = new Dictionary<string, List<AnalysisDataLineInfo>>
                     {
                         { "cancle", orderCancleResult.ToList() },
                         { "success", orderNumbersResult.ToList() }
                     }
                };
            }
        }
    }
}