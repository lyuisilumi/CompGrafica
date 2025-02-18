namespace ProcessamentoImagens
{
    partial class frmPrincipal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.lbMatiz = new System.Windows.Forms.Label();
            this.lbSaturacao = new System.Windows.Forms.Label();
            this.lbLuminancia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVerde = new System.Windows.Forms.Label();
            this.lbAzul = new System.Windows.Forms.Label();
            this.tbMatiz = new System.Windows.Forms.TextBox();
            this.tbSat = new System.Windows.Forms.TextBox();
            this.tbLum = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarBrilho = new System.Windows.Forms.TrackBar();
            this.tbBrilho = new System.Windows.Forms.TextBox();
            this.nUDmatiz = new System.Windows.Forms.NumericUpDown();
            this.btnMiniatura = new System.Windows.Forms.Button();
            this.nUDMinHue = new System.Windows.Forms.NumericUpDown();
            this.nUDMaxHue = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrarMatiz_Click = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmatiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxHue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 128);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(1205, 573);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            this.pictBoxImg1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseMove);
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(975, 11);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(975, 39);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(1083, 11);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(120, 23);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // lbMatiz
            // 
            this.lbMatiz.AutoSize = true;
            this.lbMatiz.Location = new System.Drawing.Point(27, 28);
            this.lbMatiz.Name = "lbMatiz";
            this.lbMatiz.Size = new System.Drawing.Size(32, 13);
            this.lbMatiz.TabIndex = 110;
            this.lbMatiz.Text = "Matiz";
            this.lbMatiz.Click += new System.EventHandler(this.lbMatiz_Click);
            // 
            // lbSaturacao
            // 
            this.lbSaturacao.AutoSize = true;
            this.lbSaturacao.Location = new System.Drawing.Point(27, 64);
            this.lbSaturacao.Name = "lbSaturacao";
            this.lbSaturacao.Size = new System.Drawing.Size(56, 13);
            this.lbSaturacao.TabIndex = 111;
            this.lbSaturacao.Text = "Saturação";
            // 
            // lbLuminancia
            // 
            this.lbLuminancia.AutoSize = true;
            this.lbLuminancia.Location = new System.Drawing.Point(27, 99);
            this.lbLuminancia.Name = "lbLuminancia";
            this.lbLuminancia.Size = new System.Drawing.Size(61, 13);
            this.lbLuminancia.TabIndex = 112;
            this.lbLuminancia.Text = "Luminancia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Vermelho";
            // 
            // lbVerde
            // 
            this.lbVerde.AutoSize = true;
            this.lbVerde.Location = new System.Drawing.Point(168, 64);
            this.lbVerde.Name = "lbVerde";
            this.lbVerde.Size = new System.Drawing.Size(35, 13);
            this.lbVerde.TabIndex = 114;
            this.lbVerde.Text = "Verde";
            // 
            // lbAzul
            // 
            this.lbAzul.AutoSize = true;
            this.lbAzul.Location = new System.Drawing.Point(168, 99);
            this.lbAzul.Name = "lbAzul";
            this.lbAzul.Size = new System.Drawing.Size(27, 13);
            this.lbAzul.TabIndex = 115;
            this.lbAzul.Text = "Azul";
            // 
            // tbMatiz
            // 
            this.tbMatiz.Location = new System.Drawing.Point(93, 20);
            this.tbMatiz.Name = "tbMatiz";
            this.tbMatiz.Size = new System.Drawing.Size(69, 20);
            this.tbMatiz.TabIndex = 116;
            // 
            // tbSat
            // 
            this.tbSat.Location = new System.Drawing.Point(93, 58);
            this.tbSat.Name = "tbSat";
            this.tbSat.Size = new System.Drawing.Size(69, 20);
            this.tbSat.TabIndex = 117;
            // 
            // tbLum
            // 
            this.tbLum.Location = new System.Drawing.Point(93, 93);
            this.tbLum.Name = "tbLum";
            this.tbLum.Size = new System.Drawing.Size(69, 20);
            this.tbLum.TabIndex = 118;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(225, 20);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(69, 20);
            this.tbRed.TabIndex = 119;
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(225, 58);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(69, 20);
            this.tbGreen.TabIndex = 120;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(225, 93);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(69, 20);
            this.tbBlue.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "C";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(404, 24);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(69, 20);
            this.tbC.TabIndex = 125;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(404, 53);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(69, 20);
            this.tbM.TabIndex = 126;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(404, 86);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(69, 20);
            this.tbY.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Aumentar/reduzir o brilho da imagem (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "Mudar a Matiz ( ° ) :";
            // 
            // trackBarBrilho
            // 
            this.trackBarBrilho.LargeChange = 20;
            this.trackBarBrilho.Location = new System.Drawing.Point(519, 57);
            this.trackBarBrilho.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBrilho.Maximum = 200;
            this.trackBarBrilho.Name = "trackBarBrilho";
            this.trackBarBrilho.Size = new System.Drawing.Size(224, 45);
            this.trackBarBrilho.SmallChange = 10;
            this.trackBarBrilho.TabIndex = 132;
            this.trackBarBrilho.Value = 100;
            this.trackBarBrilho.Scroll += new System.EventHandler(this.trackBarBrilho_Scroll);
            // 
            // tbBrilho
            // 
            this.tbBrilho.Location = new System.Drawing.Point(716, 26);
            this.tbBrilho.Margin = new System.Windows.Forms.Padding(2);
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.ReadOnly = true;
            this.tbBrilho.Size = new System.Drawing.Size(48, 20);
            this.tbBrilho.TabIndex = 134;
            this.tbBrilho.TextChanged += new System.EventHandler(this.tbBrilho_TextChanged);
            // 
            // nUDmatiz
            // 
            this.nUDmatiz.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDmatiz.Location = new System.Drawing.Point(802, 59);
            this.nUDmatiz.Margin = new System.Windows.Forms.Padding(2);
            this.nUDmatiz.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nUDmatiz.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nUDmatiz.Name = "nUDmatiz";
            this.nUDmatiz.Size = new System.Drawing.Size(90, 20);
            this.nUDmatiz.TabIndex = 135;
            this.nUDmatiz.ValueChanged += new System.EventHandler(this.nUDmatiz_ValueChanged);
            // 
            // btnMiniatura
            // 
            this.btnMiniatura.Location = new System.Drawing.Point(1083, 40);
            this.btnMiniatura.Name = "btnMiniatura";
            this.btnMiniatura.Size = new System.Drawing.Size(120, 23);
            this.btnMiniatura.TabIndex = 134;
            this.btnMiniatura.Text = "Miniatura";
            this.btnMiniatura.UseVisualStyleBackColor = true;
            this.btnMiniatura.Click += new System.EventHandler(this.btnMiniatura_Click);
            // 
            // nUDMinHue
            // 
            this.nUDMinHue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDMinHue.Location = new System.Drawing.Point(975, 69);
            this.nUDMinHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nUDMinHue.Name = "nUDMinHue";
            this.nUDMinHue.Size = new System.Drawing.Size(101, 20);
            this.nUDMinHue.TabIndex = 136;
            // 
            // nUDMaxHue
            // 
            this.nUDMaxHue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDMaxHue.Location = new System.Drawing.Point(1082, 69);
            this.nUDMaxHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nUDMaxHue.Name = "nUDMaxHue";
            this.nUDMaxHue.Size = new System.Drawing.Size(121, 20);
            this.nUDMaxHue.TabIndex = 137;
            // 
            // btnFiltrarMatiz_Click
            // 
            this.btnFiltrarMatiz_Click.Location = new System.Drawing.Point(1019, 93);
            this.btnFiltrarMatiz_Click.Name = "btnFiltrarMatiz_Click";
            this.btnFiltrarMatiz_Click.Size = new System.Drawing.Size(132, 23);
            this.btnFiltrarMatiz_Click.TabIndex = 138;
            this.btnFiltrarMatiz_Click.Text = "Filtrar";
            this.btnFiltrarMatiz_Click.UseVisualStyleBackColor = true;
            this.btnFiltrarMatiz_Click.Click += new System.EventHandler(this.btnFiltrarMatiz_Click_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(972, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 139;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1176, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 140;
            this.label8.Text = "Max";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFiltrarMatiz_Click);
            this.Controls.Add(this.nUDMaxHue);
            this.Controls.Add(this.nUDMinHue);
            this.Controls.Add(this.nUDmatiz);
            this.Controls.Add(this.tbBrilho);
            this.Controls.Add(this.btnMiniatura);
            this.Controls.Add(this.trackBarBrilho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.tbLum);
            this.Controls.Add(this.tbSat);
            this.Controls.Add(this.tbMatiz);
            this.Controls.Add(this.lbAzul);
            this.Controls.Add(this.lbVerde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLuminancia);
            this.Controls.Add(this.lbSaturacao);
            this.Controls.Add(this.lbMatiz);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmatiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Label lbMatiz;
        private System.Windows.Forms.Label lbSaturacao;
        private System.Windows.Forms.Label lbLuminancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVerde;
        private System.Windows.Forms.Label lbAzul;
        private System.Windows.Forms.TextBox tbMatiz;
        private System.Windows.Forms.TextBox tbSat;
        private System.Windows.Forms.TextBox tbLum;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarBrilho;

        private System.Windows.Forms.TextBox tbBrilho;
        private System.Windows.Forms.NumericUpDown nUDmatiz;
        private System.Windows.Forms.Button btnMiniatura;
        private System.Windows.Forms.NumericUpDown nUDMinHue;
        private System.Windows.Forms.NumericUpDown nUDMaxHue;
        private System.Windows.Forms.Button btnFiltrarMatiz_Click;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

