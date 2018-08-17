using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insert1
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
            string descri = textBox1.Text.Trim();
            string precio = textBox2.Text.Trim();

            if (descri == "")
            {
                MessageBox.Show("La descripción no puede ser vacía");
                return;
            }

            if (precio == "")
            {
                MessageBox.Show("El precio no puede ser vacío");
                return;
            }


            string cadena = "insert into articulos(descripcion,precio) values ('" + descri + "'," + precio + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente.");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();

            comando.Dispose();
            conexion.Dispose();
        }
    }
}
