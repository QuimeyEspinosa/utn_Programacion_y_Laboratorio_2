namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.AccessibleDescription = "txtNombre";
            this.tbNombre.Location = new System.Drawing.Point(98, 31);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(147, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(25, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleDescription = "";
            this.btnAceptar.Location = new System.Drawing.Point(98, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(25, 60);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido";
            this.lbApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.AccessibleDescription = "tbApellido";
            this.tbApellido.Location = new System.Drawing.Point(98, 57);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(147, 20);
            this.tbApellido.TabIndex = 3;
            this.tbApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(25, 86);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(23, 13);
            this.lbDni.TabIndex = 6;
            this.lbDni.Text = "Dni";
            this.lbDni.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbDni
            // 
            this.tbDni.AccessibleDescription = "tbDni";
            this.tbDni.Location = new System.Drawing.Point(98, 83);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(147, 20);
            this.tbDni.TabIndex = 5;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Pediatria",
            "Traumatologia",
            "Ginecología",
            "Cardiología",
            "Urología"});
            this.cbEspecialidad.Location = new System.Drawing.Point(98, 109);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(147, 21);
            this.cbEspecialidad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Especialidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(310, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label1;
    }
}

