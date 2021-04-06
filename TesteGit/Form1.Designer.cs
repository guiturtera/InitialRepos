namespace CalculoIncerteza
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.lblVetor = new System.Windows.Forms.Label();
            this.txtVetor = new System.Windows.Forms.TextBox();
            this.btnInterpola = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtEngHi = new System.Windows.Forms.TextBox();
            this.txtMedidaHi = new System.Windows.Forms.TextBox();
            this.txtMedidaLow = new System.Windows.Forms.TextBox();
            this.txtEngLow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimparVetor = new System.Windows.Forms.Button();
            this.btnDesvioPadrao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnVF = new System.Windows.Forms.Button();
            this.btnTaxa = new System.Windows.Forms.Button();
            this.btnVP = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(166, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(273, 19);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Silver;
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(60, 151);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(100, 42);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "Média";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Moda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.BackColor = System.Drawing.Color.Silver;
            this.btnMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediana.Location = new System.Drawing.Point(167, 151);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(100, 42);
            this.btnMediana.TabIndex = 5;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = false;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // lblVetor
            // 
            this.lblVetor.AutoSize = true;
            this.lblVetor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetor.Location = new System.Drawing.Point(57, 36);
            this.lblVetor.Name = "lblVetor";
            this.lblVetor.Size = new System.Drawing.Size(70, 16);
            this.lblVetor.TabIndex = 6;
            this.lblVetor.Text = "Seu vetor:";
            // 
            // txtVetor
            // 
            this.txtVetor.Enabled = false;
            this.txtVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVetor.Location = new System.Drawing.Point(60, 55);
            this.txtVetor.Multiline = true;
            this.txtVetor.Name = "txtVetor";
            this.txtVetor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVetor.Size = new System.Drawing.Size(525, 90);
            this.txtVetor.TabIndex = 7;
            this.txtVetor.TextChanged += new System.EventHandler(this.txtVetor_TextChanged);
            // 
            // btnInterpola
            // 
            this.btnInterpola.BackColor = System.Drawing.Color.Silver;
            this.btnInterpola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpola.Location = new System.Drawing.Point(419, 405);
            this.btnInterpola.Name = "btnInterpola";
            this.btnInterpola.Size = new System.Drawing.Size(100, 42);
            this.btnInterpola.TabIndex = 8;
            this.btnInterpola.Text = "Interpolação";
            this.btnInterpola.UseVisualStyleBackColor = false;
            this.btnInterpola.Click += new System.EventHandler(this.btnInterpola_Click);
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMedida.Location = new System.Drawing.Point(348, 271);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 9;
            this.txtMedida.TextChanged += new System.EventHandler(this.txtMedida_TextChanged);
            // 
            // txtEngHi
            // 
            this.txtEngHi.BackColor = System.Drawing.Color.LightSalmon;
            this.txtEngHi.Location = new System.Drawing.Point(489, 319);
            this.txtEngHi.Name = "txtEngHi";
            this.txtEngHi.Size = new System.Drawing.Size(100, 20);
            this.txtEngHi.TabIndex = 10;
            // 
            // txtMedidaHi
            // 
            this.txtMedidaHi.BackColor = System.Drawing.Color.LightCoral;
            this.txtMedidaHi.Location = new System.Drawing.Point(348, 319);
            this.txtMedidaHi.Name = "txtMedidaHi";
            this.txtMedidaHi.Size = new System.Drawing.Size(100, 20);
            this.txtMedidaHi.TabIndex = 11;
            // 
            // txtMedidaLow
            // 
            this.txtMedidaLow.BackColor = System.Drawing.Color.LightCoral;
            this.txtMedidaLow.Location = new System.Drawing.Point(348, 362);
            this.txtMedidaLow.Name = "txtMedidaLow";
            this.txtMedidaLow.Size = new System.Drawing.Size(100, 20);
            this.txtMedidaLow.TabIndex = 12;
            // 
            // txtEngLow
            // 
            this.txtEngLow.BackColor = System.Drawing.Color.LightSalmon;
            this.txtEngLow.Location = new System.Drawing.Point(489, 362);
            this.txtEngLow.Name = "txtEngLow";
            this.txtEngLow.Size = new System.Drawing.Size(100, 20);
            this.txtEngLow.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "EngLow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "EngHi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "MedidaLow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "MedidaHi";
            // 
            // txtResposta
            // 
            this.txtResposta.BackColor = System.Drawing.SystemColors.Control;
            this.txtResposta.Enabled = false;
            this.txtResposta.ForeColor = System.Drawing.Color.Magenta;
            this.txtResposta.Location = new System.Drawing.Point(489, 271);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 20);
            this.txtResposta.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Resposta";
            // 
            // btnLimparVetor
            // 
            this.btnLimparVetor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparVetor.Location = new System.Drawing.Point(485, 151);
            this.btnLimparVetor.Name = "btnLimparVetor";
            this.btnLimparVetor.Size = new System.Drawing.Size(100, 42);
            this.btnLimparVetor.TabIndex = 21;
            this.btnLimparVetor.Text = "Limpar Vetor";
            this.btnLimparVetor.UseVisualStyleBackColor = false;
            this.btnLimparVetor.Click += new System.EventHandler(this.btnLimparVetor_Click);
            // 
            // btnDesvioPadrao
            // 
            this.btnDesvioPadrao.BackColor = System.Drawing.Color.Silver;
            this.btnDesvioPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesvioPadrao.Location = new System.Drawing.Point(379, 151);
            this.btnDesvioPadrao.Name = "btnDesvioPadrao";
            this.btnDesvioPadrao.Size = new System.Drawing.Size(100, 42);
            this.btnDesvioPadrao.TabIndex = 22;
            this.btnDesvioPadrao.Text = "DesvioPadrão";
            this.btnDesvioPadrao.UseVisualStyleBackColor = false;
            this.btnDesvioPadrao.Click += new System.EventHandler(this.btnDesvioPadrao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "--------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 224);
            this.label8.TabIndex = 24;
            this.label8.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // txtMeses
            // 
            this.txtMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMeses.Location = new System.Drawing.Point(105, 337);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 28;
            // 
            // txtVP
            // 
            this.txtVP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVP.Location = new System.Drawing.Point(105, 285);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 29;
            // 
            // txtVF
            // 
            this.txtVF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVF.Location = new System.Drawing.Point(105, 256);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(100, 20);
            this.txtVF.TabIndex = 30;
            // 
            // txtTaxa
            // 
            this.txtTaxa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaxa.Location = new System.Drawing.Point(105, 311);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(100, 20);
            this.txtTaxa.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(451, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 27);
            this.label14.TabIndex = 34;
            this.label14.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(451, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 27);
            this.label15.TabIndex = 35;
            this.label15.Text = "--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(451, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 27);
            this.label16.TabIndex = 36;
            this.label16.Text = "--";
            // 
            // btnVF
            // 
            this.btnVF.BackColor = System.Drawing.Color.Silver;
            this.btnVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVF.Location = new System.Drawing.Point(60, 421);
            this.btnVF.Name = "btnVF";
            this.btnVF.Size = new System.Drawing.Size(100, 42);
            this.btnVF.TabIndex = 37;
            this.btnVF.Text = "VF";
            this.btnVF.UseVisualStyleBackColor = false;
            this.btnVF.Click += new System.EventHandler(this.btnVF_Click);
            // 
            // btnTaxa
            // 
            this.btnTaxa.BackColor = System.Drawing.Color.Silver;
            this.btnTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaxa.Location = new System.Drawing.Point(60, 373);
            this.btnTaxa.Name = "btnTaxa";
            this.btnTaxa.Size = new System.Drawing.Size(100, 42);
            this.btnTaxa.TabIndex = 38;
            this.btnTaxa.Text = "Taxa";
            this.btnTaxa.UseVisualStyleBackColor = false;
            this.btnTaxa.Click += new System.EventHandler(this.btnTaxa_Click);
            // 
            // btnVP
            // 
            this.btnVP.BackColor = System.Drawing.Color.Silver;
            this.btnVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVP.Location = new System.Drawing.Point(166, 421);
            this.btnVP.Name = "btnVP";
            this.btnVP.Size = new System.Drawing.Size(100, 42);
            this.btnVP.TabIndex = 39;
            this.btnVP.Text = "VP";
            this.btnVP.UseVisualStyleBackColor = false;
            this.btnVP.Click += new System.EventHandler(this.btnVP_Click);
            // 
            // btnMeses
            // 
            this.btnMeses.BackColor = System.Drawing.Color.Silver;
            this.btnMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeses.Location = new System.Drawing.Point(166, 373);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(100, 42);
            this.btnMeses.TabIndex = 40;
            this.btnMeses.Text = "Meses";
            this.btnMeses.UseVisualStyleBackColor = false;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "R$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(211, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(211, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Meses";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(75, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "VF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(74, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 46;
            this.label18.Text = "VP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(62, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "Taxa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 337);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Tempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 493);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnVP);
            this.Controls.Add(this.btnTaxa);
            this.Controls.Add(this.btnVF);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDesvioPadrao);
            this.Controls.Add(this.btnLimparVetor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEngLow);
            this.Controls.Add(this.txtMedidaLow);
            this.Controls.Add(this.txtMedidaHi);
            this.Controls.Add(this.txtEngHi);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.btnInterpola);
            this.Controls.Add(this.txtVetor);
            this.Controls.Add(this.lblVetor);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Label lblVetor;
        private System.Windows.Forms.TextBox txtVetor;
        private System.Windows.Forms.Button btnInterpola;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtEngHi;
        private System.Windows.Forms.TextBox txtMedidaHi;
        private System.Windows.Forms.TextBox txtMedidaLow;
        private System.Windows.Forms.TextBox txtEngLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimparVetor;
        private System.Windows.Forms.Button btnDesvioPadrao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnVF;
        private System.Windows.Forms.Button btnTaxa;
        private System.Windows.Forms.Button btnVP;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

    }
}

