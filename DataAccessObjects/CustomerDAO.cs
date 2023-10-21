using BusinessObjects;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public Customer GetCustomerByEmail(string email)
        {
            var customer = _context.Entity.FirstOrDefault(data => data.Email.Equals(email));
            /*var customer = (from c in _context.Entity
                           where c.Email.Equals(email)
                           select new Customer()
                           {
                              CustomerId = c.CustomerId,
                              CustomerName = c.CustomerName,
                              Telephone = c.Telephone,
                              Email = c.Email,
                              CustomerBirthday = c.CustomerBirthday,
                              CustomerStatus = c.CustomerStatus,
                              Password = c.Password,
                           });*/
            return customer;
        }


    }
}
