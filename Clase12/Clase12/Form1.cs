using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exception_Click(object sender, EventArgs e)
        {
            try
            {
                throw new QuimeyException("Esto funciona");
            }
            catch (QuimeyException miExcep)
            {
                MessageBox.Show(miExcep.Message);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
