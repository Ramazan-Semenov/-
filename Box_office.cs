//using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

using MetroFramework;

namespace WindowsFormsApp4 
{
    public partial class Box_office : MetroForm
    {
     //   private readonly MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=турагенство;password=root");
       // private readonly SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);

        public Box_office()
        {
            InitializeComponent();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        public DataTable LoadDB()
        {
            //   MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=сеть_ресторанов;password=root");

            SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);

            connection.Open();

            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("select * from турагенство.склад", connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            //  sqlCommandBuilder.GetDeleteCommand();
            DataSet dataSet = new DataSet();
            SqlDataAdapter.Fill(dataSet, "склад");
            dataSet.Tables[0].Locale = System.Globalization.CultureInfo.InvariantCulture;
            connection.Close();
            connection.Dispose();
            return dataSet.Tables[0];



        }

        void sdv()
        {

            ofbox1.ListViewProducts.ItemsSource = LoadDB().DefaultView;

        }

        private void elementHost1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Box_office_Load(object sender, EventArgs e)
        {
            sdv();
        }
        private decimal cena()
        {
            SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);
            decimal res = 0;
            try
            {
                if (res != 0)
                {
                    // MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=сеть_ресторанов;password=root");



                    connection.Open();
                    SqlCommand mySqlCommand = new SqlCommand("SELECT цена FROM турагенство.склад WHERE idсклад=" + "'" + ofbox.id + "'", connection);
                    res = (decimal)mySqlCommand.ExecuteScalar();
                    connection.Close();
                    connection.Dispose();
                    return res;
                }
                return res;

            }
            catch (Exception ex)
            {
                return res;
            }
        }
        private void reload()
        {
           ofbox1.ListViewProducts.ItemsSource = LoadDB().DefaultView;
        }
        private string name()
        {
            SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);


            string res;

            connection.Open();
            SqlCommand mySqlCommand = new SqlCommand("SELECT имя FROM турагенство.склад WHERE idсклад=" + "'" + ofbox.id + "'", connection);
            res = (string)mySqlCommand.ExecuteScalar();
            connection.Close();
            connection.Dispose();
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);
            try
            {

                //   MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=сеть_ресторанов;password=root");



                connection.Open();
                SqlCommand mySqlCommand = new SqlCommand("UPDATE турагенство.склад SET количество=количество-1 WHERE idсклад=" + "" + ofbox.id + "", connection);
                mySqlCommand.ExecuteNonQuery();
                connection.Close();

                connection.Dispose();




                reload();
            }
            catch(Exception exp) { MessageBox.Show(exp.Message); }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Ost ost = new Ost();
            ost.ShowDialog();
        }

        private void metroButton1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(metroButton1,"Кнопка для продажи товара");
        }

        private void metroButton2_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(metroButton2,"Открыть форму для создания новой путёвки");
        }

        private void metroButton3_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(metroButton3, @"Добавление\Редактиование\Удаление записей из базы данных");

        }

        private void metroButton4_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(metroButton4, @"Просмотр остатков товара на скаде");

        }
    }
}
