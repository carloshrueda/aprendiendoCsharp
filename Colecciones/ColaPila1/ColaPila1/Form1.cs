using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColaPila1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<int> pila1 = new Stack<int>();

            textBox1.AppendText("Insertamos tres elementos en la pila:10, 25 y 70\n");
            textBox1.AppendText("\n");

            pila1.Push(10);
            pila1.Push(25);
            pila1.Push(70);

            textBox1.AppendText("Cantidad de elementos en la pila:" + pila1.Count + "\n");
            textBox1.AppendText("Extraemos un elemento de la pila:" + pila1.Pop() + "\n");
            textBox1.AppendText("Cantidad de elementos en la pila:" + pila1.Count + "\n");


            Queue<string> cola1 = new Queue<string>();

            textBox1.AppendText("\n"); textBox1.AppendText("\n");
            textBox1.AppendText("Insertamos tres elementos en la cola:'ana', 'juan' y 'pedro'\n");
            textBox1.AppendText("\n");

            cola1.Enqueue("ana");
            cola1.Enqueue("juan");
            cola1.Enqueue("pedro");

            textBox1.AppendText("Cantidad de elementos en la cola:" + cola1.Count + "\n");
            textBox1.AppendText("Extraemos un elemento de la cola:" + cola1.Dequeue() + "\n");
            textBox1.AppendText("Cantidad de elementos en la cola:" + cola1.Count + "\n");
        }
    }
}
