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
    public partial class Form1 : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private StringBuilder strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDA;

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarTabla()
        {
            dt = new DataTable();
            

            strCmd = new StringBuilder();
            strCmd.Append("select P.nombre as PROYECTO, A.nombre as ACTIVIDAD, G.nombre as RESPONSABLE, R.rol as ROL ");
            strCmd.Append("from proyecto P  ");
            strCmd.Append("inner join actividad A on P.codigo = A.codproyecto  ");
            strCmd.Append("inner join actividad_persona AP on A.codigo = AP.codactividad ");
            strCmd.Append("inner join persona as G on G.codigo = AP.codpersona ");
            strCmd.Append("inner join rol R on G.codrol = R.codigo ");
            strCmd.Append("union ");
            strCmd.Append("select P.nombre as PROYECTO, ");
            strCmd.Append("    CASE ");
            strCmd.Append("    WHEN A.nombre != null ");
            strCmd.Append("     THEN A.nombre ");
            strCmd.Append("ELSE '' ");
            strCmd.Append("END AS ACTIVIDAD, ");
            strCmd.Append("G.nombre as RESPONSABLE, R.rol as ROL ");
            strCmd.Append("from proyecto P ");
            strCmd.Append("inner join persona as G on P.codigo = G.codproyecto ");
            strCmd.Append("inner join rol R on G.codrol = R.codigo ");
            strCmd.Append("left join actividad_persona AP on G.codigo = AP.codpersona ");
            strCmd.Append("left join actividad A on AP.codactividad = A.codigo ");
            strCmd.Append("where R.codigo = 1 ");
            strCmd.Append("order by P.nombre; ");

            sqlCmd = new SqlCommand(strCmd.ToString(), sqlCon);
            sqlDA = new SqlDataAdapter(sqlCmd);
            sqlDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection("server=CRUEDA-PC\\SQLEXPRESS ; database=proyecto ; integrated security = true");
                sqlCon.Open();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al establecer la conexión con la Base de datos.\n\n" + ex);
                Application.Exit();
            }
            ActualizarTabla();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlCon.State != ConnectionState.Closed)
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strfilter = textBox1.Text.Trim();
            if (strfilter != "")
            {
                strfilter = "PROYECTO='" + strfilter + "'";
                string sortOrder = "PROYECTO ASC";
                /*dataGridView1.DataSource = dt.Select(strfilter, sortOrder);
                dataGridView1.Refresh();*/
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = strfilter;

            }
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoForms pf = new ProyectoForms(sqlCon);
            pf.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string strfilter = textBox2.Text.Trim();
            if (strfilter != "")
            {
                strfilter = "RESPONSABLE= '" + strfilter + "'";
                string sortOrder = "PROYECTO ASC";
                /*dataGridView1.DataSource = dt.Select(strfilter, sortOrder);
                dataGridView1.Refresh();*/
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = strfilter;

            }
        }
    }
}
