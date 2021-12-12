using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class CustomerRepository : ICustomers
    {
        private Dictionary<int, Customer> items;

        public CustomerRepository()
        {
            items = new Dictionary<int, Customer>();
            //some hard code data for the table
            new List<Customer>
            {
                new Customer{ID=1,Name="Smith",Email="customer123",phoneNumber=12345678 },
                new Customer{ID=2,Name="Larry",Email="larry@gmail.com",phoneNumber=456346374 },
            }.ForEach(c => AddCustomer(c));
        }
        public Customer this[int id] => items.ContainsKey(id) ? items[id] : null;
        public IEnumerable<Customer> Customer => items.Values;

        public IEnumerable<Customer> Customers => throw new NotImplementedException();

        public Customer AddCustomer(Customer customer)
        {
            if (customer.ID == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key))
                { key++; }
                items[key] = customer;
            }

            items[customer.ID] = customer;
            return customer;
        }
        public void DeleteCustomer(int id) => items.Remove(id);

        public Customer UpdateCustomer(Customer customer)
            => AddCustomer(customer);
    }
}
