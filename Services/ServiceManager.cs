using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IMobusOperationModelService _mobusOperationModelService;
        public ServiceManager( IMobusOperationModelService mobusOperationModelService)
        {
            _mobusOperationModelService = mobusOperationModelService;
        }
        public IMobusOperationModelService MobusOperationModelService => _mobusOperationModelService;
    }
}