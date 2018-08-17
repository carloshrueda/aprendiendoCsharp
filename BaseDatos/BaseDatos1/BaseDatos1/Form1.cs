using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BaseDatos1
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
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
            conexion.Dispose();
            conexion = null;
        }
    }
}
