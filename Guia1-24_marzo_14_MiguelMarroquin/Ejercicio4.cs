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

namespace Guia1_24_marzo_14_MiguelMarroquin
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] vel = new int[2, 2];
            int[,] ve2 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Ingrese el valor para la matriz 1, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz 1");

                    if (!int.TryParse(entrada, out vel[i, j]))
                    {
                        MessageBox.Show("Debe ingresar un número válido.");
                        return;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Ingrese el valor para la matriz 2, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz 2");

                    if (!int.TryParse(entrada, out ve2[i, j]))
                    {
                        MessageBox.Show("Debe ingresar un número válido.");
                        return;
                    }
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Valor1", "Valor 1");
            dataGridView1.Columns.Add("Valor2", "Valor 2");
            dataGridView1.Columns.Add("Multiplicacion", "Multiplicación");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int mult = vel[i, j] * ve2[i, j];
                    dataGridView1.Rows.Add(vel[i, j], ve2[i, j], mult);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] vel = new int[2, 2];
            int[,] ve2 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Ingrese el valor para la matriz 1, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz 1");

                    if (!int.TryParse(entrada, out vel[i, j]))
                    {
                        MessageBox.Show("Debe ingresar un número válido.");
                        return;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada =Interaction.InputBox(
                        $"Ingrese el valor para la matriz 2, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz 2");

                    if (!int.TryParse(entrada, out ve2[i, j]))
                    {
                        MessageBox.Show("Debe ingresar un número válido.");
                        return;
                    }
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Valor1", "Valor 1");
            dataGridView1.Columns.Add("Valor2", "Valor 2");
            dataGridView1.Columns.Add("Division", "División");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (ve2[i, j] != 0)
                    {
                        float div = (float)vel[i, j] / ve2[i, j];
                        dataGridView1.Rows.Add(vel[i, j], ve2[i, j], div);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(vel[i, j], ve2[i, j], "Error (División por 0)");
                    }
                }
            }
        }
    }
    }

