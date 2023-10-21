using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Customer
    {
        public Customer()
        {
            RentingTransactions = new HashSet<RentingTransaction>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime? CustomerBirthday { get; set; }
        public byte? CustomerStatus { get; set; }
        public string Password { get; set; }

        public Customer(int customerId, string customerName, string telephone, string email, DateTime? customerBirthday, byte? customerStatus, string password)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Telephone = telephone;
            Email = email;
            CustomerBirthday = customerBirthday;
            CustomerStatus = customerStatus;
            Password = password;
        }

        public virtual ICollection<RentingTransaction> RentingTransactions { get; set; }
    }
}
