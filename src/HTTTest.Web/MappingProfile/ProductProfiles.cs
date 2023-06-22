using AutoMapper;
using HTTTest.ApplicationCore.Entities;
using HTTTest.Web.ViewModels;

namespace HTTTest.Web.MappingProfile
{
    public class ProductProfiles : Profile
    {
        public ProductProfiles()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(dto => dto.CategoryName, opt => opt.MapFrom(entity => entity.Category!.Name))
                .ForMember(dto => dto.Measure, opt => opt.MapFrom(entity => entity.Category!.Measure));
        }
    }
}
