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

namespace ModificarBd1
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            conexion.Open();

            string cod = textBox1.Text;
            string cadena = "select descripcion, precio from articulos where codigo=" + cod;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["descripcion"].ToString();
                textBox3.Text = registro["precio"].ToString();
                button2.Enabled = true;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string cod = textBox1.Text;
            string descri = textBox2.Text;
            string precio = textBox3.Text;

            string cadena = "update articulos set descripcion='" + descri + "', precio=" + precio + " where codigo=" + cod;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                conexion.Close();
                button1_Click(sender, e);
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");

            conexion.Close();

            button2.Enabled = false;
        }
    }
}
