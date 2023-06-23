using HTTTest.Web.ViewModels;

namespace HTTTest.Web.Interfaces
{
    public interface IProductService
    {
        Task<ProductIndexViewModel> GetProductsAsync(Guid? categoryId);
    }
}
