using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class MobusOperationModelManager:IMobusOperationModelService
    {
        private readonly IRepositoryManager _manager;

        public MobusOperationModelManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        
    }
}