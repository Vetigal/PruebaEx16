namespace PruebaEx16
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
            this.button_text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(73, 99);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(131, 23);
            this.button_text.TabIndex = 0;
            this.button_text.Text = "Clica\'m";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 289);
            this.Controls.Add(this.button_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_text;
    }
}

