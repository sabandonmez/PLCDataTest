using System.Linq.Expressions;
using Entities.Models;
using Repositories.Contracts;
using Repositories.Models;

namespace Repositories
{
    public class MobusOperationModelRepository : RepositoryBase<ModbusOperationModel>, IMobusOperationModelRepository
    {
        public MobusOperationModelRepository(RepositoryContext context) : base(context)
        {
        }

    }
}