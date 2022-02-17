using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Module_3_Final_Project
{
    class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        public Customer() { }
        public Customer(string name,string address,string phoneno)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNo = phoneno;
        }
        public DataTable GetAllCustomer()
        {
            SqlCommand cmd = new SqlCommand("GetAllCustomer", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void AddCustomer()
        {
            SqlCommand cmd = new SqlCommand("AddCustomer", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.Parameters.AddWithValue("@PhoneNo", this.PhoneNo);
            cmd.ExecuteNonQuery();
        }
        public void UpdateCustomer()
        {
            SqlCommand cmd = new SqlCommand("UpdateCustomer", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", this.id);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.Parameters.AddWithValue("@PhoneNo", this.PhoneNo);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetCustomerById(int id)
        {
            SqlCommand cmd = new SqlCommand("GetCustomerById", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }
        public void DeleteCustomer(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteCustomer", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
