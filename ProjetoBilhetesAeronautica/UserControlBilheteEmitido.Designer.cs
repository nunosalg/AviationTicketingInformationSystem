namespace ProjetoBilhetesAeronautica
{
    partial class UserControlBilheteEmitido
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
            panel1 = new Panel();
            LblId = new Label();
            pictureBox1 = new PictureBox();
            LblHoraChegada = new Label();
            label2 = new Label();
            LblDataHoraPartida = new Label();
            LblLugar = new Label();
            LblNomePassageiro = new Label();
            LblNumeroVoo = new Label();
            LblOrigemDestino = new Label();
            LblCompanhiaAerea = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LblId);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblHoraChegada);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LblDataHoraPartida);
            panel1.Controls.Add(LblLugar);
            panel1.Controls.Add(LblNomePassageiro);
            panel1.Controls.Add(LblNumeroVoo);
            panel1.Controls.Add(LblOrigemDestino);
            panel1.Controls.Add(LblCompanhiaAerea);
            panel1.Location = new Point(72, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 392);
            panel1.TabIndex = 0;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.BackColor = Color.FromArgb(70, 60, 161);
            LblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblId.ForeColor = Color.White;
            LblId.Location = new Point(799, 15);
            LblId.Name = "LblId";
            LblId.Size = new Size(76, 31);
            LblId.TabIndex = 3;
            LblId.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.qrcode_ticket;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(522, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LblHoraChegada
            // 
            LblHoraChegada.AutoSize = true;
            LblHoraChegada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHoraChegada.Location = new Point(29, 260);
            LblHoraChegada.Name = "LblHoraChegada";
            LblHoraChegada.Size = new Size(65, 28);
            LblHoraChegada.TabIndex = 1;
            LblHoraChegada.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 342);
            label2.Name = "label2";
            label2.Size = new Size(287, 28);
            label2.TabIndex = 1;
            label2.Text = "Embarque até 30 minutos antes";
            // 
            // LblDataHoraPartida
            // 
            LblDataHoraPartida.AutoSize = true;
            LblDataHoraPartida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDataHoraPartida.Location = new Point(29, 223);
            LblDataHoraPartida.Name = "LblDataHoraPartida";
            LblDataHoraPartida.Size = new Size(65, 28);
            LblDataHoraPartida.TabIndex = 1;
            LblDataHoraPartida.Text = "label2";
            // 
            // LblLugar
            // 
            LblLugar.AutoSize = true;
            LblLugar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLugar.Location = new Point(522, 159);
            LblLugar.Name = "LblLugar";
            LblLugar.Size = new Size(65, 28);
            LblLugar.TabIndex = 1;
            LblLugar.Text = "label2";
            // 
            // LblNomePassageiro
            // 
            LblNomePassageiro.AutoSize = true;
            LblNomePassageiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNomePassageiro.Location = new Point(518, 95);
            LblNomePassageiro.Name = "LblNomePassageiro";
            LblNomePassageiro.Size = new Size(65, 28);
            LblNomePassageiro.TabIndex = 1;
            LblNomePassageiro.Text = "label2";
            // 
            // LblNumeroVoo
            // 
            LblNumeroVoo.AutoSize = true;
            LblNumeroVoo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNumeroVoo.Location = new Point(29, 95);
            LblNumeroVoo.Name = "LblNumeroVoo";
            LblNumeroVoo.Size = new Size(65, 28);
            LblNumeroVoo.TabIndex = 1;
            LblNumeroVoo.Text = "label2";
            // 
            // LblOrigemDestino
            // 
            LblOrigemDestino.AutoSize = true;
            LblOrigemDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblOrigemDestino.Location = new Point(29, 159);
            LblOrigemDestino.Name = "LblOrigemDestino";
            LblOrigemDestino.Size = new Size(65, 28);
            LblOrigemDestino.TabIndex = 1;
            LblOrigemDestino.Text = "label2";
            // 
            // LblCompanhiaAerea
            // 
            LblCompanhiaAerea.BackColor = Color.FromArgb(70, 60, 161);
            LblCompanhiaAerea.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCompanhiaAerea.ForeColor = Color.White;
            LblCompanhiaAerea.Location = new Point(-1, -1);
            LblCompanhiaAerea.Name = "LblCompanhiaAerea";
            LblCompanhiaAerea.Size = new Size(883, 65);
            LblCompanhiaAerea.TabIndex = 0;
            LblCompanhiaAerea.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 471);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 1;
            label3.Text = "Download do bilhete";
            // 
            // UserControlBilheteEmitido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "UserControlBilheteEmitido";
            Size = new Size(1023, 550);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LblCompanhiaAerea;
        private Label LblOrigemDestino;
        private Label label3;
        private Label LblHoraChegada;
        private Label LblDataHoraPartida;
        private PictureBox pictureBox1;
        private Label LblLugar;
        private Label LblNomePassageiro;
        private Label LblNumeroVoo;
        private Label LblId;
        private Label label2;
    }
}
