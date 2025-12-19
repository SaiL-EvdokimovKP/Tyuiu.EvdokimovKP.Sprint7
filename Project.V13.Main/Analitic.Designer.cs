namespace Project.V13.Main
{
    partial class Analitic
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
            textBoxResP_EKP = new TextBox();
            buttonRes_EKP = new Button();
            buttonClose_EKP = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResP_EKP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Население";
            // 
            // textBoxResP_EKP
            // 
            textBoxResP_EKP.Location = new Point(6, 26);
            textBoxResP_EKP.Multiline = true;
            textBoxResP_EKP.Name = "textBoxResP_EKP";
            textBoxResP_EKP.Size = new Size(629, 456);
            textBoxResP_EKP.TabIndex = 0;
            // 
            // buttonRes_EKP
            // 
            buttonRes_EKP.Location = new Point(443, 506);
            buttonRes_EKP.Name = "buttonRes_EKP";
            buttonRes_EKP.Size = new Size(104, 29);
            buttonRes_EKP.TabIndex = 1;
            buttonRes_EKP.Text = "Посмотреть";
            buttonRes_EKP.UseVisualStyleBackColor = true;
            buttonRes_EKP.Click += buttonRes_EKP_Click;
            // 
            // buttonClose_EKP
            // 
            buttonClose_EKP.Location = new Point(553, 506);
            buttonClose_EKP.Name = "buttonClose_EKP";
            buttonClose_EKP.Size = new Size(94, 29);
            buttonClose_EKP.TabIndex = 2;
            buttonClose_EKP.Text = "Закрыть";
            buttonClose_EKP.UseVisualStyleBackColor = true;
            buttonClose_EKP.Click += buttonClose_EKP_Click;
            // 
            // Analitic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 544);
            Controls.Add(buttonClose_EKP);
            Controls.Add(buttonRes_EKP);
            Controls.Add(groupBox1);
            Name = "Analitic";
            Text = "Analitic";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxResP_EKP;
        private Button buttonRes_EKP;
        private Button buttonClose_EKP;
    }
}