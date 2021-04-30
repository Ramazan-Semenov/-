using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
//using MySql.Data.MySqlClient;
namespace WindowsFormsApp4
{
    internal class ConnectionDB
    {
        protected SqlCommandBuilder  sqlCommandBuilder = null;
        protected SqlDataAdapter SqlDataAdapter = null;

        //private static readonly string kkk = @"Server=MYSQL5031.site4now.net;Database=db_a6a4ef_sharp65;Uid=a6a4ef_sharp65;Pwd=qwerty123";
        //public static MySqlConnection connection = new MySqlConnection(kkk);
        //  public static MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=турагенство;password=root");
      public static  SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=" + @Directory.GetCurrentDirectory()+"\\турагентство.mdf" + ";Integrated Security=True;Connect Timeout=30");
    
        public void con(string AttachDBFilenametxt, string InitialCatalogtxt)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @AttachDBFilenametxt + "\\" + InitialCatalogtxt + ";Integrated Security=True;Connect Timeout=30");


        }
     

        

    }
}
