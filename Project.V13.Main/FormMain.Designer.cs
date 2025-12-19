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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            buttonRes_EKP = new Button();
            textBoxDano_EKP = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonDs_EKP = new Button();
            groupBox3 = new GroupBox();
            buttonS_EKP = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonRes_EKP);
            groupBox1.Controls.Add(textBoxDano_EKP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 463);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дано:";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(6, 392);
            button2.Name = "button2";
            button2.Size = new Size(65, 65);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(163, 428);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonRes_EKP
            // 
            buttonRes_EKP.Location = new Point(163, 393);
            buttonRes_EKP.Name = "buttonRes_EKP";
            buttonRes_EKP.Size = new Size(111, 29);
            buttonRes_EKP.TabIndex = 1;
            buttonRes_EKP.Text = "Выполнить";
            buttonRes_EKP.UseVisualStyleBackColor = true;
            buttonRes_EKP.Click += buttonRes_EKP_Click;
            // 
            // textBoxDano_EKP
            // 
            textBoxDano_EKP.Location = new Point(6, 26);
            textBoxDano_EKP.Multiline = true;
            textBoxDano_EKP.Name = "textBoxDano_EKP";
            textBoxDano_EKP.ReadOnly = true;
            textBoxDano_EKP.Size = new Size(268, 148);
            textBoxDano_EKP.TabIndex = 0;
            textBoxDano_EKP.Text = resources.GetString("textBoxDano_EKP.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(299, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 463);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Страны";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonDs_EKP);
            groupBox4.Location = new Point(330, 347);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(412, 110);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Аналитика";
            // 
            // buttonDs_EKP
            // 
            buttonDs_EKP.Location = new Point(6, 24);
            buttonDs_EKP.Name = "buttonDs_EKP";
            buttonDs_EKP.Size = new Size(80, 80);
            buttonDs_EKP.TabIndex = 0;
            buttonDs_EKP.Text = "button4";
            buttonDs_EKP.UseVisualStyleBackColor = true;
            buttonDs_EKP.Click += buttonDs_EKP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonS_EKP);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(6, 347);
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
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(736, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 487);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "MainStr (ГЕОГРАФИЯ)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxDano_EKP;
        private Button button1;
        private Button buttonRes_EKP;
        private Button button2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button buttonS_EKP;
        private Button button3;
        private GroupBox groupBox4;
        private Button buttonDs_EKP;
    }
}
