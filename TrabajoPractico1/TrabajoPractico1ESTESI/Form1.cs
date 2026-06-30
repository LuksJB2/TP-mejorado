using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1ESTESI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        PuestoDeControl control;
        Valores valores = new Valores();
        Informacion informacion = new Informacion();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (valores.ShowDialog() == DialogResult.OK)
            {
                int pr1 = Convert.ToInt32(valores.tbCategoria1.Text);
                int pr2 = Convert.ToInt32(valores.tbCategoria2.Text);
                int pr3 = Convert.ToInt32(valores.tbCategoria3.Text);
                int pr4 = Convert.ToInt32(valores.tbCategoria4.Text);
                control = new PuestoDeControl(pr1, pr2, pr3, pr4);
            }
            valores.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool prepago = rbPrepago.Checked;

            int cat = 0;
            if (rbCat1.Checked)
            {
                cat = 1;
            }
            else if (rbCat2.Checked)
            {
                cat = 2;
            }
            else if (rbCat3.Checked)
            {
                cat = 3;
            }
            else if (rbCat4.Checked)
            {
                cat = 4;
            }

            int numeroP = Convert.ToInt32(tbNumeroP.Text);
            string letraP = tbLetrasP.Text;

            int m = (Convert.ToInt32(nudMes.Value));
            int d = Convert.ToInt32(nudDia.Value);
            int hr = Convert.ToInt32(nudHora.Value);
            int min = Convert.ToInt32(nudMin.Value);

            bool diaHab = cbDiaHab.Checked;

            string papelito = control.RegistrarPeaje(prepago, hr, cat, min, diaHab, d, m, letraP, numeroP);

            if (cat == 3 || cat == 4)
            {
                if (hr >= 23 && min >= 0 && hr <= 00 && min <= 30)
                {
                    if(diaHab == true)
                    {
                        MessageBox.Show($"Patente: {letraP}-{numeroP} \r\nHora: {hr}:{min} \r\nFecha: {m:00}|{d:00}");
                    }
                }
            }
            

            informacion.tbInformacion.Clear();
            informacion.tbInformacion.Text = $"{papelito}";
            informacion.ShowDialog();
            rbPrepago.Checked = false;
            rbEfectivo.Checked = false;
            rbCat1.Checked = false;
            rbCat2.Checked = false;
            rbCat3.Checked = false;
            rbCat4.Checked = false;
            tbNumeroP.Clear();
            tbLetrasP.Clear();
            nudDia.Value = 0;
            nudMes.Value = 0;
            nudHora.Value = 0;
            nudMin.Value = 0;

        }

        private void btnPorcentajeClase_Click(object sender, EventArgs e)
        {
            informacion.tbInformacion.Clear();
            informacion.tbInformacion.Text = "Porcentajes de clases:";
            double[] porcentaje = control.VerPorcentajePorCategoria();

            for (int i = 0; i < porcentaje.Length; i++)
            {
                double porc = porcentaje[i];
                informacion.tbInformacion.Text += $"Categoria {i}: %{porc}";
            }
            informacion.ShowDialog();
        }

        private void btnPrepagaporcentaje_Click(object sender, EventArgs e)
        {
            double porcentajePrepago = control.VerPorcentajePorSistemaPrepago();
            informacion.tbInformacion.Clear();
            informacion.tbInformacion.Text = $"Porcentaje pagos con prepago: {porcentajePrepago}";
            informacion.ShowDialog();
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            double recaudacion = control.VerRecaudacionTotal();
            informacion.tbInformacion.Clear();
            informacion.tbInformacion.Text = $"Monto total recaudado: {recaudacion}";
            informacion.ShowDialog();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Ticket[] historial= control.VerHistorial();
            informacion.tbInformacion.Clear();
            int cantidad = control.VerCantidadTickets();
            informacion.tbInformacion.Text = $"===Cantidad registrados : {cantidad}===\r\n";
            for (int i = 0; i < control.contadorTickets; i++)
            {
                string tickets = historial[i].TicketImpreso();
                informacion.tbInformacion.Text += $"\r\n*{tickets}\r\n";
            }
            informacion.ShowDialog();
        }
    }
}
