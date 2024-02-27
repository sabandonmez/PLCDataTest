using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;
 public class RepositoryContext:DbContext
    {
        public DbSet<ModbusOperationModel> ModbusOperationModel { get; set; }
        public DbSet<SiemensOperationModel> SiemensOperationModel { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
