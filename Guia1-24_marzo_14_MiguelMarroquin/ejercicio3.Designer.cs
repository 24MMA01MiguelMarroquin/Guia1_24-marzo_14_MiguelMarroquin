namespace Guia1_24_marzo_14_MiguelMarroquin
{
    partial class ejercicio3
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Numeros = new DataGridViewTextBoxColumn();
            Numero2 = new DataGridViewTextBoxColumn();
            Suma = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numeros, Numero2, Suma });
            dataGridView1.Location = new Point(64, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 264);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(475, 203);
            button1.Name = "button1";
            button1.Size = new Size(137, 118);
            button1.TabIndex = 5;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // Suma
            // 
            Suma.HeaderText = "suma";
            Suma.Name = "Suma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 69);
            label1.Name = "label1";
            label1.Size = new Size(165, 64);
            label1.TabIndex = 6;
            label1.Text = "SUMA DE \r\nVECTORES";
            // 
            // ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 395);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ejercicio3";
            Text = "ejercicio3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Numeros;
        private DataGridViewTextBoxColumn Numero2;
        private DataGridViewTextBoxColumn Suma;
        private Label label1;
    }
}