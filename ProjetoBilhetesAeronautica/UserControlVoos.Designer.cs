namespace ProjetoBilhetesAeronautica
{
    partial class UserControlVoos
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
            BtnRemover = new Button();
            BtnCriar = new Button();
            TextBoxCriarDestino = new TextBox();
            TextBoxCriarOrigem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            NumUpDownCriarDuraMinutos = new NumericUpDown();
            NumUpDownCriarDuraHoras = new NumericUpDown();
            NumUpDownCriarMinutos = new NumericUpDown();
            NumUpDownCriarHora = new NumericUpDown();
            ListBoxAparelhosDisponiveis = new ListBox();
            label4 = new Label();
            label5 = new Label();
            ListBoxVoos = new ListBox();
            LblInfoVoo = new Label();
            label11 = new Label();
            BtnEditar = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TextBoxEditarOrigem = new TextBox();
            TextBoxEditarDestino = new TextBox();
            NumUpDownEditarMinutosVoo = new NumericUpDown();
            NumUpDownEditarMinuto = new NumericUpDown();
            NumUpDownEditarHorasVoo = new NumericUpDown();
            NumUpDownEditarHora = new NumericUpDown();
            DateTimePickerCriarData = new DateTimePicker();
            DateTimePickerEditarData = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarDuraMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarDuraHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarMinutosVoo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarMinuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarHorasVoo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarHora).BeginInit();
            SuspendLayout();
            // 
            // BtnRemover
            // 
            BtnRemover.BackColor = Color.FromArgb(70, 60, 161);
            BtnRemover.Cursor = Cursors.Hand;
            BtnRemover.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemover.ForeColor = Color.White;
            BtnRemover.Location = new Point(608, 470);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(126, 35);
            BtnRemover.TabIndex = 23;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = false;
            BtnRemover.Click += BtnRemover_Click;
            // 
            // BtnCriar
            // 
            BtnCriar.BackColor = Color.FromArgb(70, 60, 161);
            BtnCriar.Cursor = Cursors.Hand;
            BtnCriar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCriar.ForeColor = Color.White;
            BtnCriar.Location = new Point(222, 349);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(126, 35);
            BtnCriar.TabIndex = 11;
            BtnCriar.Text = "Criar";
            BtnCriar.UseVisualStyleBackColor = false;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // TextBoxCriarDestino
            // 
            TextBoxCriarDestino.Location = new Point(223, 114);
            TextBoxCriarDestino.Name = "TextBoxCriarDestino";
            TextBoxCriarDestino.PlaceholderText = "Destino...";
            TextBoxCriarDestino.Size = new Size(189, 27);
            TextBoxCriarDestino.TabIndex = 2;
            // 
            // TextBoxCriarOrigem
            // 
            TextBoxCriarOrigem.Location = new Point(223, 65);
            TextBoxCriarOrigem.Name = "TextBoxCriarOrigem";
            TextBoxCriarOrigem.PlaceholderText = "Origem...";
            TextBoxCriarOrigem.Size = new Size(189, 27);
            TextBoxCriarOrigem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 163);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Data e hora:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Criar voo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 271);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Horas de voo:";
            // 
            // NumUpDownCriarDuraMinutos
            // 
            NumUpDownCriarDuraMinutos.Location = new Point(272, 294);
            NumUpDownCriarDuraMinutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NumUpDownCriarDuraMinutos.Name = "NumUpDownCriarDuraMinutos";
            NumUpDownCriarDuraMinutos.Size = new Size(43, 27);
            NumUpDownCriarDuraMinutos.TabIndex = 9;
            // 
            // NumUpDownCriarDuraHoras
            // 
            NumUpDownCriarDuraHoras.Location = new Point(223, 294);
            NumUpDownCriarDuraHoras.Name = "NumUpDownCriarDuraHoras";
            NumUpDownCriarDuraHoras.Size = new Size(43, 27);
            NumUpDownCriarDuraHoras.TabIndex = 8;
            // 
            // NumUpDownCriarMinutos
            // 
            NumUpDownCriarMinutos.Location = new Point(272, 228);
            NumUpDownCriarMinutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NumUpDownCriarMinutos.Name = "NumUpDownCriarMinutos";
            NumUpDownCriarMinutos.Size = new Size(43, 27);
            NumUpDownCriarMinutos.TabIndex = 7;
            // 
            // NumUpDownCriarHora
            // 
            NumUpDownCriarHora.Location = new Point(223, 228);
            NumUpDownCriarHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            NumUpDownCriarHora.Name = "NumUpDownCriarHora";
            NumUpDownCriarHora.Size = new Size(43, 27);
            NumUpDownCriarHora.TabIndex = 6;
            // 
            // ListBoxAparelhosDisponiveis
            // 
            ListBoxAparelhosDisponiveis.FormattingEnabled = true;
            ListBoxAparelhosDisponiveis.Location = new Point(51, 63);
            ListBoxAparelhosDisponiveis.Name = "ListBoxAparelhosDisponiveis";
            ListBoxAparelhosDisponiveis.Size = new Size(157, 444);
            ListBoxAparelhosDisponiveis.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 40);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 13;
            label4.Text = "Aparelhos disponiveis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 42);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 13;
            label5.Text = "Voos:";
            // 
            // ListBoxVoos
            // 
            ListBoxVoos.FormattingEnabled = true;
            ListBoxVoos.Location = new Point(429, 65);
            ListBoxVoos.Name = "ListBoxVoos";
            ListBoxVoos.Size = new Size(164, 444);
            ListBoxVoos.TabIndex = 12;
            ListBoxVoos.SelectedIndexChanged += ListBoxVoos_SelectedIndexChanged;
            // 
            // LblInfoVoo
            // 
            LblInfoVoo.BorderStyle = BorderStyle.FixedSingle;
            LblInfoVoo.Location = new Point(814, 62);
            LblInfoVoo.Name = "LblInfoVoo";
            LblInfoVoo.Size = new Size(167, 443);
            LblInfoVoo.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(813, 37);
            label11.Name = "label11";
            label11.Size = new Size(139, 20);
            label11.TabIndex = 15;
            label11.Text = "Informação do voo:";
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(70, 60, 161);
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(607, 349);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(126, 35);
            BtnEditar.TabIndex = 22;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 42);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 6;
            label6.Text = "Editar voo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 163);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 5;
            label7.Text = "Data e hora:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 271);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 5;
            label8.Text = "Horas de voo:";
            // 
            // TextBoxEditarOrigem
            // 
            TextBoxEditarOrigem.Location = new Point(608, 67);
            TextBoxEditarOrigem.Name = "TextBoxEditarOrigem";
            TextBoxEditarOrigem.PlaceholderText = "Origem...";
            TextBoxEditarOrigem.Size = new Size(189, 27);
            TextBoxEditarOrigem.TabIndex = 13;
            // 
            // TextBoxEditarDestino
            // 
            TextBoxEditarDestino.Location = new Point(608, 114);
            TextBoxEditarDestino.Name = "TextBoxEditarDestino";
            TextBoxEditarDestino.PlaceholderText = "Destino...";
            TextBoxEditarDestino.Size = new Size(189, 27);
            TextBoxEditarDestino.TabIndex = 14;
            // 
            // NumUpDownEditarMinutosVoo
            // 
            NumUpDownEditarMinutosVoo.Location = new Point(657, 294);
            NumUpDownEditarMinutosVoo.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NumUpDownEditarMinutosVoo.Name = "NumUpDownEditarMinutosVoo";
            NumUpDownEditarMinutosVoo.Size = new Size(43, 27);
            NumUpDownEditarMinutosVoo.TabIndex = 21;
            // 
            // NumUpDownEditarMinuto
            // 
            NumUpDownEditarMinuto.Location = new Point(657, 228);
            NumUpDownEditarMinuto.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NumUpDownEditarMinuto.Name = "NumUpDownEditarMinuto";
            NumUpDownEditarMinuto.Size = new Size(43, 27);
            NumUpDownEditarMinuto.TabIndex = 19;
            // 
            // NumUpDownEditarHorasVoo
            // 
            NumUpDownEditarHorasVoo.Location = new Point(608, 294);
            NumUpDownEditarHorasVoo.Name = "NumUpDownEditarHorasVoo";
            NumUpDownEditarHorasVoo.Size = new Size(43, 27);
            NumUpDownEditarHorasVoo.TabIndex = 20;
            // 
            // NumUpDownEditarHora
            // 
            NumUpDownEditarHora.Location = new Point(608, 228);
            NumUpDownEditarHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            NumUpDownEditarHora.Name = "NumUpDownEditarHora";
            NumUpDownEditarHora.Size = new Size(43, 27);
            NumUpDownEditarHora.TabIndex = 18;
            // 
            // DateTimePickerCriarData
            // 
            DateTimePickerCriarData.Location = new Point(222, 186);
            DateTimePickerCriarData.MinDate = new DateTime(2024, 6, 21, 0, 0, 0, 0);
            DateTimePickerCriarData.Name = "DateTimePickerCriarData";
            DateTimePickerCriarData.Size = new Size(190, 27);
            DateTimePickerCriarData.TabIndex = 24;
            // 
            // DateTimePickerEditarData
            // 
            DateTimePickerEditarData.Location = new Point(607, 186);
            DateTimePickerEditarData.MinDate = new DateTime(2024, 6, 17, 0, 0, 0, 0);
            DateTimePickerEditarData.Name = "DateTimePickerEditarData";
            DateTimePickerEditarData.Size = new Size(190, 27);
            DateTimePickerEditarData.TabIndex = 24;
            // 
            // UserControlVoos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateTimePickerEditarData);
            Controls.Add(DateTimePickerCriarData);
            Controls.Add(BtnEditar);
            Controls.Add(LblInfoVoo);
            Controls.Add(label11);
            Controls.Add(ListBoxVoos);
            Controls.Add(label5);
            Controls.Add(ListBoxAparelhosDisponiveis);
            Controls.Add(label4);
            Controls.Add(NumUpDownEditarHora);
            Controls.Add(NumUpDownCriarHora);
            Controls.Add(NumUpDownEditarHorasVoo);
            Controls.Add(NumUpDownCriarDuraHoras);
            Controls.Add(BtnRemover);
            Controls.Add(NumUpDownEditarMinuto);
            Controls.Add(NumUpDownCriarMinutos);
            Controls.Add(BtnCriar);
            Controls.Add(NumUpDownEditarMinutosVoo);
            Controls.Add(NumUpDownCriarDuraMinutos);
            Controls.Add(TextBoxEditarDestino);
            Controls.Add(TextBoxCriarDestino);
            Controls.Add(TextBoxEditarOrigem);
            Controls.Add(TextBoxCriarOrigem);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "UserControlVoos";
            Size = new Size(1023, 550);
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarDuraMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarDuraHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownCriarHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarMinutosVoo).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarMinuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarHorasVoo).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUpDownEditarHora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRemover;
        private Button BtnCriar;
        private NumericUpDown NumUpDownCriarAno;
        private TextBox TextBoxCriarDestino;
        private TextBox TextBoxCriarOrigem;
        private Label label2;
        private Label label1;
        private NumericUpDown NumUpDownCriarMes;
        private NumericUpDown NumUpDownCriarDia;
        private Label label3;
        private NumericUpDown NumUpDownCriarDuraMinutos;
        private NumericUpDown NumUpDownCriarDuraHoras;
        private NumericUpDown NumUpDownCriarMinutos;
        private NumericUpDown NumUpDownCriarHora;
        private ListBox ListBoxAparelhosDisponiveis;
        private Label label4;
        private Label label5;
        private ListBox ListBoxVoos;
        private Label LblInfoVoo;
        private Label label11;
        private Button BtnEditar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TextBoxEditarOrigem;
        private TextBox TextBoxEditarDestino;
        private NumericUpDown NumUpDownEditarAno;
        private NumericUpDown NumUpDownEditarMes;
        private NumericUpDown NumUpDownEditarDia;
        private NumericUpDown NumUpDownEditarMinutosVoo;
        private NumericUpDown NumUpDownEditarMinuto;
        private NumericUpDown NumUpDownEditarHorasVoo;
        private NumericUpDown NumUpDownEditarHora;
        private DateTimePicker DateTimePickerCriarData;
        private DateTimePicker DateTimePickerEditarData;
    }
}
