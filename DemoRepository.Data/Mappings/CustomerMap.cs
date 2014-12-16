using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DemoRepository.Entity;

namespace DemoRepository.Repository
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {

        public CustomerMap()
        {
            //key  
            HasKey(t => t.CustomerID);
            //fields  
            Property(t => t.CompanyName).IsRequired();
            Property(t => t.ContactName);
            Property(t => t.ContactTitle);
            Property(t => t.PostalCode);
            Property(t => t.Region);
            Property(t => t.City);
            Property(t => t.Address).HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.Country);
            Property(t => t.Fax);
            Property(t => t.Phone);
            Property(t => t.ID);
            Property(t => t.AddedDate);
            Property(t => t.ModifiedDate);
            //table  
            ToTable("Customers");

        }
    }
}
