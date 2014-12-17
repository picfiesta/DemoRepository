using DemoRepository.Data;
using DemoRepository.Entity;
using DemoRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    private UnitOfWork unitOfWork;
    private IRepositoryBase<Customer> customerRepository;
    private IRepositoryBase<Order> orderRepository;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        unitOfWork = new UnitOfWork();
        customerRepository = unitOfWork.Repository<Customer>();
        orderRepository = unitOfWork.Repository<Order>();
        load();
    }


    private void load()
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

        dgOrders.DataSource = query.ToList();
        dgOrders.DataBind();


    }
}