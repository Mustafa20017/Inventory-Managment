using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Module_3_Final_Project
{
    class Category
    {
        public int id { get; set; }
        public string CategoriesName { get; set; }

        public Category() { }

        public Category(string categoryname)
        {
            this.CategoriesName = categoryname;
        }

        public DataTable GetAllCategory()
        {
            SqlCommand cmd = new SqlCommand("GetAllCategory", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;  

        }
        public void AddCategory()
        {
            SqlCommand cmd = new SqlCommand("AddCategory", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName",this.CategoriesName);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetCategoryById(int id)
        {
            SqlCommand cmd = new SqlCommand("GetCategoryById", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void UpdateCategory()
        {
            SqlCommand cmd = new SqlCommand("UpdateCategory", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", this.id);
            cmd.Parameters.AddWithValue("@CategoryName", this.CategoriesName);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCategory(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteCategory", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", id);
            cmd.ExecuteNonQuery();
        }
    }

}
