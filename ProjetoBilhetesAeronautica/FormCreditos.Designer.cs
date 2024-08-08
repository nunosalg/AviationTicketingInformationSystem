namespace ProjetoBilhetesAeronautica
{
    partial class FormCreditos
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
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(132, 113);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 0;
            label2.Text = "Data: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(146, 132);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 0;
            label3.Text = "Versão:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(111, 91);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(187, 19);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Autor: Nuno Salgueiro";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(180, 113);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "30/06/2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(215, 132);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 0;
            label4.Text = "1.0.0";
            // 
            // FormCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 60, 161);
            ClientSize = new Size(409, 282);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creditos";
            FormClosing += FormCreditos_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label4;
    }
}