using AutoMapper;
using DtoShared.FetchData;
using DtoShared.ModulesDto;
using Model.Modules.CategoryModel;
using Model.Modules.OrderModel;
using Model.Modules.ProductModel;
using Model.Modules.PromotionModel;
using Model.Modules.UserModel;

namespace Model.Mapping
{
    public class MappingProfile : Profile
    {
        //https://viblo.asia/p/su-dung-automapper-de-anh-xa-mot-object-toi-mot-object-khac-trong-aspnet-core-ORNZqx2rK0n
        public MappingProfile()
        {
            //product module
            //      CreateMap<Product, ProductRequest>()
            //.ForMember(dest => dest.Image, opt => opt.MapFrom(pr => pr.Image));


            CreateMap<Product, ProductRequest>()
           .ForMember(dest => dest.Image, opt => opt.Ignore()).ReverseMap();

            CreateMap<Product, ProductUpdate>()
           .ForMember(dest => dest.Image, opt => opt.Ignore()).ReverseMap();


            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<ProductRequest, ProductResponse>().ReverseMap();
            CreateMap<FetchDataRequest, FetchDataProductRequest>().ReverseMap();

            ////Categorymodule
            ///

            CreateMap<CategoryRequest, Category>().ReverseMap();
            CreateMap<Category, CategoryResponse>().ReverseMap();
            CreateMap<FetchDataRequest, FetchDataCategoryRequest>().ReverseMap();

            ////User module

            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, UserRequest>().ReverseMap();



            //Order
            //CreateMap<Order, OrderResponse>().ReverseMap();
            // CreateMap<Order, OrderRequest>().ReverseMap();
            CreateMap<Order, OrderUpdate>().ReverseMap();
            CreateMap<Order, OrderDeleteResponse>().ReverseMap();

            ////User module

            CreateMap<Promotion, PromotionResponse>().ReverseMap();
            CreateMap<Promotion, PromotionRequest>().ReverseMap();




            ////Room

            //CreateMap<Room, RoomRequest>().ReverseMap();
            //CreateMap<Room, RoomResponse>().ReverseMap();
            //CreateMap<RoomMember, RoomMemberRequest>().ReverseMap();

        }
    }
}
