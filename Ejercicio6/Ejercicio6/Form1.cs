using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_operaciones.Items.Add("Numeros Primos");
            comboBox_operaciones.Items.Add("Numeros Perfectos");
            comboBox_operaciones.Items.Add("Serie fibonacci");
            
        }

        private void btn_genenar_Click_1(object sender, EventArgs e)
        {
            listBox_numeros.Items.Clear();
            int numero = Convert.ToInt32(txt_numero.Text);
            string seleccionador = comboBox_operaciones.Text;
            if (seleccionador == "Numeros Primos")
            {
                int j = 0;
                int i = 0;
                while (i<numero)   
                {
                    if (Esprimo(j)== true)
                    {
                       listBox_numeros.Items.Add(j);
                       i++;
                    }
                    j++;
                }
            }
            if (seleccionador == "Numeros Perfectos")
            {
                int j = 1;
                int i = 0;
                long per;
                while (i < numero)
                {
                    if (Esprimo(j) == true)
                    {
                        per =(long)(Math.Pow(2,j-1)*(Math.Pow(2,j)-1));
                        listBox_numeros.Items.Add(per);
                        i++;
                    }
                    j++;
                }
               
            }

            if (seleccionador == "Serie fibonacci")
            {
                int[] arreglo = new int[numero];
                arreglo[0] = 0;
                arreglo[1] = 1;

                for (int i = 2; i < numero; i++)
                {
                    arreglo[i] = arreglo[i - 1] + arreglo[i - 2];
                    
                }
                for (int i = 0; i < numero; i++)
                {
                    listBox_numeros.Items.Add(arreglo[i]);
                }
            }
        }


        public static bool Esprimo(int num)
        {
            int i = 1;
            int contador = 0;
            while (i <= num)
            {
                if (num % i == 0)
                    contador++;
                i++;
            }
            if (contador > 2 || num == 0 || num == 1)
                return false;
            else
                return true;
        }
        
    }
}
