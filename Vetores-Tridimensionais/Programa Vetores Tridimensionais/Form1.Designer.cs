namespace Programa_Vetores_Tridimensionais
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtDistanciaZ = new System.Windows.Forms.TextBox();
            this.txtDistanciaFbY = new System.Windows.Forms.TextBox();
            this.txtDistanciaFbX = new System.Windows.Forms.TextBox();
            this.txtDistanciaFcX = new System.Windows.Forms.TextBox();
            this.txtDistanciaFcY = new System.Windows.Forms.TextBox();
            this.lblFb = new System.Windows.Forms.Label();
            this.lblFc = new System.Windows.Forms.Label();
            this.lblPedidaFb = new System.Windows.Forms.Label();
            this.lblPedidaFc = new System.Windows.Forms.Label();
            this.txtFc = new System.Windows.Forms.TextBox();
            this.txtFb = new System.Windows.Forms.TextBox();
            this.btnIntro = new System.Windows.Forms.Button();
            this.btnVetores = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.picTermo = new System.Windows.Forms.PictureBox();
            this.picExercicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTermo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(39, 29);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(403, 38);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Determinar a força resultante e os ângulos diretores\r\nno ponto A, com base nos da" +
    "dos fornecidos:";
            // 
            // txtDistanciaZ
            // 
            this.txtDistanciaZ.Location = new System.Drawing.Point(438, 201);
            this.txtDistanciaZ.Name = "txtDistanciaZ";
            this.txtDistanciaZ.Size = new System.Drawing.Size(31, 20);
            this.txtDistanciaZ.TabIndex = 2;
            this.txtDistanciaZ.TextChanged += new System.EventHandler(this.txtDistanciaZ_TextChanged);
            // 
            // txtDistanciaFbY
            // 
            this.txtDistanciaFbY.Location = new System.Drawing.Point(461, 331);
            this.txtDistanciaFbY.Name = "txtDistanciaFbY";
            this.txtDistanciaFbY.Size = new System.Drawing.Size(26, 20);
            this.txtDistanciaFbY.TabIndex = 4;
            this.txtDistanciaFbY.TextChanged += new System.EventHandler(this.txtDistanciaFbY_TextChanged);
            // 
            // txtDistanciaFbX
            // 
            this.txtDistanciaFbX.Location = new System.Drawing.Point(412, 281);
            this.txtDistanciaFbX.Name = "txtDistanciaFbX";
            this.txtDistanciaFbX.Size = new System.Drawing.Size(25, 20);
            this.txtDistanciaFbX.TabIndex = 3;
            this.txtDistanciaFbX.TextChanged += new System.EventHandler(this.txtDistanciaFbX_TextChanged);
            // 
            // txtDistanciaFcX
            // 
            this.txtDistanciaFcX.Location = new System.Drawing.Point(621, 365);
            this.txtDistanciaFcX.Name = "txtDistanciaFcX";
            this.txtDistanciaFcX.Size = new System.Drawing.Size(26, 20);
            this.txtDistanciaFcX.TabIndex = 6;
            this.txtDistanciaFcX.TextChanged += new System.EventHandler(this.txtDistanciaFcX_TextChanged);
            // 
            // txtDistanciaFcY
            // 
            this.txtDistanciaFcY.Location = new System.Drawing.Point(511, 375);
            this.txtDistanciaFcY.Name = "txtDistanciaFcY";
            this.txtDistanciaFcY.Size = new System.Drawing.Size(29, 20);
            this.txtDistanciaFcY.TabIndex = 5;
            this.txtDistanciaFcY.TextChanged += new System.EventHandler(this.txtDistanciaFcY_TextChanged);
            // 
            // lblFb
            // 
            this.lblFb.AutoSize = true;
            this.lblFb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFb.Location = new System.Drawing.Point(528, 205);
            this.lblFb.Name = "lblFb";
            this.lblFb.Size = new System.Drawing.Size(24, 16);
            this.lblFb.TabIndex = 9;
            this.lblFb.Text = "Fb";
            // 
            // lblFc
            // 
            this.lblFc.AutoSize = true;
            this.lblFc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFc.Location = new System.Drawing.Point(597, 225);
            this.lblFc.Name = "lblFc";
            this.lblFc.Size = new System.Drawing.Size(23, 16);
            this.lblFc.TabIndex = 10;
            this.lblFc.Text = "Fc";
            // 
            // lblPedidaFb
            // 
            this.lblPedidaFb.AutoSize = true;
            this.lblPedidaFb.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPedidaFb.Location = new System.Drawing.Point(40, 152);
            this.lblPedidaFb.Name = "lblPedidaFb";
            this.lblPedidaFb.Size = new System.Drawing.Size(140, 18);
            this.lblPedidaFb.TabIndex = 11;
            this.lblPedidaFb.Text = "Escreva a força Fb";
            // 
            // lblPedidaFc
            // 
            this.lblPedidaFc.AutoSize = true;
            this.lblPedidaFc.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPedidaFc.Location = new System.Drawing.Point(41, 184);
            this.lblPedidaFc.Name = "lblPedidaFc";
            this.lblPedidaFc.Size = new System.Drawing.Size(139, 18);
            this.lblPedidaFc.TabIndex = 12;
            this.lblPedidaFc.Text = "Escreva a força Fc";
            // 
            // txtFc
            // 
            this.txtFc.Location = new System.Drawing.Point(185, 184);
            this.txtFc.Name = "txtFc";
            this.txtFc.Size = new System.Drawing.Size(141, 20);
            this.txtFc.TabIndex = 1;
            this.txtFc.TextChanged += new System.EventHandler(this.txtFc_TextChanged);
            // 
            // txtFb
            // 
            this.txtFb.Location = new System.Drawing.Point(186, 150);
            this.txtFb.Name = "txtFb";
            this.txtFb.Size = new System.Drawing.Size(140, 20);
            this.txtFb.TabIndex = 0;
            this.txtFb.TextChanged += new System.EventHandler(this.txtFb_TextChanged);
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.Moccasin;
            this.btnIntro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(43, 85);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(116, 46);
            this.btnIntro.TabIndex = 15;
            this.btnIntro.Text = "Introdução";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnVetores
            // 
            this.btnVetores.BackColor = System.Drawing.Color.Moccasin;
            this.btnVetores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetores.Location = new System.Drawing.Point(211, 85);
            this.btnVetores.Name = "btnVetores";
            this.btnVetores.Size = new System.Drawing.Size(116, 46);
            this.btnVetores.TabIndex = 16;
            this.btnVetores.Text = "Vetores";
            this.btnVetores.UseVisualStyleBackColor = false;
            this.btnVetores.Click += new System.EventHandler(this.btnComeco_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Moccasin;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(43, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(282, 46);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Moccasin;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(42, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(284, 46);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(332, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(332, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "N";
            // 
            // btnComecar
            // 
            this.btnComecar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnComecar.BackColor = System.Drawing.Color.Moccasin;
            this.btnComecar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnComecar.Location = new System.Drawing.Point(42, 235);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(284, 46);
            this.btnComecar.TabIndex = 31;
            this.btnComecar.Text = "Começar exercício";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // picTermo
            // 
            this.picTermo.Image = ((System.Drawing.Image)(resources.GetObject("picTermo.Image")));
            this.picTermo.Location = new System.Drawing.Point(511, 12);
            this.picTermo.Name = "picTermo";
            this.picTermo.Size = new System.Drawing.Size(121, 76);
            this.picTermo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermo.TabIndex = 1;
            this.picTermo.TabStop = false;
            // 
            // picExercicio
            // 
            this.picExercicio.BackColor = System.Drawing.Color.Transparent;
            this.picExercicio.Image = global::Programa_Vetores_Tridimensionais.Properties.Resources.Captura_de_Tela__87_;
            this.picExercicio.Location = new System.Drawing.Point(389, 94);
            this.picExercicio.Name = "picExercicio";
            this.picExercicio.Size = new System.Drawing.Size(358, 327);
            this.picExercicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExercicio.TabIndex = 0;
            this.picExercicio.TabStop = false;
            this.picExercicio.Click += new System.EventHandler(this.picExercicio_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 445);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVetores);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.txtFb);
            this.Controls.Add(this.txtFc);
            this.Controls.Add(this.lblPedidaFc);
            this.Controls.Add(this.lblPedidaFb);
            this.Controls.Add(this.lblFc);
            this.Controls.Add(this.lblFb);
            this.Controls.Add(this.txtDistanciaFcY);
            this.Controls.Add(this.txtDistanciaFcX);
            this.Controls.Add(this.txtDistanciaFbX);
            this.Controls.Add(this.txtDistanciaFbY);
            this.Controls.Add(this.txtDistanciaZ);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.picTermo);
            this.Controls.Add(this.picExercicio);
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTermo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picExercicio;
        private System.Windows.Forms.PictureBox picTermo;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtDistanciaZ;
        private System.Windows.Forms.TextBox txtDistanciaFbY;
        private System.Windows.Forms.TextBox txtDistanciaFbX;
        private System.Windows.Forms.TextBox txtDistanciaFcX;
        private System.Windows.Forms.TextBox txtDistanciaFcY;
        private System.Windows.Forms.Label lblFb;
        private System.Windows.Forms.Label lblFc;
        private System.Windows.Forms.Label lblPedidaFb;
        private System.Windows.Forms.Label lblPedidaFc;
        private System.Windows.Forms.TextBox txtFc;
        private System.Windows.Forms.TextBox txtFb;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Button btnVetores;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComecar;
    }
}

