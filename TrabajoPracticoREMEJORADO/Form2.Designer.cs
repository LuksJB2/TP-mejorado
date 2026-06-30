namespace TrabajoPracticoREMEJORADO
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbCategoria1 = new System.Windows.Forms.TextBox();
            this.tbCategoria2 = new System.Windows.Forms.TextBox();
            this.tbCategoria3 = new System.Windows.Forms.TextBox();
            this.tbCategoria4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIA 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CATEGORIA 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CATEGORIA 4:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(64, 233);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbCategoria1
            // 
            this.tbCategoria1.Location = new System.Drawing.Point(207, 48);
            this.tbCategoria1.Name = "tbCategoria1";
            this.tbCategoria1.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria1.TabIndex = 6;
            // 
            // tbCategoria2
            // 
            this.tbCategoria2.Location = new System.Drawing.Point(207, 88);
            this.tbCategoria2.Name = "tbCategoria2";
            this.tbCategoria2.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria2.TabIndex = 7;
            // 
            // tbCategoria3
            // 
            this.tbCategoria3.Location = new System.Drawing.Point(207, 130);
            this.tbCategoria3.Name = "tbCategoria3";
            this.tbCategoria3.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria3.TabIndex = 8;
            // 
            // tbCategoria4
            // 
            this.tbCategoria4.Location = new System.Drawing.Point(207, 180);
            this.tbCategoria4.Name = "tbCategoria4";
            this.tbCategoria4.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria4.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 299);
            this.Controls.Add(this.tbCategoria4);
            this.Controls.Add(this.tbCategoria3);
            this.Controls.Add(this.tbCategoria2);
            this.Controls.Add(this.tbCategoria1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Iniciar Jornada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox tbCategoria1;
        public System.Windows.Forms.TextBox tbCategoria2;
        public System.Windows.Forms.TextBox tbCategoria3;
        public System.Windows.Forms.TextBox tbCategoria4;
    }
}