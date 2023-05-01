using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            PlaceHolder1.Visible = false;

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            


        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }
        // deleteting statement!!!!!!!!!!!
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            int p_id = Convert.ToInt32(TextBox1.Text);
            string ddl=DropDownList2.SelectedValue.ToString();
            string p_name=TextBox4.Text;
            int p_price=Convert.ToInt32(TextBox5.Text);
            int p_quantity=Convert.ToInt32(TextBox6.Text);
            string p_file = Path.GetFileName(FileUpload2.FileName);
            //to be changed
            string query = "SELECT COUNT(*) FROM Products WHERE product_id = @productId";
            SqlCommand cmd = new SqlCommand(query, dataclass.con);
            cmd.Parameters.AddWithValue("@productId", p_id);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                string script = "alert('Item added successfully.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "successMessage", script, true);
            }
            else
            {
                string updatequery = "UPDATE Products SET prod_name='" + p_name + "',price='" + p_price + "',quantity='" + p_quantity + "',ImageUrl='" + p_file + "',cat_id=(SELECT TOP 1 cat_id  FROM Categories WHERE name='" + ddl + "')" +
                    "WHERE product_id='" + p_id + "'";
                SqlCommand comms = new SqlCommand();
                comms.Connection = dataclass.con;
                comms.CommandText = updatequery;
                comms.ExecuteNonQuery();
                dataclass.con.Close();

                bindData();
            }



        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            

            PlaceHolder1.Visible = true;        
        
        }
    }
}