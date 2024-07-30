namespace ProjetoWindowsForms
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
            this.Somar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.n1txt = new System.Windows.Forms.TextBox();
            this.n2txt = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.resultadotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Somar
            // 
            this.Somar.Location = new System.Drawing.Point(283, 259);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(115, 35);
            this.Somar.TabIndex = 0;
            this.Somar.Text = "Somar";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(433, 259);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(125, 34);
            this.Limpar.TabIndex = 1;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(596, 259);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(121, 33);
            this.Fechar.TabIndex = 2;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(315, 52);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(362, 20);
            this.n1.TabIndex = 3;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(319, 114);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(358, 20);
            this.n2.TabIndex = 4;
            // 
            // n1txt
            // 
            this.n1txt.Location = new System.Drawing.Point(197, 52);
            this.n1txt.Name = "n1txt";
            this.n1txt.ReadOnly = true;
            this.n1txt.Size = new System.Drawing.Size(100, 20);
            this.n1txt.TabIndex = 5;
            this.n1txt.Text = "Número 1:";
            this.n1txt.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // n2txt
            // 
            this.n2txt.Location = new System.Drawing.Point(197, 114);
            this.n2txt.Name = "n2txt";
            this.n2txt.ReadOnly = true;
            this.n2txt.Size = new System.Drawing.Size(100, 20);
            this.n2txt.TabIndex = 6;
            this.n2txt.Text = "Número 2:";
            this.n2txt.TextChanged += new System.EventHandler(this.n2_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(439, 175);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(118, 36);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = "0";
            // 
            // resultadotxt
            // 
            this.resultadotxt.Location = new System.Drawing.Point(285, 177);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.ReadOnly = true;
            this.resultadotxt.Size = new System.Drawing.Size(87, 20);
            this.resultadotxt.TabIndex = 8;
            this.resultadotxt.Text = "Resultado:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(920, 409);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.n2txt);
            this.Controls.Add(this.n1txt);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Somar);
            this.Name = "Form1";
            this.Text = "asd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox n1txt;
        private System.Windows.Forms.TextBox n2txt;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox resultadotxt;
    }
}

