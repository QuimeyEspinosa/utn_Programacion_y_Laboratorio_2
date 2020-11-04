namespace FrmNumero
{
    partial class FormNumero
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Minimo = new System.Windows.Forms.Label();
            this.lbl_Maximo = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Minimo = new System.Windows.Forms.TextBox();
            this.txt_Maximo = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(246, 177);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Minimo
            // 
            this.lbl_Minimo.AutoSize = true;
            this.lbl_Minimo.Location = new System.Drawing.Point(28, 42);
            this.lbl_Minimo.Name = "lbl_Minimo";
            this.lbl_Minimo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Minimo.TabIndex = 1;
            this.lbl_Minimo.Text = "Mínimo";
            // 
            // lbl_Maximo
            // 
            this.lbl_Maximo.AutoSize = true;
            this.lbl_Maximo.Location = new System.Drawing.Point(134, 42);
            this.lbl_Maximo.Name = "lbl_Maximo";
            this.lbl_Maximo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Maximo.TabIndex = 2;
            this.lbl_Maximo.Text = "Máximo";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(239, 42);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_Valor.TabIndex = 3;
            this.lbl_Valor.Text = "Valor";
            // 
            // txt_Minimo
            // 
            this.txt_Minimo.Location = new System.Drawing.Point(31, 68);
            this.txt_Minimo.Name = "txt_Minimo";
            this.txt_Minimo.Size = new System.Drawing.Size(79, 20);
            this.txt_Minimo.TabIndex = 4;
            // 
            // txt_Maximo
            // 
            this.txt_Maximo.Location = new System.Drawing.Point(137, 68);
            this.txt_Maximo.Name = "txt_Maximo";
            this.txt_Maximo.Size = new System.Drawing.Size(79, 20);
            this.txt_Maximo.TabIndex = 5;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(242, 68);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(79, 20);
            this.txt_Valor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 222);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_Maximo);
            this.Controls.Add(this.txt_Minimo);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Maximo);
            this.Controls.Add(this.lbl_Minimo);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Minimo;
        private System.Windows.Forms.Label lbl_Maximo;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox txt_Minimo;
        private System.Windows.Forms.TextBox txt_Maximo;
        private System.Windows.Forms.TextBox txt_Valor;
    }
}

