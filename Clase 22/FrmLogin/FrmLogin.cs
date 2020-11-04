using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Entidades;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        List<Persona> lista;
        SqlCommand miComando;
        SqlConnection miConexion;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lista = new List<Persona>();
            miConexion = new SqlConnection("Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno; Password=FraUtn");
            miComando = new SqlCommand();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                //miConexion.ConnectionString = "Data Source=[agasoluciones.dynamic-dns.net\\mssqlserver2]; Initial Catalog = [Mensajes]; User Id=Alumno; Password=FraUtn";
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                //Consulta
                miComando.Parameters.Clear();
                miComando.CommandText = "SELECT * FROM Personas where Nombre like @auxNombre and Apellido like @auxPass";
                miComando.Parameters.Add(new SqlParameter("@auxNombre", string.Concat('%', this.txt_User.Text, '%')));
                miComando.Parameters.Add(new SqlParameter("@auxPass", string.Concat('%', this.txt_Pass.Text, '%')));

                //Conectarse con el server
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }

                //Obtengo los datos y los envío a un SqlDataReader
                SqlDataReader lector = miComando.ExecuteReader();

                //DataTable auxDt = new DataTable();
                //auxDt.Load(lector);
                //DataView dv = new DataView(auxDt);

                while (lector.Read())
                {
                    lista.Add(new Persona(int.Parse(lector["Id"].ToString()),
                        lector["Nombre"].ToString(),
                        lector["Apellido"].ToString(),
                        int.Parse(lector["DNI"].ToString())
                        ));
                }

                //Muestro en un dgv
                dgv_Lista.DataSource = null;
                dgv_Lista.Rows.Clear();
                dgv_Lista.DataSource = lista;

                //Cierro la conexión
                miConexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
    }
}
