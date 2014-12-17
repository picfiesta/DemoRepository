using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DemoRepository.Entity;

namespace DemoRepository.Repository
{
    class OrderMap : EntityTypeConfiguration<Order>
    {

        public OrderMap()
        {
            //key  
            HasKey(t => t.OrderId);
            //fields  
            Property(t => t.CustomerId);
            Property(t => t.OrderDate);
            Property(t => t.ShipAddress);
            Property(t => t.ShipCountry);
            Property(t => t.ShipName);
            Property(t => t.ID);
            Property(t => t.AddedDate);
            Property(t => t.ModifiedDate);
            //table  
            ToTable("Orders");

        }
    }
}
