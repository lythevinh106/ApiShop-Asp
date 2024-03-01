using AutoMapper;
using DataAccess.Infrastructure;
using DtoShared.ModulesDto;
using MediatR;

namespace Service.Application.Order.Queries
{
    public class AnalysisDataQuery : IRequest<List<AnalysisDataInfo>>
    {


        private readonly int _dayNumber;
        public AnalysisDataQuery(int dayNumber)
        {
            _dayNumber = dayNumber;
        }

        public class Handler : BaseHandler, IRequestHandler<AnalysisDataQuery, List<AnalysisDataInfo>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<AnalysisDataInfo>> Handle(AnalysisDataQuery request, CancellationToken cancellationToken)
            {
                //var orderRepo = _unitOfWork.OrderRepository;
                var categoryRepo = _unitOfWork.CategoryRepository;
                var productRepo = _unitOfWork.ProductReponsitory;
                var productOrderRepo = _unitOfWork.ProductOrderRepository;

                IQueryable<Model.Modules.CategoryModel.Category> quertListCategory = categoryRepo.All();
                IQueryable<Model.Modules.ProductModel.Product> quertListProduct = productRepo.All();
                IQueryable<Model.Modules.ProductOrderModel.ProductOrder> quertListProductOrder = productOrderRepo.All();

                var result = (from c in quertListCategory
                              join p in quertListProduct on c.Id equals p.CategoryId
                              join po in quertListProductOrder on p.Id equals po.ProductId
                              where po.Time.Date >= DateTime.Now.Date.AddDays(-request._dayNumber)
                              group new { c, p, po } by new { c.Id, c.Name } into grouped
                              select new AnalysisDataInfo
                              {

                                  nameCategory = grouped.Key.Name,
                                  profit = grouped.Sum(x => x.po.Quantity * x.p.Price),
                                  soldNumber = grouped.Sum(x => x.po.Quantity)

                              }).ToList();

                return result;


            }
        }
    }
}

//AnalysisDataInfo