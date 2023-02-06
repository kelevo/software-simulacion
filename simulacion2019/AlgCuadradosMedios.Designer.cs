namespace simulacion2019
{
    partial class AlgCuadradosMedios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgCuadradosMedios));
            this.labelSemilla = new System.Windows.Forms.Label();
            this.txtIngreseSemilla = new System.Windows.Forms.TextBox();
            this.labelNumGene = new System.Windows.Forms.Label();
            this.txtNumerosGenerar = new System.Windows.Forms.TextBox();
            this.btnGenerarCuadradosMedios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.textBoxmostrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSemilla
            // 
            this.labelSemilla.AutoSize = true;
            this.labelSemilla.BackColor = System.Drawing.Color.Transparent;
            this.labelSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemilla.Location = new System.Drawing.Point(14, 22);
            this.labelSemilla.Name = "labelSemilla";
            this.labelSemilla.Size = new System.Drawing.Size(135, 16);
            this.labelSemilla.TabIndex = 0;
            this.labelSemilla.Text = "Ingrese la semilla:";
            // 
            // txtIngreseSemilla
            // 
            this.txtIngreseSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseSemilla.Location = new System.Drawing.Point(269, 19);
            this.txtIngreseSemilla.Name = "txtIngreseSemilla";
            this.txtIngreseSemilla.Size = new System.Drawing.Size(168, 21);
            this.txtIngreseSemilla.TabIndex = 1;
            // 
            // labelNumGene
            // 
            this.labelNumGene.AutoSize = true;
            this.labelNumGene.BackColor = System.Drawing.Color.Transparent;
            this.labelNumGene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumGene.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumGene.Location = new System.Drawing.Point(14, 49);
            this.labelNumGene.Name = "labelNumGene";
            this.labelNumGene.Size = new System.Drawing.Size(249, 16);
            this.labelNumGene.TabIndex = 2;
            this.labelNumGene.Text = "¿Cuantos números quiere generar?";
            // 
            // txtNumerosGenerar
            // 
            this.txtNumerosGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerosGenerar.Location = new System.Drawing.Point(269, 46);
            this.txtNumerosGenerar.Name = "txtNumerosGenerar";
            this.txtNumerosGenerar.Size = new System.Drawing.Size(168, 21);
            this.txtNumerosGenerar.TabIndex = 3;
            // 
            // btnGenerarCuadradosMedios
            // 
            this.btnGenerarCuadradosMedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCuadradosMedios.Location = new System.Drawing.Point(299, 79);
            this.btnGenerarCuadradosMedios.Name = "btnGenerarCuadradosMedios";
            this.btnGenerarCuadradosMedios.Size = new System.Drawing.Size(112, 28);
            this.btnGenerarCuadradosMedios.TabIndex = 6;
            this.btnGenerarCuadradosMedios.Text = "Generar";
            this.btnGenerarCuadradosMedios.UseVisualStyleBackColor = true;
            this.btnGenerarCuadradosMedios.Click += new System.EventHandler(this.BtnGenerarCuadradosMedios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(315, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 28);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(315, 132);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 28);
            this.btnClean.TabIndex = 9;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // textBoxmostrar
            // 
            this.textBoxmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmostrar.Location = new System.Drawing.Point(17, 79);
            this.textBoxmostrar.Multiline = true;
            this.textBoxmostrar.Name = "textBoxmostrar";
            this.textBoxmostrar.Size = new System.Drawing.Size(246, 128);
            this.textBoxmostrar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patrick Jhonatan Hernandez Blanco";
            // 
            // AlgCuadradosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmostrar);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarCuadradosMedios);
            this.Controls.Add(this.txtNumerosGenerar);
            this.Controls.Add(this.labelNumGene);
            this.Controls.Add(this.txtIngreseSemilla);
            this.Controls.Add(this.labelSemilla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlgCuadradosMedios";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALGORITMO CUADRADOS MEDIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemilla;
        private System.Windows.Forms.TextBox txtIngreseSemilla;
        private System.Windows.Forms.Label labelNumGene;
        private System.Windows.Forms.TextBox txtNumerosGenerar;
        private System.Windows.Forms.Button btnGenerarCuadradosMedios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox textBoxmostrar;
        private System.Windows.Forms.Label label1;
    }
}