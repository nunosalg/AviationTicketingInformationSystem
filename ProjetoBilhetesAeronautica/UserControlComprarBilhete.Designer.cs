namespace ProjetoBilhetesAeronautica
{
    partial class UserControlComprarBilhete
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
            label1 = new Label();
            TextBoxNome = new TextBox();
            TextBoxApelido = new TextBox();
            DateTimePickerDataNascimento = new DateTimePicker();
            TextBoxNumeroID = new TextBox();
            label2 = new Label();
            BtnPassageiro = new Button();
            LblInfoCompra = new Label();
            BtnComprarBilhete = new Button();
            ListBoxListaBilhetes = new ListBox();
            BtnRemoverBilhete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Dados do passageiro:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(51, 63);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.PlaceholderText = "Nome...";
            TextBoxNome.Size = new Size(194, 27);
            TextBoxNome.TabIndex = 1;
            // 
            // TextBoxApelido
            // 
            TextBoxApelido.Location = new Point(51, 106);
            TextBoxApelido.Name = "TextBoxApelido";
            TextBoxApelido.PlaceholderText = "Apelido...";
            TextBoxApelido.Size = new Size(194, 27);
            TextBoxApelido.TabIndex = 2;
            // 
            // DateTimePickerDataNascimento
            // 
            DateTimePickerDataNascimento.Location = new Point(51, 223);
            DateTimePickerDataNascimento.MaxDate = new DateTime(2024, 6, 21, 0, 0, 0, 0);
            DateTimePickerDataNascimento.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            DateTimePickerDataNascimento.Name = "DateTimePickerDataNascimento";
            DateTimePickerDataNascimento.Size = new Size(193, 27);
            DateTimePickerDataNascimento.TabIndex = 4;
            DateTimePickerDataNascimento.Value = new DateTime(2024, 6, 21, 0, 0, 0, 0);
            // 
            // TextBoxNumeroID
            // 
            TextBoxNumeroID.Location = new Point(50, 154);
            TextBoxNumeroID.Name = "TextBoxNumeroID";
            TextBoxNumeroID.PlaceholderText = "Número de identificação...";
            TextBoxNumeroID.Size = new Size(194, 27);
            TextBoxNumeroID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 200);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 0;
            label2.Text = "Data de nascimento:";
            // 
            // BtnPassageiro
            // 
            BtnPassageiro.BackColor = Color.FromArgb(70, 60, 161);
            BtnPassageiro.Cursor = Cursors.Hand;
            BtnPassageiro.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPassageiro.ForeColor = Color.White;
            BtnPassageiro.Location = new Point(49, 312);
            BtnPassageiro.Name = "BtnPassageiro";
            BtnPassageiro.Size = new Size(195, 63);
            BtnPassageiro.TabIndex = 27;
            BtnPassageiro.Text = "Adicionar passageiro";
            BtnPassageiro.UseVisualStyleBackColor = false;
            BtnPassageiro.Click += BtnPassageiro_Click;
            // 
            // LblInfoCompra
            // 
            LblInfoCompra.BorderStyle = BorderStyle.FixedSingle;
            LblInfoCompra.Location = new Point(302, 39);
            LblInfoCompra.Name = "LblInfoCompra";
            LblInfoCompra.Size = new Size(266, 245);
            LblInfoCompra.TabIndex = 0;
            // 
            // BtnComprarBilhete
            // 
            BtnComprarBilhete.BackColor = Color.FromArgb(70, 60, 161);
            BtnComprarBilhete.Cursor = Cursors.Hand;
            BtnComprarBilhete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComprarBilhete.ForeColor = Color.White;
            BtnComprarBilhete.Location = new Point(373, 312);
            BtnComprarBilhete.Name = "BtnComprarBilhete";
            BtnComprarBilhete.Size = new Size(195, 63);
            BtnComprarBilhete.TabIndex = 27;
            BtnComprarBilhete.Text = "Comprar bilhete";
            BtnComprarBilhete.UseVisualStyleBackColor = false;
            BtnComprarBilhete.Click += BtnComprarBilhete_Click;
            // 
            // ListBoxListaBilhetes
            // 
            ListBoxListaBilhetes.FormattingEnabled = true;
            ListBoxListaBilhetes.Location = new Point(653, 40);
            ListBoxListaBilhetes.Name = "ListBoxListaBilhetes";
            ListBoxListaBilhetes.Size = new Size(305, 244);
            ListBoxListaBilhetes.TabIndex = 28;
            // 
            // BtnRemoverBilhete
            // 
            BtnRemoverBilhete.BackColor = Color.FromArgb(70, 60, 161);
            BtnRemoverBilhete.Cursor = Cursors.Hand;
            BtnRemoverBilhete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemoverBilhete.ForeColor = Color.White;
            BtnRemoverBilhete.Location = new Point(763, 312);
            BtnRemoverBilhete.Name = "BtnRemoverBilhete";
            BtnRemoverBilhete.Size = new Size(195, 63);
            BtnRemoverBilhete.TabIndex = 27;
            BtnRemoverBilhete.Text = "Remover bilhete";
            BtnRemoverBilhete.UseVisualStyleBackColor = false;
            BtnRemoverBilhete.Click += BtnRemoverBilhete_Click;
            // 
            // UserControlComprarBilhete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListBoxListaBilhetes);
            Controls.Add(BtnRemoverBilhete);
            Controls.Add(BtnComprarBilhete);
            Controls.Add(BtnPassageiro);
            Controls.Add(TextBoxNumeroID);
            Controls.Add(DateTimePickerDataNascimento);
            Controls.Add(TextBoxApelido);
            Controls.Add(TextBoxNome);
            Controls.Add(label2);
            Controls.Add(LblInfoCompra);
            Controls.Add(label1);
            Name = "UserControlComprarBilhete";
            Size = new Size(1023, 550);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxNome;
        private TextBox TextBoxApelido;
        private DateTimePicker DateTimePickerDataNascimento;
        private TextBox TextBoxNumeroID;
        private Label label2;
        private Button BtnPassageiro;
        private Label LblInfoCompra;
        private Button BtnComprarBilhete;
        private ListBox ListBoxListaBilhetes;
        private Button BtnRemoverBilhete;
    }
}
