namespace ProjetoBilhetesAeronautica
{
    partial class FormColaborador
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnAparelhos = new Button();
            BtnVoos = new Button();
            BtnBilhetes = new Button();
            BtnCreditos = new Button();
            PanelColaborador = new Panel();
            BtnEncerrar = new Button();
            LblUtilizador = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(70, 60, 161);
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(1131, 70);
            label1.TabIndex = 0;
            label1.Text = "Aeronáutica NunoSalg";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(70, 60, 161);
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1, 620);
            label2.Name = "label2";
            label2.Size = new Size(1131, 41);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(70, 60, 161);
            label3.Location = new Point(1, 70);
            label3.Name = "label3";
            label3.Size = new Size(110, 550);
            label3.TabIndex = 3;
            // 
            // BtnAparelhos
            // 
            BtnAparelhos.BackColor = Color.FromArgb(70, 60, 161);
            BtnAparelhos.BackgroundImage = Properties.Resources.aircrafts;
            BtnAparelhos.BackgroundImageLayout = ImageLayout.Center;
            BtnAparelhos.Cursor = Cursors.Hand;
            BtnAparelhos.FlatAppearance.BorderSize = 0;
            BtnAparelhos.FlatStyle = FlatStyle.Flat;
            BtnAparelhos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAparelhos.ForeColor = Color.White;
            BtnAparelhos.Location = new Point(1, 70);
            BtnAparelhos.Name = "BtnAparelhos";
            BtnAparelhos.Size = new Size(110, 102);
            BtnAparelhos.TabIndex = 4;
            BtnAparelhos.UseVisualStyleBackColor = false;
            BtnAparelhos.Click += BtnAparelhos_Click;
            // 
            // BtnVoos
            // 
            BtnVoos.BackColor = Color.FromArgb(70, 60, 161);
            BtnVoos.BackgroundImage = Properties.Resources.flights;
            BtnVoos.BackgroundImageLayout = ImageLayout.Center;
            BtnVoos.Cursor = Cursors.Hand;
            BtnVoos.FlatAppearance.BorderSize = 0;
            BtnVoos.FlatStyle = FlatStyle.Flat;
            BtnVoos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoos.ForeColor = Color.White;
            BtnVoos.Location = new Point(1, 178);
            BtnVoos.Name = "BtnVoos";
            BtnVoos.Size = new Size(108, 102);
            BtnVoos.TabIndex = 4;
            BtnVoos.UseVisualStyleBackColor = false;
            BtnVoos.Click += BtnVoos_Click;
            // 
            // BtnBilhetes
            // 
            BtnBilhetes.BackColor = Color.FromArgb(70, 60, 161);
            BtnBilhetes.BackgroundImage = Properties.Resources.tickets;
            BtnBilhetes.BackgroundImageLayout = ImageLayout.Center;
            BtnBilhetes.Cursor = Cursors.Hand;
            BtnBilhetes.FlatAppearance.BorderSize = 0;
            BtnBilhetes.FlatStyle = FlatStyle.Flat;
            BtnBilhetes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBilhetes.ForeColor = Color.White;
            BtnBilhetes.Location = new Point(1, 267);
            BtnBilhetes.Name = "BtnBilhetes";
            BtnBilhetes.Size = new Size(110, 102);
            BtnBilhetes.TabIndex = 4;
            BtnBilhetes.UseVisualStyleBackColor = false;
            BtnBilhetes.Click += BtnBilhetes_Click;
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
            BtnCreditos.Location = new Point(1, 375);
            BtnCreditos.Name = "BtnCreditos";
            BtnCreditos.Size = new Size(110, 85);
            BtnCreditos.TabIndex = 5;
            BtnCreditos.UseVisualStyleBackColor = false;
            BtnCreditos.Click += BtnCreditos_Click;
            // 
            // PanelColaborador
            // 
            PanelColaborador.Location = new Point(109, 70);
            PanelColaborador.Margin = new Padding(0);
            PanelColaborador.Name = "PanelColaborador";
            PanelColaborador.Size = new Size(1023, 550);
            PanelColaborador.TabIndex = 6;
            // 
            // BtnEncerrar
            // 
            BtnEncerrar.BackColor = Color.White;
            BtnEncerrar.BackgroundImage = Properties.Resources.power_off_button;
            BtnEncerrar.BackgroundImageLayout = ImageLayout.Center;
            BtnEncerrar.Cursor = Cursors.Hand;
            BtnEncerrar.FlatAppearance.BorderSize = 0;
            BtnEncerrar.FlatStyle = FlatStyle.Flat;
            BtnEncerrar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEncerrar.ForeColor = Color.White;
            BtnEncerrar.Location = new Point(1088, 620);
            BtnEncerrar.Name = "BtnEncerrar";
            BtnEncerrar.Size = new Size(44, 41);
            BtnEncerrar.TabIndex = 5;
            BtnEncerrar.UseVisualStyleBackColor = false;
            BtnEncerrar.Click += BtnEncerrar_Click;
            // 
            // LblUtilizador
            // 
            LblUtilizador.Anchor = AnchorStyles.Right;
            LblUtilizador.AutoSize = true;
            LblUtilizador.BackColor = Color.FromArgb(70, 60, 161);
            LblUtilizador.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUtilizador.ForeColor = Color.White;
            LblUtilizador.Location = new Point(1121, 27);
            LblUtilizador.Name = "LblUtilizador";
            LblUtilizador.RightToLeft = RightToLeft.Yes;
            LblUtilizador.Size = new Size(0, 22);
            LblUtilizador.TabIndex = 7;
            LblUtilizador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormColaborador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 661);
            Controls.Add(BtnEncerrar);
            Controls.Add(BtnVoos);
            Controls.Add(LblUtilizador);
            Controls.Add(PanelColaborador);
            Controls.Add(BtnCreditos);
            Controls.Add(BtnBilhetes);
            Controls.Add(BtnAparelhos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += FormColaborador_FormClosing;
            Load += FormColaborador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnAparelhos;
        private Button BtnVoos;
        private Button BtnBilhetes;
        private Button BtnCreditos;
        private Panel PanelColaborador;
        private Button BtnEncerrar;
        private Label LblUtilizador;
    }
}