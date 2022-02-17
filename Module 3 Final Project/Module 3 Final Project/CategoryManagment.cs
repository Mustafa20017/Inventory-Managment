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
    public partial class CategoryManagment : Form
    {
        public CategoryManagment()
        {
            InitializeComponent();
        }
        int id;
        private void CategoryManagment_Load(object sender, EventArgs e)
        {
            Category c = new Category();
            categorydatagridview.DataSource = c.GetAllCategory();
        }

        public void cleartextbox()
        {
            categorytextbox.Text = "Category Name";
        }

        private void addcategory_Click(object sender, EventArgs e)
        {
            if(categorytextbox.Text == "")
            {
                MessageBox.Show("Please Enter Category Name");
            }
            else
            {
                Category c = new Category(categorytextbox.Text);
                c.AddCategory();
                categorydatagridview.DataSource = c.GetAllCategory();
                cleartextbox();
            }
        }
        private int Categoryid;
        public void fillcategoryinfo(DataTable dt)
        {
            if(dt != null)
            {
                Categoryid = Convert.ToInt32(dt.Rows[0][0].ToString());
                categorytextbox.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("No record found");
            }
            
        }

        private void categorydatagridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addcategory.Visible = false;
            updatecategory.Visible = true;
            deletecategory.Visible = true;

            try
            {
                id = Convert.ToInt32(categorydatagridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                Category c = new Category();
                DataTable dt =  c.GetCategoryById(id);
                fillcategoryinfo(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show("No record found");
            }
        }

        private void updatecategory_Click(object sender, EventArgs e)
        {
            if(categorytextbox.Text == "")
            {
                MessageBox.Show("Please Enter Category Name");
            }
            else
            {
                Category c = new Category(categorytextbox.Text);
                c.id = Categoryid;
                c.UpdateCategory();
                categorydatagridview.DataSource = c.GetAllCategory();
                cleartextbox();
            }

            addcategory.Visible = true;
            updatecategory.Visible = false;
            deletecategory.Visible = false;
            
        }

        private void deletecategory_Click(object sender, EventArgs e)
        {
            DialogResult dx = MessageBox.Show("Do You want to delete this category", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dx == DialogResult.OK)
            {
                Category c = new Category();
                c.DeleteCategory(Categoryid);
                categorydatagridview.DataSource = c.GetAllCategory();
                cleartextbox();
                addcategory.Visible = true;
                updatecategory.Visible = false;
                deletecategory.Visible = false;
            }
            else
            {

            }

        }

        private void homeuser_Click(object sender, EventArgs e)
        {
            DashBoard fm = new DashBoard();
            this.Hide();
            fm.Show();
        }
    }
}
