namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblClas = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(7, 61);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(7, 114);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(14, 226);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(38, 20);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "IMC";
            // 
            // lblClas
            // 
            this.lblClas.AutoSize = true;
            this.lblClas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClas.Location = new System.Drawing.Point(12, 262);
            this.lblClas.Name = "lblClas";
            this.lblClas.Size = new System.Drawing.Size(0, 20);
            this.lblClas.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Calcule seu IMC";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(45, 175);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(143, 28);
            this.btn.TabIndex = 5;
            this.btn.Text = "CALCULAR";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbIMC
            // 
            this.txbIMC.Enabled = false;
            this.txbIMC.Location = new System.Drawing.Point(81, 228);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.Size = new System.Drawing.Size(107, 20);
            this.txbIMC.TabIndex = 8;
            this.txbIMC.TextChanged += new System.EventHandler(this.txbIMC_TextChanged);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(81, 63);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 9;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(81, 116);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 10;
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Location = new System.Drawing.Point(7, 273);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(0, 20);
            this.lblCondicao.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraIMC.Properties.Resources.Captura_de_tela_2023_10_30_192836;
            this.ClientSize = new System.Drawing.Size(225, 302);
            this.Controls.Add(this.lblCondicao);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblClas);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblClas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txbIMC;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblCondicao;
    }
}

