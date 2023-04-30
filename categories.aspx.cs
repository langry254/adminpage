using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminpage
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //call the connection class
            dataclass.dbcon();
            //lbl display not visible
           lbldis.Visible = false;
            lbldis2.Visible = false;
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            // Get the file name and extension
            string fileName = Path.GetFileName(FileUpload2.FileName);
            string fileExtension = Path.GetExtension(fileName);

           
            
            //database tings
            //require validate
            string catname = tblcatname.Text;
            if (catname == "" || fileName == "")
            {

                lbldis.Text = "The textboxes are empty";
                lbldis.Visible = true;
                lbldis.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                //declare sql statement

                string sqlstate = "INSERT INTO Categories values('" + catname + "','" + fileName + "')";

                //create an sql command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlstate;
                //associate command to connection
                cmd.Connection = dataclass.con;

                //excec the query
                cmd.ExecuteNonQuery();
                dataclass.con.Close();

                //clear the textboxes
                tblcatname.Text = "";

                // Show a success message using Js
                string script = "alert('Item added successfully.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "successMessage", script, true);
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string prodname = txtprodname.Text;
            decimal price=Convert.ToDecimal(txtprice.Text);
            int prodquantity = Convert.ToInt32(txtquantity.Text);
            string filename2=Path.GetFileName(FileUpload1.FileName);
            string cname = DropDownList2.Text;

            if (prodname == "" || price == 0 || prodquantity == 0 || filename2 == "")
            {
                lbldis2.Text = "Text boxes are empty";
                lbldis2.Visible = true;
                lbldis2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                string sqlstate2 = "INSERT INTO Products(prod_name, price, quantity, ImageUrl, cat_id) values('" + prodname + "','" + price + "','" + prodquantity + "','" + filename2 + "', (SELECT TOP 1 cat_id FROM Categories WHERE name = '" + cname + "'))";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlstate2;
                cmd.Connection = dataclass.con;
                cmd.ExecuteNonQuery();
                dataclass.con.Close();

                // Clear the textboxes
                txtprice.Text = "";
                txtprodname.Text = "";
                txtquantity.Text = "";

                // Show a success message using Js
                string script = "alert('Item added successfully.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "successMessage", script, true);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //onclick clear the textboxes
            txtprice.Text = "";
            txtprodname.Text = "";
            txtquantity.Text = "";
        }
    }
}