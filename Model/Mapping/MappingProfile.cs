using AutoMapper;

namespace Model.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //product module
            //CreateMap<ProductRequest, Product>().ReverseMap();
            //CreateMap<Product, ProductResponse>().ReverseMap();
            //CreateMap<ProductRequest, ProductResponse>().ReverseMap();
            //CreateMap<FetchDataRequest, FetchDataProductRequest>().ReverseMap();

            ////Categorymodule
            //CreateMap<CategoryRequest, Category>().ReverseMap();
            //CreateMap<Category, CategoryResponse>().ReverseMap();
            //CreateMap<FetchDataRequest, FetchDataCategoryRequest>().ReverseMap();

            ////User module

            //CreateMap<User, UserInfo>().ReverseMap();


            ////Room

            //CreateMap<Room, RoomRequest>().ReverseMap();
            //CreateMap<Room, RoomResponse>().ReverseMap();
            //CreateMap<RoomMember, RoomMemberRequest>().ReverseMap();

        }
    }
}
