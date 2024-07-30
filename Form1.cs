using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(this.n1.Text);
            double n2 = double.Parse(this.n2.Text);

            double resultado = n1 + n2;

            Resultado.Text = resultado.ToString();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            n1.Clear();
            n2.Clear();

            Resultado.Text = "0";

            n1.Focus();

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
