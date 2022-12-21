using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int [] numeros = new int[10];
        void muestraNum(ref string texto, ref int i, ref int numero)
        {
            if (i < 9)
                texto = texto + numero + ", ";
            else
                texto = texto + numero + ".";
        }

        void creaVector(ref string texto)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = int.Parse(Interaction.InputBox("Numero: "));
                numeros[i] = numero;
                muestraNum(ref texto, ref i, ref numero);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "Números: ";
            creaVector(ref texto);
            MessageBox.Show(texto);
        }
    }
}
