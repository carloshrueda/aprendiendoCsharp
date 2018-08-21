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

namespace PrbVisonIng
{
    public partial class ProyectoForms : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private StringBuilder strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDA;

        public ProyectoForms(SqlConnection con)
        {
            InitializeComponent();

            sqlCon = con;
        }

        private void ActualizarTabla()
        {
            dt = new DataTable();

            try
            {
                strCmd = new StringBuilder();
                strCmd.Append("select * ");
                strCmd.Append("from proyecto  ");
                strCmd.Append("order by nombre; ");

                sqlCmd = new SqlCommand(strCmd.ToString(), sqlCon);
                sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer llenar los datos de proyectos.\n\n" + ex);
                Application.Exit();
            }
        }

        private void ProyectoForms_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Close();
                    sqlCon = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=proyecto ; integrated security = true");
                    sqlCon.Open();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al establecer la conexión con la Base de datos.\n\n" + ex);
                Application.Exit();
            }
            ActualizarTabla();
        }
    }
}
