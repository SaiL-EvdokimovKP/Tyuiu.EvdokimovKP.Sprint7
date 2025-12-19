namespace Project.V13.Main
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox4 = new GroupBox();
            buttonS_Analitic_EKP = new Button();
            buttonDs_EKP = new Button();
            groupBox3 = new GroupBox();
            buttonS_EKP = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            textBoxSearch_EKP = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxDano_EKP = new TextBox();
            buttonRes_EKP = new Button();
            button2 = new Button();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonS_Analitic_EKP);
            groupBox4.Controls.Add(buttonDs_EKP);
            groupBox4.Location = new Point(633, 407);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(412, 110);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Аналитика";
            // 
            // buttonS_Analitic_EKP
            // 
            buttonS_Analitic_EKP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonS_Analitic_EKP.Location = new Point(92, 24);
            buttonS_Analitic_EKP.Name = "buttonS_Analitic_EKP";
            buttonS_Analitic_EKP.Size = new Size(80, 80);
            buttonS_Analitic_EKP.TabIndex = 1;
            buttonS_Analitic_EKP.Text = "Площадь";
            buttonS_Analitic_EKP.UseVisualStyleBackColor = true;
            buttonS_Analitic_EKP.Click += buttonS_Analitic_EKP_Click;
            // 
            // buttonDs_EKP
            // 
            buttonDs_EKP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDs_EKP.Location = new Point(6, 24);
            buttonDs_EKP.Name = "buttonDs_EKP";
            buttonDs_EKP.Size = new Size(80, 80);
            buttonDs_EKP.TabIndex = 0;
            buttonDs_EKP.Text = "Население";
            buttonDs_EKP.UseVisualStyleBackColor = true;
            buttonDs_EKP.Click += buttonDs_EKP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonS_EKP);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(297, 407);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 110);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сведения в диаграммах";
            // 
            // buttonS_EKP
            // 
            buttonS_EKP.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonS_EKP.ForeColor = SystemColors.Window;
            buttonS_EKP.Image = (Image)resources.GetObject("buttonS_EKP.Image");
            buttonS_EKP.Location = new Point(220, 20);
            buttonS_EKP.Name = "buttonS_EKP";
            buttonS_EKP.Size = new Size(80, 80);
            buttonS_EKP.TabIndex = 1;
            buttonS_EKP.Text = "Площадь";
            buttonS_EKP.TextAlign = ContentAlignment.BottomCenter;
            buttonS_EKP.UseVisualStyleBackColor = true;
            buttonS_EKP.Click += buttonS_EKP_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(18, 20);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 0;
            button3.Text = "Население";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxSearch_EKP);
            groupBox5.Location = new Point(297, 25);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(748, 45);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Поиск стран по названию";
            // 
            // textBoxSearch_EKP
            // 
            textBoxSearch_EKP.Location = new Point(0, 19);
            textBoxSearch_EKP.Name = "textBoxSearch_EKP";
            textBoxSearch_EKP.Size = new Size(748, 27);
            textBoxSearch_EKP.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1064, 535);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBoxDano_EKP
            // 
            textBoxDano_EKP.Location = new Point(12, 161);
            textBoxDano_EKP.Multiline = true;
            textBoxDano_EKP.Name = "textBoxDano_EKP";
            textBoxDano_EKP.ReadOnly = true;
            textBoxDano_EKP.Size = new Size(268, 148);
            textBoxDano_EKP.TabIndex = 0;
            textBoxDano_EKP.Text = resources.GetString("textBoxDano_EKP.Text");
            textBoxDano_EKP.TextChanged += textBoxDano_EKP_TextChanged;
            // 
            // buttonRes_EKP
            // 
            buttonRes_EKP.BackColor = Color.Maroon;
            buttonRes_EKP.Location = new Point(149, 448);
            buttonRes_EKP.Name = "buttonRes_EKP";
            buttonRes_EKP.Size = new Size(131, 66);
            buttonRes_EKP.TabIndex = 1;
            buttonRes_EKP.Text = "Выполнить";
            buttonRes_EKP.UseVisualStyleBackColor = false;
            buttonRes_EKP.Click += buttonRes_EKP_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 448);
            button2.Name = "button2";
            button2.Size = new Size(65, 65);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 529);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(textBoxDano_EKP);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(buttonRes_EKP);
            Controls.Add(pictureBox1);
            Name = "FormMain";
            Text = "MainStr (ГЕОГРАФИЯ)";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button buttonS_EKP;
        private Button button3;
        private GroupBox groupBox4;
        private Button buttonDs_EKP;
        private Button buttonS_Analitic_EKP;
        private GroupBox groupBox5;
        private TextBox textBoxSearch_EKP;
        private PictureBox pictureBox1;
        private TextBox textBoxDano_EKP;
        private Button buttonRes_EKP;
        private Button button2;
    }
}
