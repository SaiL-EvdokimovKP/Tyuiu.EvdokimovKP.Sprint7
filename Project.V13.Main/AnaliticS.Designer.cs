namespace Project.V13.Main
{
    partial class AnaliticS
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
            groupBox1 = new GroupBox();
            textBoxS_EKP = new TextBox();
            buttonCloseA_EKP = new Button();
            buttonResSA_EKP = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxS_EKP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Площадь";
            // 
            // textBoxS_EKP
            // 
            textBoxS_EKP.Location = new Point(6, 26);
            textBoxS_EKP.Multiline = true;
            textBoxS_EKP.Name = "textBoxS_EKP";
            textBoxS_EKP.Size = new Size(454, 456);
            textBoxS_EKP.TabIndex = 0;
            // 
            // buttonCloseA_EKP
            // 
            buttonCloseA_EKP.Location = new Point(384, 506);
            buttonCloseA_EKP.Name = "buttonCloseA_EKP";
            buttonCloseA_EKP.Size = new Size(94, 29);
            buttonCloseA_EKP.TabIndex = 1;
            buttonCloseA_EKP.Text = "Закрыть";
            buttonCloseA_EKP.UseVisualStyleBackColor = true;
            buttonCloseA_EKP.Click += buttonCloseA_EKP_Click;
            // 
            // buttonResSA_EKP
            // 
            buttonResSA_EKP.Location = new Point(276, 506);
            buttonResSA_EKP.Name = "buttonResSA_EKP";
            buttonResSA_EKP.Size = new Size(102, 29);
            buttonResSA_EKP.TabIndex = 2;
            buttonResSA_EKP.Text = "Посмотреть";
            buttonResSA_EKP.UseVisualStyleBackColor = true;
            buttonResSA_EKP.Click += buttonResSA_EKP_Click;
            // 
            // AnaliticS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 544);
            Controls.Add(buttonResSA_EKP);
            Controls.Add(buttonCloseA_EKP);
            Controls.Add(groupBox1);
            Name = "AnaliticS";
            Text = "AnaliticS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCloseA_EKP;
        private Button buttonResSA_EKP;
        private TextBox textBoxS_EKP;
    }
}