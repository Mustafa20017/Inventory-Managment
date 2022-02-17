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
    public partial class CustomerManagment : Form
    {
        int id;
        public CustomerManagment()
        {
            InitializeComponent();
        }

        private void CustomerManagment_Load(object sender, EventArgs e)
        {
            Customer c = new Customer();
            customerdatagrid.DataSource = c.GetAllCustomer();
        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            if (customername.Text == "" || customeraddress.Text == "" || customerphone.Text == "")
            {
                MessageBox.Show("Plz Enter full details");
            }
            else
            { 
                Customer c = new Customer(customername.Text, customeraddress.Text, customerphone.Text);
                c.AddCustomer();
                customerdatagrid.DataSource = c.GetAllCustomer();
                cleartextbox();
            }

        }

        private void customerdatagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addcustomer.Visible = false;
            updatecustomer.Visible = true;
            deletecustomer.Visible = true;
            try
            {
                id = Convert.ToInt32(customerdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                Customer c = new Customer();
                DataTable dt = c.GetCustomerById(id);
                fullcustomerinfo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record");
            }
        }
        private int CustomerID;
        public void fullcustomerinfo(DataTable dt)
        {
            if (dt != null)
            {
                CustomerID = Convert.ToInt32(dt.Rows[0][0].ToString());
                customername.Text = dt.Rows[0][1].ToString();
                customeraddress.Text = dt.Rows[0][2].ToString();
                customerphone.Text = dt.Rows[0][3].ToString();

            }
            else
            {
                MessageBox.Show("No Record Found");
            }


        }

        private void updatecustomer_Click(object sender, EventArgs e)
        {
            if (customername.Text == "" || customeraddress.Text == "" || customerphone.Text == "")
            { 
                 MessageBox.Show("Plz Enter full details");
            }
            else
            {
                addcustomer.Visible = true;
                updatecustomer.Visible = false;
                deletecustomer.Visible = false;
                Customer c = new Customer(customername.Text, customeraddress.Text, customerphone.Text);
                c.id = CustomerID;
                c.UpdateCustomer();
                customerdatagrid.DataSource = c.GetAllCustomer();
                cleartextbox();
            }
            
        }

        private void deletecustomer_Click(object sender, EventArgs e)
        {
            DialogResult dx = MessageBox.Show("Do You want to delete this customer", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dx == DialogResult.OK)
            {
                addcustomer.Visible = true;
                updatecustomer.Visible = false;
                deletecustomer.Visible = false;
                Customer c = new Customer();
                c.DeleteCustomer(CustomerID);
                customerdatagrid.DataSource = c.GetAllCustomer();
                cleartextbox();
            }
            else
            {

            }
                
        }

        private void homecustomer_Click(object sender, EventArgs e)
        {
            DashBoard fm = new DashBoard();
            this.Hide();
            fm.Show();
        }
        public void cleartextbox()
        {
            customername.Text = "Name";
            customeraddress.Text = "Address";
            customerphone.Text = "PhoneNo";
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerphone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void customeraddress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void customername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
