using AutoMapper;
using HTTTest.ApplicationCore.Entities;
using HTTTest.Web.ViewModels;

namespace HTTTest.Web.MappingProfile
{
    public class CategoryProfiles: Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
