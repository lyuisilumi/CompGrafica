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

            this.trackBarMatiz = new System.Windows.Forms.TrackBar();
            this.btnMiniatura = new System.Windows.Forms.Button();
          
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmatiz)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(7, 157);
            this.pictBoxImg1.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(1607, 705);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            this.pictBoxImg1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxImg1_MouseMove);
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(1302, 29);
            this.btnAbrirImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(135, 28);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1302, 64);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 28);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(1445, 29);
            this.btnLuminanciaSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(160, 28);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // lbMatiz
            // 
            this.lbMatiz.AutoSize = true;
            this.lbMatiz.Location = new System.Drawing.Point(36, 35);
            this.lbMatiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatiz.Name = "lbMatiz";
            this.lbMatiz.Size = new System.Drawing.Size(38, 16);
            this.lbMatiz.TabIndex = 110;
            this.lbMatiz.Text = "Matiz";
            this.lbMatiz.Click += new System.EventHandler(this.lbMatiz_Click);
            // 
            // lbSaturacao
            // 
            this.lbSaturacao.AutoSize = true;
            this.lbSaturacao.Location = new System.Drawing.Point(36, 79);
            this.lbSaturacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaturacao.Name = "lbSaturacao";
            this.lbSaturacao.Size = new System.Drawing.Size(69, 16);
            this.lbSaturacao.TabIndex = 111;
            this.lbSaturacao.Text = "Saturação";
            // 
            // lbLuminancia
            // 
            this.lbLuminancia.AutoSize = true;
            this.lbLuminancia.Location = new System.Drawing.Point(36, 122);
            this.lbLuminancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLuminancia.Name = "lbLuminancia";
            this.lbLuminancia.Size = new System.Drawing.Size(75, 16);
            this.lbLuminancia.TabIndex = 112;
            this.lbLuminancia.Text = "Luminancia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Vermelho";
            // 
            // lbVerde
            // 
            this.lbVerde.AutoSize = true;
            this.lbVerde.Location = new System.Drawing.Point(224, 79);
            this.lbVerde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVerde.Name = "lbVerde";
            this.lbVerde.Size = new System.Drawing.Size(44, 16);
            this.lbVerde.TabIndex = 114;
            this.lbVerde.Text = "Verde";
            // 
            // lbAzul
            // 
            this.lbAzul.AutoSize = true;
            this.lbAzul.Location = new System.Drawing.Point(224, 122);
            this.lbAzul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAzul.Name = "lbAzul";
            this.lbAzul.Size = new System.Drawing.Size(32, 16);
            this.lbAzul.TabIndex = 115;
            this.lbAzul.Text = "Azul";
            // 
            // tbMatiz
            // 
            this.tbMatiz.Location = new System.Drawing.Point(124, 25);
            this.tbMatiz.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatiz.Name = "tbMatiz";
            this.tbMatiz.Size = new System.Drawing.Size(91, 22);
            this.tbMatiz.TabIndex = 116;
            // 
            // tbSat
            // 
            this.tbSat.Location = new System.Drawing.Point(124, 71);
            this.tbSat.Margin = new System.Windows.Forms.Padding(4);
            this.tbSat.Name = "tbSat";
            this.tbSat.Size = new System.Drawing.Size(91, 22);
            this.tbSat.TabIndex = 117;
            // 
            // tbLum
            // 
            this.tbLum.Location = new System.Drawing.Point(124, 114);
            this.tbLum.Margin = new System.Windows.Forms.Padding(4);
            this.tbLum.Name = "tbLum";
            this.tbLum.Size = new System.Drawing.Size(91, 22);
            this.tbLum.TabIndex = 118;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(300, 25);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(91, 22);
            this.tbRed.TabIndex = 119;
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(300, 71);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(91, 22);
            this.tbGreen.TabIndex = 120;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(300, 114);
            this.tbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(91, 22);
            this.tbBlue.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "C";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(538, 29);
            this.tbC.Margin = new System.Windows.Forms.Padding(4);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(91, 22);
            this.tbC.TabIndex = 125;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(538, 65);
            this.tbM.Margin = new System.Windows.Forms.Padding(4);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(91, 22);
            this.tbM.TabIndex = 126;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(538, 106);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(91, 22);
            this.tbY.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "Aumentar/reduzir o brilho da imagem (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1057, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 130;
            this.label6.Text = "Mudar a Matiz ( ° ) :";
            // 
            // trackBarBrilho
            // 
            this.trackBarBrilho.LargeChange = 20;
            this.trackBarBrilho.Location = new System.Drawing.Point(692, 70);
            this.trackBarBrilho.Maximum = 200;
            this.trackBarBrilho.Name = "trackBarBrilho";
            this.trackBarBrilho.Size = new System.Drawing.Size(298, 56);
            this.trackBarBrilho.SmallChange = 10;
            this.trackBarBrilho.TabIndex = 132;
            this.trackBarBrilho.Value = 100;
            this.trackBarBrilho.Scroll += new System.EventHandler(this.trackBarBrilho_Scroll);
            // 
            // tbBrilho
            // 
            this.tbBrilho.Location = new System.Drawing.Point(954, 32);
            this.tbBrilho.Name = "tbBrilho";
            this.tbBrilho.ReadOnly = true;
            this.tbBrilho.Size = new System.Drawing.Size(63, 22);
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
            this.nUDmatiz.Location = new System.Drawing.Point(1069, 73);
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
            this.nUDmatiz.Size = new System.Drawing.Size(120, 22);
            this.nUDmatiz.TabIndex = 135;
            this.nUDmatiz.ValueChanged += new System.EventHandler(this.nUDmatiz_ValueChanged);
            // 
            // button1
            // 
            this.btnMiniatura.Location = new System.Drawing.Point(1445, 65);
            this.btnMiniatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnMiniatura.Name = "btnMiniatura";
            this.btnMiniatura.Size = new System.Drawing.Size(160, 28);
            this.btnMiniatura.TabIndex = 134;
            this.btnMiniatura.Text = "Miniatura";
            this.btnMiniatura.UseVisualStyleBackColor = true;
            this.btnMiniatura.Click += new System.EventHandler(this.btnMiniatura_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 748);

            this.Controls.Add(this.nUDmatiz);
            this.Controls.Add(this.tbBrilho);

            this.Controls.Add(this.btnMiniatura);
            this.Controls.Add(this.trackBarMatiz);

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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmatiz)).EndInit();
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

        private System.Windows.Forms.TrackBar trackBarMatiz;
        private System.Windows.Forms.Button btnMiniatura;

    }
}

