using HTTTest.Web.ViewModels;

namespace HTTTest.Web.Interfaces
{
    public interface ICategoryService 
    {
        Task<IList<CategoryViewModel>> GetCategoriesAsync();
    }
}
