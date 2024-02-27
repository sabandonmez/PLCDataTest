using Entities.Models;
using Repositories.Contracts;
using Repositories.Models;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IMobusOperationModelRepository _mobusOperationModelRepository;
        private readonly ISiemensOperationModelRepository _siemensOperationModelRepository;

        public RepositoryManager( RepositoryContext context, IMobusOperationModelRepository mobusOperationModelRepository, ISiemensOperationModelRepository siemensOperationModelRepository)
        {
            _context = context;
            _mobusOperationModelRepository = mobusOperationModelRepository;
            _siemensOperationModelRepository = siemensOperationModelRepository;
        }
        public IMobusOperationModelRepository MobusOperationModel => _mobusOperationModelRepository;

        public ISiemensOperationModelRepository SiemensOperationModel => _siemensOperationModelRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}