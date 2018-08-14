using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_de_expresiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label2.Text = "";
            this.Text = "La expresión es: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pila pila1;
            pila1 = new Pila();
            string cadena = textBox1.Text;
            char cad;
            for (int f = 0; f < cadena.Length; f++)
            {
                cad = cadena.ElementAt(f);
                if (cad == '(' || cad == '[' || cad == '{')
                {
                    pila1.Insertar(cad);
                }
                else
                {
                    if (cad == ')')
                    {
                        if (pila1.Extraer() != '(')
                        {
                            Text = "La expresión es: Incorrecta";
                            label2.ForeColor= Color.Red;
                            label2.Text = "Incorrecta";
                            return;
                        }
                    }
                    else
                    {
                        if (cadena.ElementAt(f) == ']')
                        {
                            if (pila1.Extraer() != '[')
                            {
                                Text = "La expresión es: Incorrecta";
                                label2.ForeColor = Color.Red;
                                label2.Text = "Incorrecta";
                                return;
                            }
                        }
                        else
                        {
                            if (cadena.ElementAt(f) == '}')
                            {
                                if (pila1.Extraer() != '{')
                                {
                                    Text = "La expresión es: Incorrecta";
                                    label2.ForeColor = Color.Red;
                                    label2.Text = "Incorrecta";
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (pila1.Vacia())
            {
                Text = "La expresión es: Correcta";
                label2.ForeColor = Color.Blue;
                label2.Text = "Correcta";
            }
            else
            {

                Text = "La expresión es: Incorrecta";
                label2.ForeColor = Color.Red;
                label2.Text = "Incorrecta";
            }
        }
    }
}
