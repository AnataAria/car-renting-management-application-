using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public Boolean UserLogin(string email, string password);
        public List<Customer> GetAll();
    }
}
