using AutoMapper;
using HTTTest.ApplicationCore.Entities;
using HTTTest.ApplicationCore.Interfaces;
using HTTTest.Web.Interfaces;
using HTTTest.Web.ViewModels;

namespace HTTTest.Web.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoryService> _logger;
        public CategoryService(IRepository<Category> repository,
            IMapper mapper,
            ILogger<CategoryService> logger) 
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async  Task<IList<CategoryViewModel>> GetCategoriesAsync()
        {
            _logger.LogInformation($"Сategories list has been received");
            var categories = await _repository.GetListAsync();
            var mapCategories = _mapper.Map<List<CategoryViewModel>>(categories);
            return mapCategories;
        }
    }
}
