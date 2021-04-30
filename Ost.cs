//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace WindowsFormsApp4
{
    public partial class Ost : MetroForm
    {
       

        public Ost()
        {
            InitializeComponent();
            rep();
        }
        private void rep()
        {
            SqlConnection connection = new SqlConnection(ConnectionDB.connection.ConnectionString);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("select имя,количество from турагенство.склад ", connection);
                 DataTable dataSet = new DataTable();

                 dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet;
                connection.Close();
                connection.Dispose();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ost_Load(object sender, EventArgs e)
        {

        }
        public void SaveEx(DataGridView dataGridView)
        {

            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = excelapp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {



                    for (int i = 0; i < dataGridView.RowCount + 1; i++)
                    {
                        for (int j = 1; j < dataGridView.ColumnCount + 1; j++)
                        {
                            if (i == 0)
                            {
                                worksheet.Rows[i + 1].Columns[j] = dataGridView.Columns[j - 1].HeaderText;
                            }
                            else
                            {
                                worksheet.Rows[i + 1].Columns[j] = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                            }
                        }
                    }

                    excelapp.AlertBeforeOverwriting = false;
                    workbook.SaveAs(saveFileDialog1.FileName);
                    excelapp.Quit();



                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveEx(dataGridView1);
        }
    }
}
