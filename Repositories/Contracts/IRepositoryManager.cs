using Entities.Models;
using Repositories.Models;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product {get;}
        ICategoryRepository Category {get;}
        IMobusOperationModelRepository MobusOperationModel {get;}
        ISiemensOperationModelRepository SiemensOperationModel {get;}
        void Save();
    }
}