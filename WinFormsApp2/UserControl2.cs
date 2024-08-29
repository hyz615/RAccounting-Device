using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace WinFormsApp2
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        SQLiteConnection d_dbConnection1;
        private SQLiteConnection sqlite_conn1;
        private SQLiteDataAdapter sqlite_dataadapter1;
        private DataTable dataTableGoal;
        string closedate = "";
        double moe =0;
        private void ClosedData()
        {
            string sql = "SELECT MIN(date) from tbl_goal";
            SQLiteCommand command = new SQLiteCommand(sql,d_dbConnection1);
            var dateva = command.ExecuteScalar();
            sql = "SELECT buythings FROM tbl_goal WHERE date = (SELECT MIN(date) FROM tbl_goal)";
            SQLiteCommand command2 = new SQLiteCommand(sql, d_dbConnection1);
            var buythva= command2.ExecuteScalar();
            sql = "SELECT moneyspend FROM tbl_goal WHERE date = (SELECT MIN(date) FROM tbl_goal)";
            SQLiteCommand command3 = new SQLiteCommand(sql, d_dbConnection1);
            var moneyspva= command3.ExecuteScalar();
            sql = "select sum(moneyexpend) from tbl_money";
            SQLiteCommand command4 = new SQLiteCommand( sql, d_dbConnection1);
            var moneynowva= command4.ExecuteScalar();
            moe=Convert.ToDouble(moneyspva)-Convert.ToDouble(moneynowva);
            if (moe > 0)
            {
                closedate = "Now you save $" + moneynowva.ToString() + ", you need to save $" + moe.ToString() + " to buy a " + buythva.ToString() + " before " + dateva.ToString();
            }
            else
            {
                closedate = "Now you save $" + moneynowva.ToString() + " you can buy "+buythva.ToString()+" now";
            }
        }
        private void LoadData()
        {
            string query = "SELECT * FROM tbl_goal";
            sqlite_dataadapter1 = new SQLiteDataAdapter(query, d_dbConnection1);
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(sqlite_dataadapter1);
            sqlite_dataadapter1.InsertCommand = new SQLiteCommand("INSERT INTO tbl_goal (tag, moneyspend, buythings, date) VALUES (@tag, @moneyspend, @buythings, @date)", d_dbConnection1);
            sqlite_dataadapter1.InsertCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));
            sqlite_dataadapter1.InsertCommand.Parameters.Add(new SQLiteParameter("@moneyspend", DbType.Double, 0, "moneyspend"));
            sqlite_dataadapter1.InsertCommand.Parameters.Add(new SQLiteParameter("@buythings", DbType.String, 64, "buythings"));
            sqlite_dataadapter1.InsertCommand.Parameters.Add(new SQLiteParameter("@date", DbType.Date, 0, "date"));
            sqlite_dataadapter1.UpdateCommand = new SQLiteCommand("UPDATE tbl_goal SET moneyspend = @moneyspend, buythings = @buythings, date = @date WHERE tag = @tag", d_dbConnection1);
            sqlite_dataadapter1.UpdateCommand.Parameters.Add(new SQLiteParameter("@moneyspend", DbType.Double, 0, "moneyspend"));
            sqlite_dataadapter1.UpdateCommand.Parameters.Add(new SQLiteParameter("@buythings", DbType.String, 64, "buythings"));
            sqlite_dataadapter1.UpdateCommand.Parameters.Add(new SQLiteParameter("@date", DbType.Date, 0, "date"));
            sqlite_dataadapter1.UpdateCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));
            sqlite_dataadapter1.DeleteCommand = new SQLiteCommand("DELETE FROM tbl_goal WHERE tag = @tag", d_dbConnection1);
            sqlite_dataadapter1.DeleteCommand.Parameters.Add(new SQLiteParameter("@tag", DbType.String, 64, "tag"));
            dataTableGoal = new DataTable();
            sqlite_dataadapter1.Fill(dataTableGoal);
            dataGridView1.DataSource = dataTableGoal;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string timetag = "";
        double moneyspend = 0;
        private void timess()
        {
            DateTime moment = DateTime.Now;
            Random rnd = new Random();
            timetag = moment.Year.ToString() + moment.Month.ToString() + moment.Day.ToString() + moment.Hour.ToString() + moment.Minute.ToString() + moment.Second.ToString() + moment.Millisecond.ToString() + rnd.Next(1000, 9999).ToString();
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            d_dbConnection1 = new SQLiteConnection("Data Source=stest.db;Version=3;");
            d_dbConnection1.Open();
            string sql = "create table  if not exists tbl_goal (tag text(64) PRIMARY KEY, moneyspend real, buythings text(64), date DATE)";
            SQLiteCommand command = new SQLiteCommand(sql, d_dbConnection1);
            command.ExecuteNonQuery();
            LoadData();
            ClosedData();
            textBox3.Text=closedate;
        }
        string buthi = "";
        private void button1_Click(object sender, EventArgs e)
        {
            buthi = textBox2.Text;
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if (textBox1.Text != "") moneyspend = Convert.ToDouble(textBox1.Text);
            timess();
            string sql = "INSERT INTO tbl_goal (tag, moneyspend, buythings, date) VALUES (@tag, @moneyspend, @buythings, @date)";
            using (var command = new SQLiteCommand(sql, d_dbConnection1))
            {
                command.Parameters.AddWithValue("@tag", timetag);
                command.Parameters.AddWithValue("@moneyspend", moneyspend);
                command.Parameters.AddWithValue("@buythings", buthi);
                command.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
            LoadData();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
        }
        private void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataTableGoal.Rows.Count)
            {
                dataTableGoal.Rows[rowIndex].Delete();

            }
        }
        private void SaveData()
        {
            try
            {
                sqlite_dataadapter1.Update(dataTableGoal);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
            ClosedData();
            textBox3.Text = closedate;

        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i <= dataGridView1.SelectedRows.Count - 1; i++)

                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    (dataGridView1.DataSource as DataTable).Rows[rowIndex].Delete();
                    //dataTable1.Rows[rowIndex].Delete();
                    //DeleteRow(rowIndex);
                }
                /*for (int i = dataGridView1.SelectedRows.Count-1; i>=0 ; i--)
                {
                    int rowIndex = dataGridView1.SelectedRows[i].Index;
                    DeleteRow(rowIndex);
                }
                SaveData();
                //LoadData();
            }
        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    int rowIndex = dataGridView1.SelectedRows[i].Index;
                    (dataGridView1.DataSource as DataTable).Rows[rowIndex].Delete();
                }
                SaveData();
            }
        }
    }
}
