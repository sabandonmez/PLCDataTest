using Entities.Models;
using Repositories.Contracts;
using Repositories.Models;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMobusOperationModelRepository _mobusOperationModelRepository;
        private readonly ISiemensOperationModelRepository _siemensOperationModelRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository, IMobusOperationModelRepository mobusOperationModelRepository, ISiemensOperationModelRepository siemensOperationModelRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mobusOperationModelRepository = mobusOperationModelRepository;
            _siemensOperationModelRepository = siemensOperationModelRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public IMobusOperationModelRepository MobusOperationModel => _mobusOperationModelRepository;

        public ISiemensOperationModelRepository SiemensOperationModel => _siemensOperationModelRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}