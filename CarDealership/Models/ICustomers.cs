using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    interface ICustomers
    {
        
        IEnumerable<Customer> Customers { get; }
        
        Customer this[int id] { get; }

        
        Customer AddCustomer(Customer customer);
        
        Customer UpdateCustomer(Customer customer);
        
        void DeleteCustomer(int id);
    }
}
