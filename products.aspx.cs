using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace adminpage
{
    public partial class orderlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataclass.dbcon();

            if (!IsPostBack)
            {
                bindData();
            }

            //the select statement
            string query = "SELECT p.product_id, p.prod_name AS Name, p.price, p.quantity, p.ImageUrl, c.name AS Category, p.date FROM" +
                " Products p INNER JOIN Categories c ON p.cat_id = c.cat_id";
            SqlCommand cmd= new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = dataclass.con;
          

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            
            adapter.Fill(table);

            GridView1.DataSource = table;
            GridView1.DataBind();

           

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            


        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (GridView1.DataKeys.Count > e.RowIndex)
            {
                int product_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

                // write your delete statement here
                string del = "DELETE FROM Products WHERE product_id = @product_id";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = del;
                cmd.Connection = dataclass.con;
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                dataclass.con.Close();
                bindData();
            }



        }
        protected void bindData()
        {
            // rebind the GridView to refresh the data
            string query = "SELECT p.product_id, p.prod_name AS Name, p.price, p.quantity, p.ImageUrl, c.name AS Category, p.date FROM" +
               " Products p INNER JOIN Categories c ON p.cat_id = c.cat_id";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            cmd.Connection = dataclass.con;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);

            GridView1.DataSource = table;
            GridView1.DataBind();
        }













    }
}