namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5714283F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2467537F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7532463F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1158, 659);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Location = new Point(992, 3);
            button1.Name = "button1";
            button1.Size = new Size(160, 228);
            button1.TabIndex = 1;
            button1.Text = "Statistics";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Location = new Point(992, 237);
            button2.Name = "button2";
            button2.Size = new Size(160, 199);
            button2.TabIndex = 2;
            button2.Text = "Goal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Location = new Point(992, 442);
            button3.Name = "button3";
            button3.Size = new Size(160, 214);
            button3.TabIndex = 3;
            button3.Text = "dataedit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 3);
            panel1.Size = new Size(983, 653);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1158, 659);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Accounting Device";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
    }
}
