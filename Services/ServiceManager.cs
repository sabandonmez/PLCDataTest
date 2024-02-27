using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMobusOperationModelService _mobusOperationModelService;
        public ServiceManager(IProductService productService, ICategoryService categoryService, IMobusOperationModelService mobusOperationModelService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mobusOperationModelService = mobusOperationModelService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public IMobusOperationModelService MobusOperationModelService => _mobusOperationModelService;
    }
}