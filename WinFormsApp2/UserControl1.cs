using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        SQLiteConnection d_dbConnection;
        double moneyincome = 0;
        double moneyexpend = 0;
        int timeye = 0;
        string timetag = "";
        string nowdate = "";
        int gzt = 0;
        string swaap = "";
        private void timess()
        {
            DateTime moment = DateTime.Now;
            Random rnd = new Random();
            timetag = moment.Year.ToString() + moment.Month.ToString() + moment.Day.ToString() + moment.Hour.ToString() + moment.Minute.ToString() + moment.Second.ToString() + moment.Millisecond.ToString() + rnd.Next(1000, 9999).ToString();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            d_dbConnection = new SQLiteConnection("Data Source=stest.db;Version=3;");
            d_dbConnection.Open();
            string sql = "create table  if not exists tbl_money (tag text(64) PRIMARY KEY, moneyexpend real, date DATE)";
            SQLiteCommand command = new SQLiteCommand(sql, d_dbConnection);
            command.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") moneyexpend = Convert.ToDouble(textBox2.Text);
            moneyexpend = moneyexpend * -1;
            timess();
            string sql = "INSERT INTO tbl_money (tag,moneyexpend,date) VALUES ('" + timetag + "'," + moneyexpend +",@date)";
            using (var command = new SQLiteCommand(sql, d_dbConnection))
            {
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
            moneyexpend = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "") moneyincome = Convert.ToDouble(textBox3.Text);
            timess();
            string sql = "INSERT INTO tbl_money (tag,moneyexpend,date) VALUES ('" + timetag + "'," + moneyincome + ",@date)";
            using (var command = new SQLiteCommand(sql, d_dbConnection))
            {
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
            moneyincome = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "") moneyexpend = Convert.ToDouble(textBox4.Text);
            if (textBox5.Text != "") moneyincome = Convert.ToDouble(textBox5.Text);
            timess();
            DateTime selectedDate = monthCalendar1.SelectionStart;
            moneyincome = moneyincome - moneyexpend;
            string sql = "INSERT INTO tbl_money (tag,moneyexpend,date) VALUES ('" + timetag + "'," + moneyincome + ",@date)";
            using (var command = new SQLiteCommand(sql, d_dbConnection))
            {
                command.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
            moneyexpend = 0;
            moneyincome = 0;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select sum(moneyexpend) from tbl_money";
            SQLiteCommand command = new SQLiteCommand(sql, d_dbConnection);
            var result = command.ExecuteScalar();
            textBox6.Text = result.ToString();
        }
    }
}