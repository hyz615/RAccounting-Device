namespace WinFormsApp2
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "goalsetting";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 35);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 3;
            label2.Text = "save";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 81);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 4;
            label3.Text = "before";
            // 
            // button1
            // 
            button1.Location = new Point(18, 458);
            button1.Name = "button1";
            button1.Size = new Size(422, 94);
            button1.TabIndex = 5;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 35);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 392);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 7;
            label4.Text = "to buy";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(85, 87);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(420, 509);
            dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(759, 558);
            button2.Name = "button2";
            button2.Size = new Size(131, 71);
            button2.TabIndex = 10;
            button2.Text = "saveedit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(607, 558);
            button3.Name = "button3";
            button3.Size = new Size(146, 71);
            button3.TabIndex = 11;
            button3.Text = "refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(470, 558);
            button4.Name = "button4";
            button4.Size = new Size(131, 71);
            button4.TabIndex = 12;
            button4.Text = "deleterow";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 575);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(422, 35);
            textBox3.TabIndex = 13;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserControl2";
            Size = new Size(943, 651);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
    }
}
