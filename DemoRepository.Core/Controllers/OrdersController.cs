using DemoRepository.Data;
using DemoRepository.Entity;
using DemoRepository.Infrastructure;
using DemoRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using DemoRepository.Core.Models;


namespace DemoRepository.Core.Controllers
{
    public class OrdersController : ApiController
    {
        public OrdersController()
        {
            this.unitOfWork = BLContainer.Resolve<IUnitOfWork>();
        }
        private IRepositoryBase<Customer> customerRepository;
        private IRepositoryBase<Order> orderRepository;

        public IUnitOfWork unitOfWork { get; set; }

        //public _Default()
        //{
        //    this.unitOfWork = BLContainer.Resolve<IUnitOfWork>();
        //}


        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    customerRepository = unitOfWork.Repository<Customer>();
        //    orderRepository = unitOfWork.Repository<Order>();
        //    load();
        //}


        // GET api/values
        public IEnumerable<OrderModel> Get()
        {
            customerRepository = unitOfWork.Repository<Customer>();
            orderRepository = unitOfWork.Repository<Order>();
            return getData();
        }

        // GET api/values/5
        public object Get(int id)
        {
            return new { name = "value", id = id };
        }


        private IEnumerable<OrderModel> getData()
        {
            var query = from orders in orderRepository.Table
                        from customers in customerRepository.Table.Where(c => c.CustomerID == orders.CustomerId)
                        select new OrderModel
                        {
                            OrderId = orders.OrderId,
                            CustomerId = customers.CustomerID,
                            CompanyName = customers.CompanyName,
                            Address = orders.ShipAddress,
                            Country = orders.ShipCountry
                        };

            return query.ToList();

        }
    }
}
