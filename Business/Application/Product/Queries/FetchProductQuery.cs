using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.Product.Queries
{
    public class FetchProductQuery : IRequest<PaggingResponse<ProductResponse>>
    {

        private readonly FetchDataProductRequest _fetchDataProductRequest;

        public FetchProductQuery(FetchDataProductRequest fetchDataProductRequest)
        {
            _fetchDataProductRequest = fetchDataProductRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchProductQuery, PaggingResponse<ProductResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<ProductResponse>> Handle(FetchProductQuery request, CancellationToken cancellationToken)
            {
                var productRepo = _unitOfWork.ProductReponsitory;

                IQueryable<Model.Modules.ProductModel.Product> quertListProduct = productRepo.All();

                if (!request._fetchDataProductRequest.CategoryId.IsNullOrEmpty())
                {
                    quertListProduct = quertListProduct.Where(p => p.CategoryId == request._fetchDataProductRequest.CategoryId);


                }
                if (!request._fetchDataProductRequest.Search.IsNullOrEmpty())
                {
                    quertListProduct = quertListProduct
                    .Where(p => p.Name.Contains(request._fetchDataProductRequest.Search));
                }





                if (request._fetchDataProductRequest.SortTime.HasValue

                  )
                {
                    IOrderedQueryable<Model.Modules.ProductModel.Product> OrderQuerytListProduct = null;


                    if (request._fetchDataProductRequest.SortTime.Value.ToString() == SortProductOption.Ascending.ToString())
                    {
                        OrderQuerytListProduct = productRepo.Sort(p => (p.Time), quertListProduct, false);
                    }
                    if (request._fetchDataProductRequest.SortTime.Value.ToString() == SortProductOption.Descending.ToString())
                    {
                        OrderQuerytListProduct = productRepo.Sort(p => (p.Time), quertListProduct, true);
                    }

                    //if (OrderQuerytListProduct != null)
                    //{

                    //    if (request._fetchDataProductRequest.Sort.HasValue

                    //     )
                    //    {
                    //        if (request._fetchDataProductRequest.Sort.Value.ToString() == SortProductOption.Ascending.ToString())
                    //        {
                    //            OrderQuerytListProduct = productRepo.SortThenBy(p => (p.Price), OrderQuerytListProduct, false);
                    //        }
                    //        if (request._fetchDataProductRequest.Sort.Value.ToString() == SortProductOption.Descending.ToString())
                    //        {
                    //            OrderQuerytListProduct = productRepo.SortThenBy(p => (p.Price), OrderQuerytListProduct, true);
                    //        }
                    //    }
                    //}


                    quertListProduct = OrderQuerytListProduct;


                }


                if (request._fetchDataProductRequest.Sort.HasValue

                 )
                {

                    if (request._fetchDataProductRequest.Sort.Value.ToString() == SortProductOption.Ascending.ToString())
                    {
                        quertListProduct = productRepo.Sort(p => (p.Price), quertListProduct, false);
                    }
                    if (request._fetchDataProductRequest.Sort.Value.ToString() == SortProductOption.Descending.ToString())
                    {
                        quertListProduct = productRepo.Sort(p => (p.Price), quertListProduct, true);
                    }

                }








                FetchDataRequest fetchDataRequest = _mapper.Map<FetchDataRequest>(request._fetchDataProductRequest);

                PagedList<Model.Modules.ProductModel.Product> dataResponse = productRepo.FectchData(fetchDataRequest, quertListProduct);



                PaggingResponse<ProductResponse> results = new PaggingResponse<ProductResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => _mapper.Map<ProductResponse>(p)).ToList()
                };


                return results;
            }




        }
    }
}
