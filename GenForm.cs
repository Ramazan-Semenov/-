using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using GenFormDBDll;
using MetroFramework.Forms;
using MetroFramework;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class DB : MetroForm
    {

  
        public DB()
        {
            InitializeComponent();
        }
        public DB(string tablename)
        {
            InitializeComponent();
        }
        public DB(string tablename, string nameCollumn)
        {
            InitializeComponent();
         
            
        }

        private  void GenForm_Load(object sender, EventArgs e)
        {

        genFormdll1.Start(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=" + @Directory.GetCurrentDirectory() + "\\турагентство.mdf" + ";Integrated Security=True;Connect Timeout=30");
        }

        private  void DataGridViewReload_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

          
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void genFormdll1_Load(object sender, EventArgs e)
        {

        }

        private void genFormdll1_Load_1(object sender, EventArgs e)
        {

        }

        private void genFormdll1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
