using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Class1
    {
           
        SqlConnection con = new SqlConnection(@"Data Source = db.edu.cchgeu.ru; Initial Catalog = 201s_Ermolaev; User = 201s_Ermolaev; Password = 201s_Ermolaev");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
    

