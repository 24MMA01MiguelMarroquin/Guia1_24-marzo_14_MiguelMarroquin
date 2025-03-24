namespace Guia1_24_marzo_14_MiguelMarroquin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                //agregar los datos en el DatagridView
                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ejercicio1 ejercicio1 = new ejercicio1();
            ejercicio1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ejercicio2 ejercicio2 = new ejercicio2();
            ejercicio2.Show();
        }
    }
}
