using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class SiemensOperationModelManager:ISiemensOperationModelService
    {
        private readonly IRepositoryManager _manager;

        public SiemensOperationModelManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
    }
}