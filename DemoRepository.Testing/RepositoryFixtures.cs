using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoRepository.Entity;
using DemoRepository.Data;
using System.Diagnostics;
using DemoRepository.Repository;
using System.Collections;
using System.Linq;
using System.Data.Entity;
using Rhino.Mocks;
using System.Collections.Generic;

namespace DemoRepository.Testing
{
    [TestClass]
    public class RepositoryFixtures
    {
        //private IRepository _repository;
        //private UnitOfWork unitOfWork;
        private IRepositoryBase<Customer> customer;
        private MockRepository mockRepository;
        
        [TestInitialize]
        public void Initialize()
        { 
            //unitOfWork = new UnitOfWork();
            // customer = unitOfWork.Repository<Customer>();
            mockRepository = new MockRepository();
          //  _repository = new RepositoryBase();
            customer = mockRepository.DynamicMock<IRepositoryBase<Customer>>();
        }


        [TestMethod]
        public void Table_RepositoryAction_NoException()
        {
            var list = new List<Customer>();
            for (int i = 1; i<3; i++ )
            {
                Customer cust = new Customer();
                cust.ID = i;
                cust.AddedDate = DateTime.Now;
                cust.ModifiedDate = DateTime.Now;
                cust.CompanyName = "Hello";
                cust.CustomerID = "ALIFL";
                list.Add(cust);
            }
            using (mockRepository.Record())
            {
                customer.Table.ToList();
                LastCall.Return(list);
            }

        }

        [TestMethod]
        public void Insert_RepositoryAction_NoException()
        {
            Customer cust = new Customer();
            cust.ID = 1;
            cust.AddedDate = DateTime.Now;
            cust.ModifiedDate = DateTime.Now;
            cust.CompanyName = "Hello";
            cust.CustomerID = "ALIFL";
            customer.Insert(cust);
            mockRepository.ReplayAll();
        }

        [TestMethod]
        public void Delete_RepositoryAction_NoException()
        {
            Customer cust = new Customer();
            cust.ID = 1;
            cust.AddedDate = DateTime.Now;
            cust.ModifiedDate = DateTime.Now;
            cust.CompanyName = "Hello";
            cust.CustomerID = "ALIFL";
            customer.Delete(cust);
            mockRepository.ReplayAll();
        }

        [TestMethod]
        public void Query_GetById_NoException()
        {
            IRepositoryBase<Customer> customerRepositoryStub = mockRepository.Stub<IRepositoryBase<Customer>>();
            {
                Customer customerStub = mockRepository.Stub<Customer>();
                customerStub.CustomerID = "1";
                customerStub.CompanyName = "FirstName";
                customerStub.ContactName = "LastName";
                customerStub.Country = "e@mail.com";

                using (mockRepository.Record())
                {
                    customerRepositoryStub.GetById(1);
                    LastCall.Return(customerStub);
                }

                mockRepository.Verify(customerRepositoryStub);

            }
        }
    }
}

    