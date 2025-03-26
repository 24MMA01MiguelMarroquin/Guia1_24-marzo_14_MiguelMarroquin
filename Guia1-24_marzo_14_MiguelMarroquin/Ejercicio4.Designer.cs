namespace Guia1_24_marzo_14_MiguelMarroquin
{
    partial class Ejercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Numeros = new DataGridViewTextBoxColumn();
            Numero2 = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 49);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 9;
            label1.Text = "  MATRICES";
            // 
            // button1
            // 
            button1.Location = new Point(434, 221);
            button1.Name = "button1";
            button1.Size = new Size(139, 96);
            button1.TabIndex = 8;
            button1.Text = "Multiplicacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numeros, Numero2, Total });
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 355);
            dataGridView1.TabIndex = 7;
            // 
            // Numeros
            // 
            Numeros.HeaderText = "numero1";
            Numeros.Name = "Numeros";
            // 
            // Numero2
            // 
            Numero2.HeaderText = "numero2";
            Numero2.Name = "Numero2";
            // 
            // Total
            // 
            Total.HeaderText = "total";
            Total.Name = "Total";
            // 
            // button2
            // 
            button2.Location = new Point(617, 221);
            button2.Name = "button2";
            button2.Size = new Size(130, 96);
            button2.TabIndex = 10;
            button2.Text = "Division";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 153);
            label2.Name = "label2";
            label2.Size = new Size(297, 25);
            label2.TabIndex = 11;
            label2.Text = "QUE ES LO QUE DESEA REALIZAR";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Ejercicio4";
            Text = "Ejercicio4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numeros;
        private DataGridViewTextBoxColumn Numero2;
        private DataGridViewTextBoxColumn Total;
        private Button button2;
        private Label label2;
    }
}