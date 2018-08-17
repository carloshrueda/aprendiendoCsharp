using System;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ConsultarRegistro1
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");

        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblDescripcion.Text = "...";
            lblPrecio.Text = "...";
            btnBorrar.Enabled = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=base1 ; integrated security = true"))
                {
                    conexion.Open();

                    string cod = txtCodigo.Text.Trim();

                    string cadena = "select descripcion, precio from articulos where codigo=" + cod;

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        lblDescripcion.Text = registro["descripcion"].ToString();
                        lblPrecio.Text = registro["precio"].ToString();
                        btnBorrar.Enabled = true;
                    }
                    else
                        MessageBox.Show("No existe un artículo con el código ingresado");

                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string cod = txtCodigo.Text.Trim();

            string cadena = "delete from articulos where codigo=" + cod;
            SqlCommand comando = new SqlCommand(cadena, Conexion);

            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                lblDescripcion.Text = "...";
                lblPrecio.Text = "...";
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");

            Conexion.Close();

            btnBorrar.Enabled = false;
        }

        private void TxtCodigo_Enter(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
        }
    }
}
