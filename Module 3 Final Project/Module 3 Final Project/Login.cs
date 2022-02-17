using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Module_3_Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
            
        }
        public static string UserName;
        

        private void clear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void shpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (shpassword.Checked)
            {
                txtpassword.isPassword = false;
            }
            else
            {
                txtpassword.isPassword = true;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            UserName = txtusername.Text;
            UserLogin US = new UserLogin(txtusername.Text,txtpassword.Text);
                DataTable dt = US.LoginUser();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DashBoard db = new DashBoard();
                    this.Hide();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            
         
        }
    }
}
