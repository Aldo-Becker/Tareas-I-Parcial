namespace Tareas_I_Parcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.NúmeroTextBox = new System.Windows.Forms.TextBox();
            this.VerificarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // NúmeroTextBox
            // 
            this.NúmeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NúmeroTextBox.Location = new System.Drawing.Point(215, 94);
            this.NúmeroTextBox.Name = "NúmeroTextBox";
            this.NúmeroTextBox.Size = new System.Drawing.Size(116, 26);
            this.NúmeroTextBox.TabIndex = 1;
            // 
            // VerificarButton
            // 
            this.VerificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificarButton.Location = new System.Drawing.Point(214, 148);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(116, 45);
            this.VerificarButton.TabIndex = 2;
            this.VerificarButton.Text = "Verificar";
            this.VerificarButton.UseVisualStyleBackColor = true;
            this.VerificarButton.Click += new System.EventHandler(this.VerificarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Un Número Para Identificar Si es Par o Impar y Si es Positivo o Negativo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VerificarButton);
            this.Controls.Add(this.NúmeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NúmeroTextBox;
        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Label label2;
    }
}

