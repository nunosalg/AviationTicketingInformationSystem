namespace ProjetoBilhetesAeronautica
{
    partial class UserControlBilhetes
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
            ListBoxVoos = new ListBox();
            label5 = new Label();
            ListBoxLugares = new ListBox();
            label4 = new Label();
            label11 = new Label();
            label1 = new Label();
            label2 = new Label();
            BtnConsultar = new Button();
            LblInfoVoo = new Label();
            label6 = new Label();
            BtnConfirmar = new Button();
            DateTimePickerConsultarData = new DateTimePicker();
            ComboBoxOrigens = new ComboBox();
            ComboBoxDestinos = new ComboBox();
            label3 = new Label();
            TextBoxDisposicaoLugares = new TextBox();
            SuspendLayout();
            // 
            // ListBoxVoos
            // 
            ListBoxVoos.FormattingEnabled = true;
            ListBoxVoos.Location = new Point(284, 63);
            ListBoxVoos.Name = "ListBoxVoos";
            ListBoxVoos.Size = new Size(158, 444);
            ListBoxVoos.TabIndex = 14;
            ListBoxVoos.SelectedIndexChanged += ListBoxVoos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 40);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 15;
            label5.Text = "Voos:";
            // 
            // ListBoxLugares
            // 
            ListBoxLugares.FormattingEnabled = true;
            ListBoxLugares.Location = new Point(459, 63);
            ListBoxLugares.Name = "ListBoxLugares";
            ListBoxLugares.Size = new Size(67, 444);
            ListBoxLugares.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 40);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 16;
            label4.Text = "Lugares:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(545, 40);
            label11.Name = "label11";
            label11.Size = new Size(165, 20);
            label11.TabIndex = 18;
            label11.Text = "Disposição dos lugares:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 15;
            label1.Text = "Origem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 170);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 25;
            label2.Text = "Consultar por data:";
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = Color.FromArgb(70, 60, 161);
            BtnConsultar.Cursor = Cursors.Hand;
            BtnConsultar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConsultar.ForeColor = Color.White;
            BtnConsultar.Location = new Point(49, 242);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(126, 67);
            BtnConsultar.TabIndex = 26;
            BtnConsultar.Text = "Consultar Voos";
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // LblInfoVoo
            // 
            LblInfoVoo.BorderStyle = BorderStyle.FixedSingle;
            LblInfoVoo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInfoVoo.ForeColor = SystemColors.ControlText;
            LblInfoVoo.Location = new Point(772, 63);
            LblInfoVoo.Name = "LblInfoVoo";
            LblInfoVoo.Size = new Size(201, 283);
            LblInfoVoo.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(772, 40);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 18;
            label6.Text = "Informação do voo:";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(70, 60, 161);
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(772, 364);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(119, 62);
            BtnConfirmar.TabIndex = 26;
            BtnConfirmar.Text = "Confirmar Voo";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // DateTimePickerConsultarData
            // 
            DateTimePickerConsultarData.Location = new Point(49, 193);
            DateTimePickerConsultarData.MinDate = new DateTime(2024, 6, 17, 0, 0, 0, 0);
            DateTimePickerConsultarData.Name = "DateTimePickerConsultarData";
            DateTimePickerConsultarData.ShowCheckBox = true;
            DateTimePickerConsultarData.Size = new Size(218, 27);
            DateTimePickerConsultarData.TabIndex = 28;
            // 
            // ComboBoxOrigens
            // 
            ComboBoxOrigens.FormattingEnabled = true;
            ComboBoxOrigens.Location = new Point(52, 64);
            ComboBoxOrigens.Name = "ComboBoxOrigens";
            ComboBoxOrigens.Size = new Size(216, 28);
            ComboBoxOrigens.Sorted = true;
            ComboBoxOrigens.TabIndex = 29;
            // 
            // ComboBoxDestinos
            // 
            ComboBoxDestinos.FormattingEnabled = true;
            ComboBoxDestinos.Location = new Point(50, 125);
            ComboBoxDestinos.Name = "ComboBoxDestinos";
            ComboBoxDestinos.Size = new Size(217, 28);
            ComboBoxDestinos.Sorted = true;
            ComboBoxDestinos.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 102);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 15;
            label3.Text = "Destino:";
            // 
            // TextBoxDisposicaoLugares
            // 
            TextBoxDisposicaoLugares.Location = new Point(545, 65);
            TextBoxDisposicaoLugares.Multiline = true;
            TextBoxDisposicaoLugares.Name = "TextBoxDisposicaoLugares";
            TextBoxDisposicaoLugares.ReadOnly = true;
            TextBoxDisposicaoLugares.Size = new Size(202, 442);
            TextBoxDisposicaoLugares.TabIndex = 31;
            // 
            // UserControlBilhetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBoxDisposicaoLugares);
            Controls.Add(ComboBoxDestinos);
            Controls.Add(ComboBoxOrigens);
            Controls.Add(DateTimePickerConsultarData);
            Controls.Add(LblInfoVoo);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnConsultar);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(ListBoxLugares);
            Controls.Add(label4);
            Controls.Add(ListBoxVoos);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "UserControlBilhetes";
            Size = new Size(1023, 550);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxVoos;
        private Label label5;
        private ListBox ListBoxLugares;
        private Label label4;
        private Label label11;
        private Label label1;
        private Label label2;
        private Button BtnConsultar;
        private Label LblInfoVoo;
        private Label label6;
        private Button BtnConfirmar;
        private DateTimePicker DateTimePickerConsultarData;
        private ComboBox ComboBoxOrigens;
        private ComboBox ComboBoxDestinos;
        private Label label3;
        private TextBox TextBoxDisposicaoLugares;
    }
}
