using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace adminpage
{
    public class dataclass
    {
        public static SqlConnection con;

        public static void dbcon()
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\B\\Source\\Repos\\langry254\\adminpage\\App_Data\\kapfarm.mdf;Integrated Security=True";
            con = new SqlConnection(constring);

            //check connection state
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }


    }
}