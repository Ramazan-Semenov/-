//using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace WindowsFormsApp4
{
    public partial class Form1 : MetroForm
    {
        private static string p;
        private readonly SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }
        private void add()
        {
       ///     MySqlConnection connection = new MySqlConnection(@"server=localhost;user=root;database=турагенство;password=root");

            string sql = "INSERT INTO [турагенство].склад (имя,image,количество,цена) VALUES (@имя,@file,@количество,@цена)";

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);

            // parameterize query to safeguard against sql injection attacks, etc. 
            cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(@p));
            cmd.Parameters.AddWithValue("@количество", int.Parse(metroTextBox3.Text));
            cmd.Parameters.AddWithValue("@имя", metroTextBox1.Text);
            cmd.Parameters.AddWithValue("@цена", decimal.Parse(metroTextBox2.Text));
            cmd.ExecuteNonQuery();





        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                p = openFileDialog.FileName;
                metroTextBox4.Text = p;
                Bitmap bitmap = new Bitmap(p);
                pictureBox1.Image = bitmap;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            add();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
