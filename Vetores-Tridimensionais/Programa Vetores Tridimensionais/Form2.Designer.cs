namespace Programa_Vetores_Tridimensionais
{
    partial class frmVetores
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
            this.btnDefinicaoVetor = new System.Windows.Forms.Button();
            this.btnCaracteristicasVetor = new System.Windows.Forms.Button();
            this.btnCalculoVetor = new System.Windows.Forms.Button();
            this.btnVetorBidimensional = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVetorTridimensional = new System.Windows.Forms.Button();
            this.lblTextoVetores = new System.Windows.Forms.Label();
            this.picComeco = new System.Windows.Forms.PictureBox();
            this.btnIjk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picComeco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefinicaoVetor
            // 
            this.btnDefinicaoVetor.BackColor = System.Drawing.Color.LightGray;
            this.btnDefinicaoVetor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinicaoVetor.Location = new System.Drawing.Point(48, 59);
            this.btnDefinicaoVetor.Name = "btnDefinicaoVetor";
            this.btnDefinicaoVetor.Size = new System.Drawing.Size(184, 43);
            this.btnDefinicaoVetor.TabIndex = 0;
            this.btnDefinicaoVetor.Text = "Definição";
            this.btnDefinicaoVetor.UseVisualStyleBackColor = false;
            this.btnDefinicaoVetor.Click += new System.EventHandler(this.lblDefinicaoVetor_Click);
            // 
            // btnCaracteristicasVetor
            // 
            this.btnCaracteristicasVetor.BackColor = System.Drawing.Color.Khaki;
            this.btnCaracteristicasVetor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracteristicasVetor.Location = new System.Drawing.Point(48, 108);
            this.btnCaracteristicasVetor.Name = "btnCaracteristicasVetor";
            this.btnCaracteristicasVetor.Size = new System.Drawing.Size(184, 43);
            this.btnCaracteristicasVetor.TabIndex = 1;
            this.btnCaracteristicasVetor.Text = "Características";
            this.btnCaracteristicasVetor.UseVisualStyleBackColor = false;
            this.btnCaracteristicasVetor.Click += new System.EventHandler(this.btnCaracteristicasVetor_Click);
            // 
            // btnCalculoVetor
            // 
            this.btnCalculoVetor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCalculoVetor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoVetor.Location = new System.Drawing.Point(48, 157);
            this.btnCalculoVetor.Name = "btnCalculoVetor";
            this.btnCalculoVetor.Size = new System.Drawing.Size(184, 43);
            this.btnCalculoVetor.TabIndex = 2;
            this.btnCalculoVetor.Text = "Cálculo";
            this.btnCalculoVetor.UseVisualStyleBackColor = false;
            this.btnCalculoVetor.Click += new System.EventHandler(this.btnCalculoVetor_Click);
            // 
            // btnVetorBidimensional
            // 
            this.btnVetorBidimensional.BackColor = System.Drawing.Color.Aqua;
            this.btnVetorBidimensional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetorBidimensional.Location = new System.Drawing.Point(48, 206);
            this.btnVetorBidimensional.Name = "btnVetorBidimensional";
            this.btnVetorBidimensional.Size = new System.Drawing.Size(184, 43);
            this.btnVetorBidimensional.TabIndex = 3;
            this.btnVetorBidimensional.Text = "Vetor Bidimensional";
            this.btnVetorBidimensional.UseVisualStyleBackColor = false;
            this.btnVetorBidimensional.Click += new System.EventHandler(this.btnVetorBidimensional_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vetores: o que são?";
            // 
            // btnVetorTridimensional
            // 
            this.btnVetorTridimensional.BackColor = System.Drawing.Color.Violet;
            this.btnVetorTridimensional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetorTridimensional.Location = new System.Drawing.Point(48, 255);
            this.btnVetorTridimensional.Name = "btnVetorTridimensional";
            this.btnVetorTridimensional.Size = new System.Drawing.Size(184, 43);
            this.btnVetorTridimensional.TabIndex = 4;
            this.btnVetorTridimensional.Text = "Vetor Tridimensional";
            this.btnVetorTridimensional.UseVisualStyleBackColor = false;
            this.btnVetorTridimensional.Click += new System.EventHandler(this.btnVetorTridimensional_Click);
            // 
            // lblTextoVetores
            // 
            this.lblTextoVetores.AutoSize = true;
            this.lblTextoVetores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVetores.Location = new System.Drawing.Point(282, 28);
            this.lblTextoVetores.Name = "lblTextoVetores";
            this.lblTextoVetores.Size = new System.Drawing.Size(0, 16);
            this.lblTextoVetores.TabIndex = 8;
            // 
            // picComeco
            // 
            this.picComeco.Image = global::Programa_Vetores_Tridimensionais.Properties.Resources.imgVetorTridimensional;
            this.picComeco.Location = new System.Drawing.Point(373, 166);
            this.picComeco.Name = "picComeco";
            this.picComeco.Size = new System.Drawing.Size(236, 155);
            this.picComeco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComeco.TabIndex = 9;
            this.picComeco.TabStop = false;
            // 
            // btnIjk
            // 
            this.btnIjk.BackColor = System.Drawing.Color.Yellow;
            this.btnIjk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIjk.Location = new System.Drawing.Point(48, 304);
            this.btnIjk.Name = "btnIjk";
            this.btnIjk.Size = new System.Drawing.Size(184, 43);
            this.btnIjk.TabIndex = 10;
            this.btnIjk.Text = "Método I J K";
            this.btnIjk.UseVisualStyleBackColor = false;
            this.btnIjk.Click += new System.EventHandler(this.btnIjk_Click);
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 374);
            this.Controls.Add(this.btnIjk);
            this.Controls.Add(this.picComeco);
            this.Controls.Add(this.lblTextoVetores);
            this.Controls.Add(this.btnVetorTridimensional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVetorBidimensional);
            this.Controls.Add(this.btnCalculoVetor);
            this.Controls.Add(this.btnCaracteristicasVetor);
            this.Controls.Add(this.btnDefinicaoVetor);
            this.Name = "frmVetores";
            this.Text = "Vetores";
            this.Load += new System.EventHandler(this.frmComeco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComeco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefinicaoVetor;
        private System.Windows.Forms.Button btnCaracteristicasVetor;
        private System.Windows.Forms.Button btnCalculoVetor;
        private System.Windows.Forms.Button btnVetorBidimensional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVetorTridimensional;
        private System.Windows.Forms.Label lblTextoVetores;
        private System.Windows.Forms.PictureBox picComeco;
        private System.Windows.Forms.Button btnIjk;
    }
}