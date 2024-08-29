namespace WinFormsApp2
{
    partial class UserControl3
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(775, 645);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(781, 3);
            button1.Name = "button1";
            button1.Size = new Size(159, 149);
            button1.TabIndex = 1;
            button1.Text = "saveedit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(781, 170);
            button2.Name = "button2";
            button2.Size = new Size(153, 156);
            button2.TabIndex = 2;
            button2.Text = "confirmdelete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(781, 343);
            button3.Name = "button3";
            button3.Size = new Size(159, 144);
            button3.TabIndex = 3;
            button3.Text = "refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserControl3";
            Size = new Size(943, 651);
            Load += UserControl3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}
