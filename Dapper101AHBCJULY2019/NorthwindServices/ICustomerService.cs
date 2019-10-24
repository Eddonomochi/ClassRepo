﻿using System;
using System.Collections;
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
        CustomerViewModel GetCustomer(string id);
        CustomersViewModel AddCustomer(AddCustomerViewModel model);
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

            return MapCustomersViewModel(dalCustomers);
        }

        public CustomerViewModel GetCustomer(string id)
        {
            var dalCustomer = _customerStore.SelectCustomerById(id);

            var customer = MapCustomerViewModel(dalCustomer);

            return customer;
        }

        public CustomersViewModel AddCustomer(AddCustomerViewModel model)
        {
            var dalModel = MapToCustomerDalModel(model);

            _customerStore.InsertNewCustomer(dalModel);

            var dalCustomers = _customerStore.SelectAllCustomers();

            return MapCustomersViewModel(dalCustomers);
        }

        private CustomerViewModel MapCustomerViewModel(CustomerDALModel dalCustomer)
        {
            var customer = new CustomerViewModel();
            customer.CompanyName = dalCustomer.CompanyName;
            customer.Name = dalCustomer.ContactName;
            customer.Id = dalCustomer.CustomerID;
            customer.Address = dalCustomer.Address;
            customer.City = dalCustomer.City;
            customer.PostalCode = dalCustomer.PostalCode;
            customer.Phone = dalCustomer.Phone;
            customer.Region = dalCustomer.Region;
            customer.Country = dalCustomer.Country;
            return customer;
        }

        private CustomerDALModel MapToCustomerDalModel(AddCustomerViewModel src)
        {
            var dalCustomer = new CustomerDALModel();
            dalCustomer.ContactName = src.Name;
            dalCustomer.ContactTitle = src.Title;
            dalCustomer.City = src.City;
            dalCustomer.CompanyName = "Grand Circus";
            dalCustomer.CustomerID = Guid.NewGuid().ToString().Substring(0, 5);
            return dalCustomer;
        }

        private CustomersViewModel MapCustomersViewModel(IEnumerable<CustomerDALModel> dalCustomers)
        {
            var customers = new List<CustomerListItemViewModel>();

            foreach (var dalCustomer in dalCustomers)
            {
                customers.Add(new CustomerListItemViewModel(dalCustomer));
            }

            var customerViewModel = new CustomersViewModel();
            customerViewModel.Customers = customers;

            return customerViewModel;
        }

    }
}
