using Entities.Models;
using Repositories.Models;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IMobusOperationModelRepository MobusOperationModel {get;}
        ISiemensOperationModelRepository SiemensOperationModel {get;}
        void Save();
    }
}