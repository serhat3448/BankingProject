using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;

        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>
            {
                new Customer{CustomerId=1,AccountId=111111,CustomerName="Serhat",CustomerSurname="Doğru",CustomerAdress="İstanbul", TelephoneNumber="05551234567"},
                new Customer{CustomerId=2,AccountId=222222,CustomerName="Serkan",CustomerSurname="Doğru",CustomerAdress="Ankara", TelephoneNumber="05552222222"},
            };
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(_customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId));
        }

        public Customer Get(int customerId)
        {
            return _customers.SingleOrDefault(c => c.CustomerId == customerId);
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = _customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
            customerToUpdate.CustomerName = customer.CustomerName;
            customerToUpdate.CustomerSurname = customer.CustomerSurname;
            customerToUpdate.CustomerAdress = customer.CustomerAdress;
            customerToUpdate.TelephoneNumber = customer.TelephoneNumber;
        }
    }
}
