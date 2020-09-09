using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormularioPersona
{
    public partial class Form1 : Form
    {
        int[] arrayNumeros;

        public Form1()
        {
            arrayNumeros = new int[10];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtNumero1.Text);
            int num2 = int.Parse(this.txtNumero2.Text);

            this.lbResultado.Text = (num1 + num2).ToString();
        }        
    }
}
