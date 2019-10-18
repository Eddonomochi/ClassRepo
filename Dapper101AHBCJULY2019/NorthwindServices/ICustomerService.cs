using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper101AHBCJULY2019.DAL;
using Dapper101AHBCJULY2019.DAL.Models;
using Dapper101AHBCJULY2019.Models;

namespace Dapper101AHBCJULY2019.NorthwindServices
{
    public interface ICustomerService
    {
        CustomersViewModel GetCustomers();
        Customer GetCustomer(string firstName);
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerStore _customerStore;

        public CustomerService(ICustomerStore customerStore)
        {
            _customerStore = customerStore;
        }

        public CustomersViewModel GetCustomers()
        {
            var dalCustomers = _customerStore.SelectAllCustomers();

            var customers = new List<Customer>();

            foreach (var dalCustomer in dalCustomers)
            {
                var customer = MapCustomer(dalCustomer);
                customers.Add(customer);
            }

            var customerViewModel = new CustomersViewModel();
            customerViewModel.Customers = customers;

            return customerViewModel;
        }

        public Customer GetCustomer(string firstName)
        {
            var dalCustomer = _customerStore.SelectCustomerByFirstName(firstName);

            var customer = MapCustomer(dalCustomer);

            return customer;
        }

        private Customer MapCustomer(CustomerDALModel dalCustomer)
        {
            var customer = new Customer();
            customer.CompanyName = dalCustomer.CompanyName;
            customer.Id = dalCustomer.CustomerID;
            customer.Address = dalCustomer.Address;
            customer.City = dalCustomer.City;
            customer.PostalCode = dalCustomer.PostalCode;
            customer.Phone = dalCustomer.Phone;
            customer.Region = dalCustomer.Region;
            customer.Country = dalCustomer.Country;
            return customer;
        }
    }
}
