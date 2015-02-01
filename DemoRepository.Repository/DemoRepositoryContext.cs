using DemoRepository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.Repository
{
    public class DemoRepositoryContext:DbContext
    {

        public DemoRepositoryContext()
            : base("name=DemoRepositoryDataContext")
        {
            Database.SetInitializer<DemoRepositoryContext>(null);
            //If model change, It will re-create new database.
            //Database.SetInitializer<DemoRepositoryContext>(new DropCreateDatabaseIfModelChanges<DemoRepositoryContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(k => k.CustomerID).Property(p => p.CustomerID).IsRequired();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
