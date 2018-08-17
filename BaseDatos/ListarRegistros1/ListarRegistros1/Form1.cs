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

namespace ListarRegistros1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");
            conexion.Open();

            string cadena = "select codigo, descripcion, precio from articulos";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                textBox1.AppendText(registros["codigo"].ToString());
                textBox1.AppendText(" - ");
                textBox1.AppendText(registros["descripcion"].ToString());
                textBox1.AppendText(" - ");
                textBox1.AppendText(registros["precio"].ToString());
                textBox1.AppendText("\n");
            }

            conexion.Close();
        }
    }
}
