namespace JogoDUDU
{
    partial class frPerseguicao
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
            this.components = new System.ComponentModel.Container();
            this.picInimigo = new System.Windows.Forms.PictureBox();
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tmrMovimento = new System.Windows.Forms.Timer(this.components);
            this.Verifica = new System.Windows.Forms.Timer(this.components);
            this.lblTempoRestante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picInimigo
            // 
            this.picInimigo.Image = global::JogoDUDU.Properties.Resources.bgTelaConfigs;
            this.picInimigo.Location = new System.Drawing.Point(470, 206);
            this.picInimigo.Name = "picInimigo";
            this.picInimigo.Size = new System.Drawing.Size(50, 50);
            this.picInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInimigo.TabIndex = 1;
            this.picInimigo.TabStop = false;
            // 
            // picJogador
            // 
            this.picJogador.Image = global::JogoDUDU.Properties.Resources.bgTelaAjuda;
            this.picJogador.Location = new System.Drawing.Point(297, 206);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(50, 50);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador.TabIndex = 0;
            this.picJogador.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-86, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 575);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(766, -27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 575);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-23, -47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(887, 60);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(-23, 487);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(872, 61);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // tmrMovimento
            // 
            this.tmrMovimento.Interval = 50;
            this.tmrMovimento.Tick += new System.EventHandler(this.tmrMovimento_Tick);
            // 
            // Verifica
            // 
            this.Verifica.Interval = 1000;
            this.Verifica.Tick += new System.EventHandler(this.Verifica_Tick);
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.BackColor = System.Drawing.Color.Red;
            this.lblTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.ForeColor = System.Drawing.Color.White;
            this.lblTempoRestante.Location = new System.Drawing.Point(717, 474);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(76, 24);
            this.lblTempoRestante.TabIndex = 6;
            this.lblTempoRestante.Text = "Tempo";
            // 
            // frPerseguicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.ControlBox = false;
            this.Controls.Add(this.lblTempoRestante);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picInimigo);
            this.Controls.Add(this.picJogador);
            this.Name = "frPerseguicao";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picInimigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer tmrMovimento;
        private System.Windows.Forms.Timer Verifica;
        private System.Windows.Forms.Label lblTempoRestante;
    }
}

