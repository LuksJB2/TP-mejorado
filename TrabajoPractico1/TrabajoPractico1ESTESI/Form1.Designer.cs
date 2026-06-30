namespace TrabajoPractico1ESTESI
{
    partial class Form1
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPorcentajeClase = new System.Windows.Forms.Button();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.btnPrepagaporcentaje = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.rbPrepago = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLetrasP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumeroP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCat4 = new System.Windows.Forms.RadioButton();
            this.rbCat3 = new System.Windows.Forms.RadioButton();
            this.rbCat2 = new System.Windows.Forms.RadioButton();
            this.rbCat1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDiaHab = new System.Windows.Forms.CheckBox();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(77, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(122, 65);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Jornada";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPorcentajeClase
            // 
            this.btnPorcentajeClase.Location = new System.Drawing.Point(29, 385);
            this.btnPorcentajeClase.Name = "btnPorcentajeClase";
            this.btnPorcentajeClase.Size = new System.Drawing.Size(97, 48);
            this.btnPorcentajeClase.TabIndex = 1;
            this.btnPorcentajeClase.Text = "Porcentaje de Clases";
            this.btnPorcentajeClase.UseVisualStyleBackColor = true;
            this.btnPorcentajeClase.Click += new System.EventHandler(this.btnPorcentajeClase_Click);
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(366, 385);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(94, 48);
            this.btnRecaudacion.TabIndex = 2;
            this.btnRecaudacion.Text = "Total Recaudado";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnPrepagaporcentaje
            // 
            this.btnPrepagaporcentaje.Location = new System.Drawing.Point(202, 381);
            this.btnPrepagaporcentaje.Name = "btnPrepagaporcentaje";
            this.btnPrepagaporcentaje.Size = new System.Drawing.Size(102, 56);
            this.btnPrepagaporcentaje.TabIndex = 3;
            this.btnPrepagaporcentaje.Text = "Porcentaje tarjeta Prepaga";
            this.btnPrepagaporcentaje.UseVisualStyleBackColor = true;
            this.btnPrepagaporcentaje.Click += new System.EventHandler(this.btnPrepagaporcentaje_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(339, 104);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 58);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar vehiculos";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // rbPrepago
            // 
            this.rbPrepago.AutoSize = true;
            this.rbPrepago.Location = new System.Drawing.Point(17, 30);
            this.rbPrepago.Name = "rbPrepago";
            this.rbPrepago.Size = new System.Drawing.Size(81, 20);
            this.rbPrepago.TabIndex = 5;
            this.rbPrepago.TabStop = true;
            this.rbPrepago.Text = "Prepago";
            this.rbPrepago.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(153, 30);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(76, 20);
            this.rbEfectivo.TabIndex = 6;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPrepago);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLetrasP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNumeroP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbCat4);
            this.groupBox2.Controls.Add(this.rbCat3);
            this.groupBox2.Controls.Add(this.rbCat2);
            this.groupBox2.Controls.Add(this.rbCat1);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 180);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de vehiculo";
            // 
            // tbLetrasP
            // 
            this.tbLetrasP.Location = new System.Drawing.Point(78, 149);
            this.tbLetrasP.Name = "tbLetrasP";
            this.tbLetrasP.Size = new System.Drawing.Size(64, 22);
            this.tbLetrasP.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Letras:";
            // 
            // tbNumeroP
            // 
            this.tbNumeroP.Location = new System.Drawing.Point(78, 121);
            this.tbNumeroP.Name = "tbNumeroP";
            this.tbNumeroP.Size = new System.Drawing.Size(64, 22);
            this.tbNumeroP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patente:";
            // 
            // rbCat4
            // 
            this.rbCat4.AutoSize = true;
            this.rbCat4.Location = new System.Drawing.Point(126, 47);
            this.rbCat4.Name = "rbCat4";
            this.rbCat4.Size = new System.Drawing.Size(97, 20);
            this.rbCat4.TabIndex = 3;
            this.rbCat4.TabStop = true;
            this.rbCat4.Text = "Categoria 4";
            this.rbCat4.UseVisualStyleBackColor = true;
            // 
            // rbCat3
            // 
            this.rbCat3.AutoSize = true;
            this.rbCat3.Location = new System.Drawing.Point(17, 47);
            this.rbCat3.Name = "rbCat3";
            this.rbCat3.Size = new System.Drawing.Size(97, 20);
            this.rbCat3.TabIndex = 2;
            this.rbCat3.TabStop = true;
            this.rbCat3.Text = "Categoria 3";
            this.rbCat3.UseVisualStyleBackColor = true;
            // 
            // rbCat2
            // 
            this.rbCat2.AutoSize = true;
            this.rbCat2.Location = new System.Drawing.Point(126, 21);
            this.rbCat2.Name = "rbCat2";
            this.rbCat2.Size = new System.Drawing.Size(97, 20);
            this.rbCat2.TabIndex = 1;
            this.rbCat2.TabStop = true;
            this.rbCat2.Text = "Categoria 2";
            this.rbCat2.UseVisualStyleBackColor = true;
            // 
            // rbCat1
            // 
            this.rbCat1.AutoSize = true;
            this.rbCat1.Location = new System.Drawing.Point(17, 21);
            this.rbCat1.Name = "rbCat1";
            this.rbCat1.Size = new System.Drawing.Size(97, 20);
            this.rbCat1.TabIndex = 0;
            this.rbCat1.TabStop = true;
            this.rbCat1.Text = "Categoria 1";
            this.rbCat1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDiaHab);
            this.groupBox3.Controls.Add(this.nudMin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nudDia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nudMes);
            this.groupBox3.Controls.Add(this.nudHora);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(324, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 195);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horario";
            // 
            // cbDiaHab
            // 
            this.cbDiaHab.AutoSize = true;
            this.cbDiaHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiaHab.Location = new System.Drawing.Point(13, 158);
            this.cbDiaHab.Name = "cbDiaHab";
            this.cbDiaHab.Size = new System.Drawing.Size(108, 22);
            this.cbDiaHab.TabIndex = 8;
            this.cbDiaHab.Text = "Es dia Habil";
            this.cbDiaHab.UseVisualStyleBackColor = true;
            // 
            // nudMin
            // 
            this.nudMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMin.Location = new System.Drawing.Point(61, 116);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(69, 27);
            this.nudMin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia:";
            // 
            // nudDia
            // 
            this.nudDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDia.Location = new System.Drawing.Point(61, 49);
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(69, 27);
            this.nudDia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes:";
            // 
            // nudMes
            // 
            this.nudMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMes.Location = new System.Drawing.Point(61, 16);
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(69, 27);
            this.nudMes.TabIndex = 3;
            // 
            // nudHora
            // 
            this.nudHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHora.Location = new System.Drawing.Point(61, 88);
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(69, 27);
            this.nudHora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora:";
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(299, 13);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(146, 65);
            this.btnInformacion.TabIndex = 10;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 468);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnPrepagaporcentaje);
            this.Controls.Add(this.btnRecaudacion);
            this.Controls.Add(this.btnPorcentajeClase);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPorcentajeClase;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnPrepagaporcentaje;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton rbPrepago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCat4;
        private System.Windows.Forms.RadioButton rbCat3;
        private System.Windows.Forms.RadioButton rbCat2;
        private System.Windows.Forms.RadioButton rbCat1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDiaHab;
        private System.Windows.Forms.TextBox tbLetrasP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumeroP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInformacion;
    }
}