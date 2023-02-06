namespace simulacion2019
{
    partial class Mconvolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mconvolucion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuadradosMedios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listNumGene = new System.Windows.Forms.ListBox();
            this.listNumCentrales = new System.Windows.Forms.ListBox();
            this.listNumerosTotales = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generacion de numeros aleatorios";
            // 
            // btnCuadradosMedios
            // 
            this.btnCuadradosMedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadradosMedios.Location = new System.Drawing.Point(60, 48);
            this.btnCuadradosMedios.Name = "btnCuadradosMedios";
            this.btnCuadradosMedios.Size = new System.Drawing.Size(140, 23);
            this.btnCuadradosMedios.TabIndex = 1;
            this.btnCuadradosMedios.Text = "Cuadrados Medios";
            this.btnCuadradosMedios.UseVisualStyleBackColor = true;
            this.btnCuadradosMedios.Click += new System.EventHandler(this.btnCuadradosMedios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X =";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(58, 106);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(182, 20);
            this.txtX.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(165, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(356, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numeros generados";
            // 
            // listNumGene
            // 
            this.listNumGene.FormattingEnabled = true;
            this.listNumGene.Location = new System.Drawing.Point(297, 70);
            this.listNumGene.Name = "listNumGene";
            this.listNumGene.Size = new System.Drawing.Size(120, 160);
            this.listNumGene.TabIndex = 7;
            // 
            // listNumCentrales
            // 
            this.listNumCentrales.FormattingEnabled = true;
            this.listNumCentrales.Location = new System.Drawing.Point(446, 70);
            this.listNumCentrales.Name = "listNumCentrales";
            this.listNumCentrales.Size = new System.Drawing.Size(120, 160);
            this.listNumCentrales.TabIndex = 8;
            // 
            // listNumerosTotales
            // 
            this.listNumerosTotales.FormattingEnabled = true;
            this.listNumerosTotales.Location = new System.Drawing.Point(593, 70);
            this.listNumerosTotales.Name = "listNumerosTotales";
            this.listNumerosTotales.Size = new System.Drawing.Size(120, 160);
            this.listNumerosTotales.TabIndex = 9;
            // 
            // Mconvolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::simulacion2019.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(744, 253);
            this.Controls.Add(this.listNumerosTotales);
            this.Controls.Add(this.listNumCentrales);
            this.Controls.Add(this.listNumGene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCuadradosMedios);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mconvolucion";
            this.Opacity = 0.85D;
            this.Text = "METODO DE CONVOLUCIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuadradosMedios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listNumGene;
        private System.Windows.Forms.ListBox listNumCentrales;
        private System.Windows.Forms.ListBox listNumerosTotales;
    }
}