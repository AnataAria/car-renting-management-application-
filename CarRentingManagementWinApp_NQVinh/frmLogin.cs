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
    public partial class frmLogin : Form
    {
        ICustomerRepository customerRepository;
        public frmLogin()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tbUserName.Text;
            String password = tbPassword.Text;
            if(customerRepository.UserLogin(username, password))
            {
                MessageBox.Show("Login dc r dcm");
            }
            else
            {
                MessageBox.Show("DCM DEO DC");
            }
        }
    }
}
