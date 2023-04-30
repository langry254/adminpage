﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminpage
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //display the text on the cards
            dataclass.dbcon();
            // count the number of products
            string sqlQuery = "SELECT COUNT(*) AS ProductCount FROM Products;";

            // Create a new SqlConnection object and open the connection
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlQuery;
            cmd.Connection = dataclass.con;

            // Execute the query and retrieve the result as a SqlDataReader object
                using(SqlDataReader reader = cmd.ExecuteReader())
        {
                // If the reader has rows, read the first row and retrieve the value of the "ProductCount" column
                if (reader.HasRows && reader.Read())
                {
                    int productCount = reader.GetInt32(reader.GetOrdinal("ProductCount"));

                   //display on the card
                    Label1.Text = productCount.ToString();
                    
                }
            
        }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}