using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_3_Final_Project
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            label3.Text = Login.UserName;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void productimg_Click(object sender, EventArgs e)
        {
            ProductManagment fm = new ProductManagment();
            this.Hide();
            fm.Show();
        }

        private void categoryimg_Click(object sender, EventArgs e)
        {
            CategoryManagment fm = new CategoryManagment();
            this.Hide();
            fm.Show();
        }

        private void userimg_Click(object sender, EventArgs e)
        {
            UserManagment fm = new UserManagment();
            this.Hide();
            fm.Show(); 
        }

        private void customerimg_Click(object sender, EventArgs e)
        {
            CustomerManagment fm = new CustomerManagment();
            this.Hide();
            fm.Show();
      
        }

        private void orderimg_Click(object sender, EventArgs e)
        {
            OrderManagment fm = new OrderManagment();
            this.Hide();
            fm.Show();
        }
    }
}
