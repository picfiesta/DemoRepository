using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderModel
/// </summary>

namespace DemoRepository.Core.Models
{
    public class OrderModel
    {
        public OrderModel()
        {

        }

        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}