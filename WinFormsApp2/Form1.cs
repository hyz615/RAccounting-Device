using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double moneyincome = 0;
        double moneyexpend = 0;
        int timesc = 0;
        int timeye = 0;
        System.DateTime moment = DateTime.Now;
        public static UserControl1 w1;
        public static UserControl2 w2;
        public static UserControl3 w3;
        private void timess()
        {
            timesc = moment.Hour * 10000 + moment.Minute * 100 + moment.Second;
            timeye = moment.Year * 10000 + moment.Month * 100 + moment.Day;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            w1 = new UserControl1();
            w2 = new UserControl2();
            w3 = new UserControl3();
            w1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(w1);
        }  

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            w1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(w1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            w2.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(w2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            w3.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(w3);
        }
    }
}
