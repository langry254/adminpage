using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminpage
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataclass.dbcon();

            //calling the biddata method
            bindData();

            
        }
        //method for binbding the data
        protected void bindData()
        {
            string query = "SELECT user_id, names,email,phon_no AS Mobile,type, created_at AS Date FROM Users";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = dataclass.con;


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);

            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (GridView1.DataKeys.Count > e.RowIndex)
            {
                int user_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

                // the delete statement
                string del = "DELETE FROM Users WHERE user_id = @user_id";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = del;
                cmd.Connection = dataclass.con;
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.ExecuteNonQuery();
                dataclass.con.Close();
                bindData();
            }



        }

        protected void btn_4_Click(object sender, EventArgs e)
        {
            string name=textname.Text;
            string mail=textemail.Text;
            int mobile = Convert.ToInt32(textphone.Text);
            string pass=textpassword.Text;
            string type = ddltype.SelectedValue;
            string c_pass = textconfirm.Text;

            // insert statement
            string insquery = "INSERT INTO Users(names,email,phon_no,password,type) values('"+name+"','"+mail+"','"+mobile+"','"+pass+"','"+type+"')";
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText=insquery;
            cmd.Connection = dataclass.con;

            cmd.ExecuteNonQuery();
            dataclass.con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}