using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private CustomerDAO customerDAO;
        public CustomerRepository()
        {
            this.customerDAO = new CustomerDAO();
        }

        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            list = customerDAO.GetAll().Result;
            return list;
        }

        public Boolean UserLogin(string email, string password)
        {
            var user = customerDAO.GetCustomerByEmail(email);
            if (user == null) return false;
            if(user.Password.Equals(password)) return true;
            return false;
        }
    }
}
