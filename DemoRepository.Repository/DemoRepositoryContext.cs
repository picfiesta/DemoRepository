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
            //Set primary key to Person table
           // modelBuilder.Entity<Customer>().HasKey(m => m.Id).Property(m => m.Id).IsRequired();
            //name fleld is required

           // modelBuilder.Entity<Person>().Property(p => p.name).IsRequired();
            //surname is required
           // modelBuilder.Entity<Person>().Property(p => p.surname).IsRequired();

            //set primary key to Address table
          //  modelBuilder.Entity<Address>().HasKey(m => m.personAdressId);

            //set max length property to 6 
           // modelBuilder.Entity<Address>().Property(m => m.pin).HasMaxLength(6);

            //Set foreign key property
          //  modelBuilder.Entity<Address>().HasRequired(t => t.Person)
          //      .WithMany().HasForeignKey(t => t.PersonId);
        }
       // public DbSet<CustomerCopy> customer { get; set; }
        //public DbSet<Address> Address { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
