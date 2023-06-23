using HTTTest.Web.Interfaces;
using HTTTest.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTTTest.Web.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ILogger<IndexModel> _logger;

        public ProductIndexViewModel ProductModel { get; set; } = new ProductIndexViewModel();

        public IndexModel(IProductService productService,
                          ILogger<IndexModel> logger)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task OnGet(Guid? categoryId = null)
        {
            _logger.LogInformation($"Get products with CategoryId {categoryId} visit product type page");
            ProductModel = await _productService.GetProductsAsync(categoryId);
        }
    }
}
