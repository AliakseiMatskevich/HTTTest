using AutoMapper;
using HTTTest.ApplicationCore.Entities;
using HTTTest.ApplicationCore.Interfaces;
using HTTTest.Web.Extentions;
using HTTTest.Web.Interfaces;
using HTTTest.Web.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HTTTest.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;
        private readonly ICategoryService _categoryService;

        public ProductService(IRepository<Product> repository,
            IMapper mapper,
            ILogger<ProductService> logger,
            ICategoryService categoryService)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
            _categoryService = categoryService;
        }
        public async Task<ProductIndexViewModel> GetProductsAsync(Guid? categoryId)
        {
            _logger.LogInformation($"Product list with category {categoryId} has been recieved");
            var categories = await _categoryService.GetCategoriesAsync();
            categoryId = categories.SetActiveItem(categoryId);

            var entities = await _repository.GetListAsync(
                predicate: x => x.CategoryId == categoryId,
                includes: x => x.Include(p => p.Category)!                                ,
                orderBy: x => x.OrderBy(p => p.Category!.Name).ThenBy(p => p.Name));

            var vm = new ProductIndexViewModel()
            {
                Products = _mapper.Map<List<ProductViewModel>>(entities).Chunk(size: 3)
            };
            return vm;
        }
    }
}
