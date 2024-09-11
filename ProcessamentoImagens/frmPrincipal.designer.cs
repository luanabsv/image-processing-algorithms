﻿namespace ProcessamentoImagens
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
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            this.btnEspelhoHorizontal = new System.Windows.Forms.Button();
            this.btnEspelhoVertical = new System.Windows.Forms.Button();
            this.btnInverterRB = new System.Windows.Forms.Button();
            this.btnEspelhoDiagonalPrincial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(7, 7);
            this.pictBoxImg1.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(800, 615);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(815, 7);
            this.pictBoxImg2.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(800, 615);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(7, 630);
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
            this.btnLimpar.Location = new System.Drawing.Point(149, 630);
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
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(292, 630);
            this.btnLuminanciaSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(277, 28);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância sem DMA";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(292, 666);
            this.btnLuminanciaComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(277, 28);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Location = new System.Drawing.Point(577, 666);
            this.btnNegativoComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(277, 28);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnNegativoSemDMA
            // 
            this.btnNegativoSemDMA.Location = new System.Drawing.Point(577, 630);
            this.btnNegativoSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            this.btnNegativoSemDMA.Size = new System.Drawing.Size(277, 28);
            this.btnNegativoSemDMA.TabIndex = 110;
            this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // btnEspelhoHorizontal
            // 
            this.btnEspelhoHorizontal.Location = new System.Drawing.Point(149, 666);
            this.btnEspelhoHorizontal.Name = "btnEspelhoHorizontal";
            this.btnEspelhoHorizontal.Size = new System.Drawing.Size(132, 28);
            this.btnEspelhoHorizontal.TabIndex = 112;
            this.btnEspelhoHorizontal.Text = "Espelho Horizontal";
            this.btnEspelhoHorizontal.UseVisualStyleBackColor = true;
            this.btnEspelhoHorizontal.Click += new System.EventHandler(this.btnEspelhoHorizontal_Click);
            // 
            // btnEspelhoVertical
            // 
            this.btnEspelhoVertical.Location = new System.Drawing.Point(7, 666);
            this.btnEspelhoVertical.Name = "btnEspelhoVertical";
            this.btnEspelhoVertical.Size = new System.Drawing.Size(135, 28);
            this.btnEspelhoVertical.TabIndex = 113;
            this.btnEspelhoVertical.Text = "Espelho Vertical";
            this.btnEspelhoVertical.UseVisualStyleBackColor = true;
            this.btnEspelhoVertical.Click += new System.EventHandler(this.btnEspelhoVertical_Click);
            // 
            // btnInverterRB
            // 
            this.btnInverterRB.Location = new System.Drawing.Point(7, 700);
            this.btnInverterRB.Name = "btnInverterRB";
            this.btnInverterRB.Size = new System.Drawing.Size(135, 26);
            this.btnInverterRB.TabIndex = 114;
            this.btnInverterRB.Text = "Inverter R e B";
            this.btnInverterRB.UseVisualStyleBackColor = true;
            this.btnInverterRB.Click += new System.EventHandler(this.btnInverterRB_Click);
            // 
            // btnEspelhoDiagonalPrincial
            // 
            this.btnEspelhoDiagonalPrincial.Location = new System.Drawing.Point(149, 700);
            this.btnEspelhoDiagonalPrincial.Name = "btnEspelhoDiagonalPrincial";
            this.btnEspelhoDiagonalPrincial.Size = new System.Drawing.Size(132, 26);
            this.btnEspelhoDiagonalPrincial.TabIndex = 115;
            this.btnEspelhoDiagonalPrincial.Text = "Espelho Diagonal Principal";
            this.btnEspelhoDiagonalPrincial.UseVisualStyleBackColor = true;
            this.btnEspelhoDiagonalPrincial.Click += new System.EventHandler(this.btnEspelhoDiagonalPrincipal);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 748);
            this.Controls.Add(this.btnEspelhoDiagonalPrincial);
            this.Controls.Add(this.btnInverterRB);
            this.Controls.Add(this.btnEspelhoVertical);
            this.Controls.Add(this.btnEspelhoHorizontal);
            this.Controls.Add(this.btnNegativoComDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnLuminanciaComDMA);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnEspelhoHorizontal;
        private System.Windows.Forms.Button btnEspelhoVertical;
        private System.Windows.Forms.Button btnInverterRB;
        private System.Windows.Forms.Button btnEspelhoDiagonalPrincial;
    }
}

