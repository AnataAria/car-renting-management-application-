using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingManagementWinApp_NQVinh
{
    public partial class frmCustomerManagement : Form
    {
        ICustomerRepository _customerRepository;
        public frmCustomerManagement()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private List<Customer> GetAllCustomerList()
        {
            List<Customer> list = _customerRepository.GetAll();
            if (list == null) return new List<Customer>();
            return list;
        }


    }
}
