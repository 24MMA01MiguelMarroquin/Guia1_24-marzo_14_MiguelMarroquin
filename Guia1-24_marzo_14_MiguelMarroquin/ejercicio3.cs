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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guia1_24_marzo_14_MiguelMarroquin
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                vector1[i] = int.Parse(Interaction.InputBox("Ingrese el valor para el vector 1, posición " + (i + 1), "Entrada Vector 1"));
            }
            for (int i = 0; i < 5; i++)
            {
                vector2[i] = int.Parse(Interaction.InputBox("Ingrese el valor para el vector 2, posición " + (i + 1), "Entrada Vector 2")); 
            }
            dataGridView1.Rows.Clear();


            for (int i = 0; i < 5; i++)
            {
                int suma = vector1[i] + vector2[i];

                dataGridView1.Rows.Add(vector1[i], vector2[i], suma);
            }

        }
    }
}
