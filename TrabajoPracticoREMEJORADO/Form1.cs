using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoMEJORADO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TrabajoPracticoREMEJORADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PuestoControl puestoControl;
        Form2 fjornada = new Form2();
        Form3 finfo = new Form3();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciarJornada_Click(object sender, EventArgs e)
        {

            if (fjornada.ShowDialog() == DialogResult.OK)
            {
                double pr1 = Convert.ToDouble(fjornada.tbCategoria1.Text);
                double pr2 = Convert.ToDouble(fjornada.tbCategoria2.Text);
                double pr3 = Convert.ToDouble(fjornada.tbCategoria3.Text);
                double pr4 = Convert.ToDouble(fjornada.tbCategoria4.Text);
                puestoControl = new PuestoControl(pr1, pr2, pr3, pr4);
            }
            fjornada.Close();
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            if (puestoControl == null)
            {
                MessageBox.Show("Debe iniciar la jornada y cargar los precios primero.");
                return;
            }

            bool esPrep = rbPrepago.Checked;
            int cat = 0;


            if (rbCat1.Checked)
            {
                cat = 1;
            }
            if (rbCat2.Checked)
            {
                cat = 2;
            }
            if (rbCat3.Checked)
            {
                cat = 3;
            }
            if (rbCat4.Checked)
            {
                cat = 4;
            }
            if (cat == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            if (tbNumeroP.Text == "")
            {
                MessageBox.Show("Debe ingresar el número de la patente.");
                return;
            }

            int numeroP = Convert.ToInt32(tbNumeroP.Text); 

            if (tbLetrasP.Text == "")
            {
                MessageBox.Show("Debe ingresar las letras de la patente.");
                return;
            }

            string letraP = tbLetrasP.Text;                


            int m = (Convert.ToInt32(nudMes.Value)); 
            int d = Convert.ToInt32(nudDia.Value);

            int hora = (int)nudHora.Value; 
            int minutos = (int)nudMin.Value;
            int hr = hora * 100 + minutos;

            bool esHab = cbDiaHabil.Checked;

            Ticket ticket = puestoControl.RegistrarPeaje(hr, cat, esHab, esPrep);
            if (cat == 3 || cat == 4)
            {
                if (hr >= 2300 && hr <= 0030)
                {
                    if (esHab == true)
                    {
                        MessageBox.Show($"Patente: {letraP}-{numeroP} \r\nHora: {hr}:{minutos} \r\nFecha: {m:00}|{d:00}");
                    }
                }
            }
            finfo.tbInformacion.Clear();
            finfo.tbInformacion.Text = $"{ticket.VerInformacion()}";
            finfo.ShowDialog();
            rbPrepago.Checked = false;
            rbEfectivo.Checked = false;
            rbCat1.Checked = false;
            rbCat2.Checked = false;
            rbCat3.Checked = false;
            rbCat4.Checked = false;
            tbLetrasP.Clear();
            tbNumeroP.Clear();
            nudDia.Value = 1;
            nudMes.Value = 1;
            nudHora.Value = 0;
            nudMin.Value = 0;
        }

        private void btnPorcentajeClases_Click(object sender, EventArgs e)
        {
            if (puestoControl == null)
            {
                MessageBox.Show("Debe iniciar la jornada y cargar los precios primero.");
                return;
            }

            finfo.tbInformacion.Clear();
            finfo.tbInformacion.Text = "Porcentaje de clases:";
            double[] porcentaje = puestoControl.VerPorcentajePorCategoria();
            for (int i = 0; i < porcentaje.Length; i++)
            {
                double porc = porcentaje[i];
                finfo.tbInformacion.Text += $"Categoria {i + 1}: %{porc}";
            }
            finfo.ShowDialog();
        }

        private void btnPorcentajeTarjeta_Click(object sender, EventArgs e)
        {
            if (puestoControl == null)
            {
                MessageBox.Show("Debe iniciar la jornada y cargar los precios primero.");
                return;
            }

            double[] porcentajePrepago = puestoControl.VerPorcentajePorSistemaPago();
            finfo.tbInformacion.Clear();
            for (int i = 0; i < porcentajePrepago.Length; i++)
            {
                finfo.tbInformacion.Text = $"Porcentaje pagos con prepago: {porcentajePrepago[i]}";
            }
            finfo.ShowDialog();
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            if (puestoControl == null)
            {
                MessageBox.Show("Debe iniciar la jornada y cargar los precios primero.");
                return;
            }

            puestoControl.VerRecaudacionTotal();

            finfo.tbInformacion.Text = $"Monto total recaudado: ${puestoControl.VerRecaudacionTotal()}";
            finfo.ShowDialog();

        }

        private void btnVerInformacion_Click(object sender, EventArgs e)
        {
            if (puestoControl == null)
            {
                MessageBox.Show("Debe iniciar la jornada y cargar los precios primero.");
                return;
            }


            Ticket[] historial = puestoControl.VerHistorial();
            finfo.tbInformacion.Clear();
            for (int i = 0; i < puestoControl.VerCantidadTickets(); i++)
            {
                string tickets = historial[i].VerInformacion();
                finfo.tbInformacion.Text += $"\r\n*{tickets}\r\n";

            }
            finfo.ShowDialog();
        }
    }
}
