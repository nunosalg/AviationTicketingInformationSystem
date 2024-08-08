namespace ProjetoBilhetesAeronautica
{
    partial class UserControlAparelhos
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
            TextBoxCriarDescricao = new TextBox();
            TextBoxCriarCompanhiaAerea = new TextBox();
            NumUpDownCriarCapacidade = new NumericUpDown();
            label2 = new Label();
            BtnCriarAparelho = new Button();
            ListBoxAparelhos = new ListBox();
            ListBoxLugares = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TextBoxEditarDescricao = new TextBox();
            TextBoxEditarCompanhiaAerea = new TextBox();
            label6 = new Label();
            NumUpDownEditarCapacidade = new NumericUpDown();
            label7 = new Label();
            RadioButtonAtivo = new RadioButton();
            RadioButtonInativo = new RadioButton();
            BtnEditar = new Button();
            label9 = new Label();
            LblInfoAparelho = new Label();
            label11 = new Label();
            BtnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarCapacidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Criar aparelho:";
            // 
            // TextBoxCriarDescricao
            // 
            TextBoxCriarDescricao.Location = new Point(51, 74);
            TextBoxCriarDescricao.Name = "TextBoxCriarDescricao";
            TextBoxCriarDescricao.PlaceholderText = "Descrição...";
            TextBoxCriarDescricao.Size = new Size(125, 27);
            TextBoxCriarDescricao.TabIndex = 1;
            // 
            // TextBoxCriarCompanhiaAerea
            // 
            TextBoxCriarCompanhiaAerea.Location = new Point(51, 121);
            TextBoxCriarCompanhiaAerea.Name = "TextBoxCriarCompanhiaAerea";
            TextBoxCriarCompanhiaAerea.PlaceholderText = "Companhia aérea...";
            TextBoxCriarCompanhiaAerea.Size = new Size(125, 27);
            TextBoxCriarCompanhiaAerea.TabIndex = 2;
            // 
            // NumUpDownCriarCapacidade
            // 
            NumUpDownCriarCapacidade.Location = new Point(50, 193);
            NumUpDownCriarCapacidade.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            NumUpDownCriarCapacidade.Name = "NumUpDownCriarCapacidade";
            NumUpDownCriarCapacidade.Size = new Size(126, 27);
            NumUpDownCriarCapacidade.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 170);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Capacidade:";
            // 
            // BtnCriarAparelho
            // 
            BtnCriarAparelho.BackColor = Color.FromArgb(70, 60, 161);
            BtnCriarAparelho.Cursor = Cursors.Hand;
            BtnCriarAparelho.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCriarAparelho.ForeColor = Color.White;
            BtnCriarAparelho.Location = new Point(50, 253);
            BtnCriarAparelho.Name = "BtnCriarAparelho";
            BtnCriarAparelho.Size = new Size(126, 35);
            BtnCriarAparelho.TabIndex = 4;
            BtnCriarAparelho.Text = "Criar";
            BtnCriarAparelho.UseVisualStyleBackColor = false;
            BtnCriarAparelho.Click += BtnCriarAparelho_Click;
            // 
            // ListBoxAparelhos
            // 
            ListBoxAparelhos.FormattingEnabled = true;
            ListBoxAparelhos.Location = new Point(220, 63);
            ListBoxAparelhos.Name = "ListBoxAparelhos";
            ListBoxAparelhos.Size = new Size(194, 444);
            ListBoxAparelhos.TabIndex = 5;
            ListBoxAparelhos.SelectedIndexChanged += ListBoxAparelhos_SelectedIndexChanged;
            // 
            // ListBoxLugares
            // 
            ListBoxLugares.FormattingEnabled = true;
            ListBoxLugares.Location = new Point(431, 64);
            ListBoxLugares.Name = "ListBoxLugares";
            ListBoxLugares.Size = new Size(67, 444);
            ListBoxLugares.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 40);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 0;
            label3.Text = "Lista de aparelhos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 40);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Lugares:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(548, 40);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 0;
            label5.Text = "Editar aparelho:";
            // 
            // TextBoxEditarDescricao
            // 
            TextBoxEditarDescricao.Location = new Point(548, 74);
            TextBoxEditarDescricao.Name = "TextBoxEditarDescricao";
            TextBoxEditarDescricao.PlaceholderText = "Descrição...";
            TextBoxEditarDescricao.Size = new Size(125, 27);
            TextBoxEditarDescricao.TabIndex = 7;
            // 
            // TextBoxEditarCompanhiaAerea
            // 
            TextBoxEditarCompanhiaAerea.Location = new Point(548, 121);
            TextBoxEditarCompanhiaAerea.Name = "TextBoxEditarCompanhiaAerea";
            TextBoxEditarCompanhiaAerea.PlaceholderText = "Companhia aérea...";
            TextBoxEditarCompanhiaAerea.Size = new Size(125, 27);
            TextBoxEditarCompanhiaAerea.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(548, 170);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 0;
            label6.Text = "Capacidade:";
            // 
            // NumUpDownEditarCapacidade
            // 
            NumUpDownEditarCapacidade.Location = new Point(547, 193);
            NumUpDownEditarCapacidade.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            NumUpDownEditarCapacidade.Name = "NumUpDownEditarCapacidade";
            NumUpDownEditarCapacidade.Size = new Size(126, 27);
            NumUpDownEditarCapacidade.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 243);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Estado:";
            // 
            // RadioButtonAtivo
            // 
            RadioButtonAtivo.AutoSize = true;
            RadioButtonAtivo.Location = new Point(550, 272);
            RadioButtonAtivo.Name = "RadioButtonAtivo";
            RadioButtonAtivo.Size = new Size(65, 24);
            RadioButtonAtivo.TabIndex = 0;
            RadioButtonAtivo.TabStop = true;
            RadioButtonAtivo.Text = "Ativo";
            RadioButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInativo
            // 
            RadioButtonInativo.AutoSize = true;
            RadioButtonInativo.Location = new Point(549, 300);
            RadioButtonInativo.Name = "RadioButtonInativo";
            RadioButtonInativo.Size = new Size(75, 24);
            RadioButtonInativo.TabIndex = 0;
            RadioButtonInativo.TabStop = true;
            RadioButtonInativo.Text = "Inativo";
            RadioButtonInativo.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(70, 60, 161);
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(548, 350);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(126, 35);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(548, 40);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 0;
            label9.Text = "Editar aparelho:";
            // 
            // LblInfoAparelho
            // 
            LblInfoAparelho.BorderStyle = BorderStyle.FixedSingle;
            LblInfoAparelho.Location = new Point(708, 63);
            LblInfoAparelho.Name = "LblInfoAparelho";
            LblInfoAparelho.Size = new Size(265, 443);
            LblInfoAparelho.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(708, 40);
            label11.Name = "label11";
            label11.Size = new Size(151, 20);
            label11.TabIndex = 0;
            label11.Text = "Informação aparelho:";
            // 
            // BtnRemover
            // 
            BtnRemover.BackColor = Color.FromArgb(70, 60, 161);
            BtnRemover.Cursor = Cursors.Hand;
            BtnRemover.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemover.ForeColor = Color.White;
            BtnRemover.Location = new Point(548, 472);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(126, 35);
            BtnRemover.TabIndex = 11;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = false;
            BtnRemover.Click += BtnRemover_Click;
            // 
            // UserControlAparelhos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblInfoAparelho);
            Controls.Add(RadioButtonInativo);
            Controls.Add(RadioButtonAtivo);
            Controls.Add(ListBoxLugares);
            Controls.Add(ListBoxAparelhos);
            Controls.Add(BtnEditar);
            Controls.Add(BtnRemover);
            Controls.Add(BtnCriarAparelho);
            Controls.Add(NumUpDownEditarCapacidade);
            Controls.Add(NumUpDownCriarCapacidade);
            Controls.Add(TextBoxEditarCompanhiaAerea);
            Controls.Add(TextBoxCriarCompanhiaAerea);
            Controls.Add(TextBoxEditarDescricao);
            Controls.Add(TextBoxCriarDescricao);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UserControlAparelhos";
            Size = new Size(1023, 550);
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarCapacidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxCriarDescricao;
        private TextBox TextBoxCriarCompanhiaAerea;
        private NumericUpDown NumUpDownCriarCapacidade;
        private Label label2;
        private Button BtnCriarAparelho;
        private ListBox ListBoxAparelhos;
        private ListBox ListBoxLugares;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBoxEditarDescricao;
        private TextBox TextBoxEditarCompanhiaAerea;
        private Label label6;
        private NumericUpDown NumUpDownEditarCapacidade;
        private Label label7;
        private RadioButton RadioButtonAtivo;
        private RadioButton RadioButtonInativo;
        private Button BtnEditar;
        private Label label9;
        private Label LblInfoAparelho;
        private Label label11;
        private Button BtnRemover;
    }
}
