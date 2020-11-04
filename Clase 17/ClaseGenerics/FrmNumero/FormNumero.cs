using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseGenerica.Entidades;

namespace FrmNumero
{
    public partial class FormNumero : Form
    {
        public FormNumero()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int maximo = int.Parse(txt_Minimo.Text);
                int minimo = int.Parse(txt_Maximo.Text);
                int valor = int.Parse(txt_Valor.Text);

                if (Validaciones.ValidarValor(minimo, maximo, valor))
                {
                    MessageBox.Show("El valor ingresado es correcto", "Validado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El valor ingresado es inválidoo", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Validaciones.ValidaValor();
        }
    }
}
