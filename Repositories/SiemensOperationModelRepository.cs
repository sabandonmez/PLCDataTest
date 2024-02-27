using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class SiemensOperationModelRepository : RepositoryBase<SiemensOperationModel>, ISiemensOperationModelRepository
    {
        public SiemensOperationModelRepository(RepositoryContext context) : base(context)
        {
        }
    }
}