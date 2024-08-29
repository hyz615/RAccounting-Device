using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        private SQLiteConnection sqlite_conn;
        private SQLiteDataAdapter sqlite_dataadapter;
        private DataTable dataTable;
        private void InitializeDatabase()
        {
            sqlite_conn = new SQLiteConnection("Data Source=stest.db;Version=3;");
            sqlite_conn.Open();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM tbl_money";
            sqlite_dataadapter = new SQLiteDataAdapter(query, sqlite_conn);
            dataTable = new DataTable();
            sqlite_dataadapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(sqlite_dataadapter);
            sqlite_dataadapter.InsertCommand = new SQLiteCommand("INSERT INTO tbl_money (tag, moneyexpend, date) VALUES (@tag, @moneyexpend, @date)", sqlite_conn);
            sqlite_dataadapter.InsertCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));
            sqlite_dataadapter.InsertCommand.Parameters.Add(new SQLiteParameter("@moneyexpend", DbType.Double, 0, "moneyexpend"));
            sqlite_dataadapter.InsertCommand.Parameters.Add(new SQLiteParameter("@date", DbType.Date, 0, "date"));
            sqlite_dataadapter.UpdateCommand = new SQLiteCommand("UPDATE tbl_money SET moneyexpend = @moneyexpend, date = @date WHERE tag = @tag", sqlite_conn);
            sqlite_dataadapter.UpdateCommand.Parameters.Add(new SQLiteParameter("@moneyexpend", DbType.Double, 0, "moneyexpend"));
            sqlite_dataadapter.UpdateCommand.Parameters.Add(new SQLiteParameter("@date", DbType.Date, 0, "date"));
            sqlite_dataadapter.UpdateCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));
            sqlite_dataadapter.DeleteCommand = new SQLiteCommand("DELETE FROM tbl_money WHERE tag = @tag", sqlite_conn);
            sqlite_dataadapter.DeleteCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));

        }
        private void SaveData()
        {
            try
            {
                sqlite_dataadapter.Update(dataTable);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        /*private void addRows()
        {
            dataTable.Rows.Add();
            dataTable.DataSet.
        }*/
        private void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
            {
                dataTable.Rows[rowIndex].Delete();
                
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i <= dataGridView1.SelectedRows.Count - 1; i++)

                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    DeleteRow(rowIndex);
                }
                /*for (int i = dataGridView1.SelectedRows.Count-1; i>=0 ; i--)
                {
                    int rowIndex = dataGridView1.SelectedRows[i].Index;
                    DeleteRow(rowIndex);
                }*/
                SaveData();
                LoadData();
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
  
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
