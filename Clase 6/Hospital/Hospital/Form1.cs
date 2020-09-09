using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Hospital
{
    public partial class Form1 : Form
    {

        private Medico miMedico;

        public Medico MiMedico
        {
            get { return miMedico; }
            set { miMedico = value; }
        }


        public Form1()
        {
            InitializeComponent();
            this.tbNombre.Text = "Pepe";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbNombre.Text = "Quimey";
            this.tbApellido.Text = "Espinosa";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
