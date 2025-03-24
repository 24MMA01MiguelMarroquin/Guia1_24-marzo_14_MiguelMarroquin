using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_14_MiguelMarroquin
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int cont2 = 1;
            do
            {
                int multi;
                multi = num1 * cont2;
                dataGridView1.Rows.Add(num1, cont2, multi);
                cont2++;
            } while (cont2 < 11);
            
        }
    }
}
