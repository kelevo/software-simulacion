namespace simulacion2019
{
    partial class AlgProductoMedioModificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgProductoMedioModificado));
            this.labelValorK = new System.Windows.Forms.Label();
            this.labelValorSemilla = new System.Windows.Forms.Label();
            this.txtValork = new System.Windows.Forms.TextBox();
            this.txtValorSemilla = new System.Windows.Forms.TextBox();
            this.btnGenerarProductosMediosModificados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumerosGenerar3 = new System.Windows.Forms.TextBox();
            this.txtMostrarNumerosMedio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValorK
            // 
            this.labelValorK.AutoSize = true;
            this.labelValorK.BackColor = System.Drawing.Color.Transparent;
            this.labelValorK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelValorK.Location = new System.Drawing.Point(15, 13);
            this.labelValorK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorK.Name = "labelValorK";
            this.labelValorK.Size = new System.Drawing.Size(155, 16);
            this.labelValorK.TabIndex = 0;
            this.labelValorK.Text = "Ingrese el valor de K:";
            // 
            // labelValorSemilla
            // 
            this.labelValorSemilla.AutoSize = true;
            this.labelValorSemilla.BackColor = System.Drawing.Color.Transparent;
            this.labelValorSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorSemilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelValorSemilla.Location = new System.Drawing.Point(14, 48);
            this.labelValorSemilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorSemilla.Name = "labelValorSemilla";
            this.labelValorSemilla.Size = new System.Drawing.Size(133, 16);
            this.labelValorSemilla.TabIndex = 1;
            this.labelValorSemilla.Text = "Ingrese la Semilla";
            // 
            // txtValork
            // 
            this.txtValork.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValork.Location = new System.Drawing.Point(178, 7);
            this.txtValork.Margin = new System.Windows.Forms.Padding(4);
            this.txtValork.Name = "txtValork";
            this.txtValork.Size = new System.Drawing.Size(162, 22);
            this.txtValork.TabIndex = 2;
            this.txtValork.TextChanged += new System.EventHandler(this.txtValork_TextChanged);
            // 
            // txtValorSemilla
            // 
            this.txtValorSemilla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSemilla.Location = new System.Drawing.Point(178, 42);
            this.txtValorSemilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorSemilla.Name = "txtValorSemilla";
            this.txtValorSemilla.Size = new System.Drawing.Size(162, 22);
            this.txtValorSemilla.TabIndex = 3;
            // 
            // btnGenerarProductosMediosModificados
            // 
            this.btnGenerarProductosMediosModificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarProductosMediosModificados.Location = new System.Drawing.Point(188, 108);
            this.btnGenerarProductosMediosModificados.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarProductosMediosModificados.Name = "btnGenerarProductosMediosModificados";
            this.btnGenerarProductosMediosModificados.Size = new System.Drawing.Size(88, 22);
            this.btnGenerarProductosMediosModificados.TabIndex = 4;
            this.btnGenerarProductosMediosModificados.Text = "Generar";
            this.btnGenerarProductosMediosModificados.UseVisualStyleBackColor = true;
            this.btnGenerarProductosMediosModificados.Click += new System.EventHandler(this.btnGenerarProductosMediosModificados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿Cuantos numeros desea generar?";
            // 
            // txtNumerosGenerar3
            // 
            this.txtNumerosGenerar3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerosGenerar3.Location = new System.Drawing.Point(18, 108);
            this.txtNumerosGenerar3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumerosGenerar3.Name = "txtNumerosGenerar3";
            this.txtNumerosGenerar3.Size = new System.Drawing.Size(162, 22);
            this.txtNumerosGenerar3.TabIndex = 6;
            // 
            // txtMostrarNumerosMedio
            // 
            this.txtMostrarNumerosMedio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarNumerosMedio.Location = new System.Drawing.Point(360, 10);
            this.txtMostrarNumerosMedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMostrarNumerosMedio.Multiline = true;
            this.txtMostrarNumerosMedio.Name = "txtMostrarNumerosMedio";
            this.txtMostrarNumerosMedio.Size = new System.Drawing.Size(187, 179);
            this.txtMostrarNumerosMedio.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(18, 149);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 22);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(17, 179);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 22);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patrick Jhonatan Hernandez Blanco";
            // 
            // AlgProductoMedioModificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMostrarNumerosMedio);
            this.Controls.Add(this.txtNumerosGenerar3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarProductosMediosModificados);
            this.Controls.Add(this.txtValorSemilla);
            this.Controls.Add(this.txtValork);
            this.Controls.Add(this.labelValorSemilla);
            this.Controls.Add(this.labelValorK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlgProductoMedioModificado";
            this.Opacity = 0.85D;
            this.Text = "ALGORITMO PRODUCTO MEDIO MODIFICADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorK;
        private System.Windows.Forms.Label labelValorSemilla;
        private System.Windows.Forms.TextBox txtValork;
        private System.Windows.Forms.TextBox txtValorSemilla;
        private System.Windows.Forms.Button btnGenerarProductosMediosModificados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumerosGenerar3;
        private System.Windows.Forms.TextBox txtMostrarNumerosMedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
    }
}