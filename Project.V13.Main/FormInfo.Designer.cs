namespace Project.V13.Main
{
    partial class FormInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            groupBox1 = new GroupBox();
            buttonClousInfo = new Button();
            pictureBox1 = new PictureBox();
            textBoxInfo = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(buttonClousInfo);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBoxInfo);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            // 
            // buttonClousInfo
            // 
            buttonClousInfo.Location = new Point(241, 375);
            buttonClousInfo.Name = "buttonClousInfo";
            buttonClousInfo.Size = new Size(94, 29);
            buttonClousInfo.TabIndex = 1;
            buttonClousInfo.Text = "Закрыть";
            buttonClousInfo.UseVisualStyleBackColor = true;
            buttonClousInfo.Click += buttonClousInfo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 170);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(6, 26);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(341, 394);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = "Данная программа выполнена:\r\nЕвдокимовым Кириллом Петровичем \r\nГруппа: ПКТб-25-1\r\nПредметная область - география\r\nРабота выполнена для получения 40 баллов \r\nпо предмету \"программирование\" :)\r\n";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(groupBox1);
            Name = "FormInfo";
            Text = "FormInfo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBoxInfo;
        private Button buttonClousInfo;
    }
}