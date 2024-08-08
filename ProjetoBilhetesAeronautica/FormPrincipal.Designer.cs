namespace ProjetoBilhetesAeronautica
{
    partial class FormPrincipal
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
            label1 = new Label();
            label2 = new Label();
            BtnCreditos = new Button();
            BtnLoginColaborador = new Button();
            label3 = new Label();
            TextBoxUtilizador = new TextBox();
            label4 = new Label();
            TextBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(70, 60, 161);
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(941, 70);
            label1.TabIndex = 0;
            label1.Text = "Aeronáutica NunoSalg";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(70, 60, 161);
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 454);
            label2.Name = "label2";
            label2.Size = new Size(941, 52);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnCreditos
            // 
            BtnCreditos.BackColor = Color.FromArgb(70, 60, 161);
            BtnCreditos.BackgroundImage = Properties.Resources.about;
            BtnCreditos.BackgroundImageLayout = ImageLayout.Center;
            BtnCreditos.Cursor = Cursors.Hand;
            BtnCreditos.FlatAppearance.BorderSize = 0;
            BtnCreditos.FlatStyle = FlatStyle.Flat;
            BtnCreditos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreditos.ForeColor = Color.White;
            BtnCreditos.Location = new Point(864, 454);
            BtnCreditos.Name = "BtnCreditos";
            BtnCreditos.Size = new Size(76, 52);
            BtnCreditos.TabIndex = 0;
            BtnCreditos.UseVisualStyleBackColor = false;
            BtnCreditos.Click += BtnCreditos_Click;
            // 
            // BtnLoginColaborador
            // 
            BtnLoginColaborador.BackColor = Color.FromArgb(70, 60, 161);
            BtnLoginColaborador.Cursor = Cursors.Hand;
            BtnLoginColaborador.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLoginColaborador.ForeColor = Color.White;
            BtnLoginColaborador.Location = new Point(361, 312);
            BtnLoginColaborador.Name = "BtnLoginColaborador";
            BtnLoginColaborador.Size = new Size(98, 41);
            BtnLoginColaborador.TabIndex = 3;
            BtnLoginColaborador.Text = "Login";
            BtnLoginColaborador.UseVisualStyleBackColor = false;
            BtnLoginColaborador.Click += BtnLoginColaborador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 60, 161);
            label3.Location = new Point(361, 193);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 0;
            label3.Text = "Utilizador:";
            // 
            // TextBoxUtilizador
            // 
            TextBoxUtilizador.Location = new Point(361, 223);
            TextBoxUtilizador.Name = "TextBoxUtilizador";
            TextBoxUtilizador.Size = new Size(210, 27);
            TextBoxUtilizador.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(70, 60, 161);
            label4.Location = new Point(361, 253);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(361, 279);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(210, 27);
            TextBoxPassword.TabIndex = 2;
            TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 504);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUtilizador);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnLoginColaborador);
            Controls.Add(BtnCreditos);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnCreditos;
        private Button BtnLoginColaborador;
        private Label label3;
        private TextBox TextBoxUtilizador;
        private Label label4;
        private TextBox TextBoxPassword;
    }
}
