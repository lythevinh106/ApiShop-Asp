﻿using AutoMapper;
using Castle.Core.Internal;
using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using MediatR;

namespace Service.Application.Product.Queries
{
    public class FetchProductClientQuery : IRequest<PaggingResponse<ProductClientResponse>>
    {

        private readonly FetchDataProductRequest _fetchDataProductRequest;

        public FetchProductClientQuery(FetchDataProductRequest fetchDataProductRequest)
        {
            _fetchDataProductRequest = fetchDataProductRequest;
        }


        public class Handler : BaseHandler, IRequestHandler<FetchProductClientQuery, PaggingResponse<ProductClientResponse>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PaggingResponse<ProductClientResponse>> Handle(FetchProductClientQuery request, CancellationToken cancellationToken)
            {
                var productRepo = _unitOfWork.ProductReponsitory;

                IQueryable<Model.Modules.ProductModel.Product> quertListProduct = productRepo.All();



                if (!request._fetchDataProductRequest.CategoryId.IsNullOrEmpty())
                {
                    quertListProduct = quertListProduct.Where(p => p.CategoryId == request._fetchDataProductRequest.CategoryId);


                }

                if (!request._fetchDataProductRequest.PromotionId.IsNullOrEmpty())
                {
                    quertListProduct = quertListProduct.Where(p => (p.PromotionId == request._fetchDataProductRequest.PromotionId));




                }
                if (!request._fetchDataProductRequest.Search.IsNullOrEmpty())
                {
                    quertListProduct = quertListProduct
                    .Where(p => p.Name.Contains(request._fetchDataProductRequest.Search));
                }


                if (request._fetchDataProductRequest.isPromotion.HasValue

                )
                {

                    if (request._fetchDataProductRequest.isPromotion.Value == true)
                    {

                        quertListProduct = quertListProduct
                        .Where(p => p.Promotion.Value != null && p.Promotion.TimeEnd >= DateTime.Now);


                    }


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



                PaggingResponse<ProductClientResponse> results = new PaggingResponse<ProductClientResponse>
                {
                    CurrentPage = dataResponse.CurrentPage,
                    TotalPage = dataResponse.TotalPages,
                    hasNext = dataResponse.HasNextPage,
                    hasPrv = dataResponse.HasPreviousPage,
                    Data = dataResponse.Select(p => new ProductClientResponse
                    {


                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Image = p.Image,
                        Description = p.Description,
                        Time = p.Time,
                        promotion = _mapper.Map<PromotionResponse>(p.Promotion),
                        category = _mapper.Map<CategoryResponse>(p.Category),

                    }).ToList()
                };


                return results;
            }




        }
    }
}
