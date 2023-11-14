using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // JULIAN PEREZ PEREÑA DAW 2023 
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; // defino 'o' como ordinario por defecto
            int numPalabras = 0;
            double coste;
            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            if (cbUrgente.Checked)// Si el telegrama es urgente
                tipoTelegrama = 'u';// Define 'u' como urgente
            // Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ', '.', ',', ':', ';').Length;

            if (tipoTelegrama == 'o') // Si el telegrama es ordinario
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
            // Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;

            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
        }
    }
}
