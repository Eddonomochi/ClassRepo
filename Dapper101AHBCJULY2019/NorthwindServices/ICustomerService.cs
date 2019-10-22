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
        CustomerViewModel GetCustomer(string firstName);
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

            var customers = new List<CustomerViewModel>();

            foreach (var dalCustomer in dalCustomers)
            {
                var customer = MapCustomerViewModel(dalCustomer);
                customers.Add(customer);
            }

            var customerViewModel = new CustomersViewModel();
            customerViewModel.Customers = customers;

            return customerViewModel;
        }

        public CustomerViewModel GetCustomer(string firstName)
        {
            var dalCustomer = _customerStore.SelectCustomerByFirstName(firstName);

            var customer = MapCustomerViewModel(dalCustomer);

            return customer;
        }

        private CustomerViewModel MapCustomerViewModel(CustomerDALModel dalCustomer)
        {
            var customer = new CustomerViewModel();
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
