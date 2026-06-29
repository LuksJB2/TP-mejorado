using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TrabajoPracticoMEJORADO
{
    internal class Ticket
    {
        public int Hora;
        public int Categoria;
        public bool EsDiaHabil;
        public double PrecioCatSelect;
        public bool EsSistemaPrepago;

        public Ticket(int hr, int cat, bool esHab, double precio, bool esPrep)
        {
            Hora = hr;
            Categoria = cat;
            EsDiaHabil = esHab;
            PrecioCatSelect = precio;
            EsSistemaPrepago = esPrep;
        }
        public Ticket() { }
        public double CalcularCosto()
        {
            double pr = PrecioCatSelect;
            double porcentaje = 0;
            if (EsDiaHabil)
            {
                if (Hora >= 2231 || Hora <= 600)
                {
                    porcentaje = 15;
                }
                else if (Hora >= 601 && Hora <= 2000)
                {
                    porcentaje = 10;
                }
                else
                {
                    porcentaje = 12;
                }

            }
            else
            {
                if (Hora >= 2231 || Hora <= 600)

                {
                    porcentaje = 25;
                }
                if (Hora <= 2000)
                {
                    porcentaje = 15;
                }
                else
                {
                    porcentaje = 20;
                }
            }

            double descuento = pr * porcentaje / 100;
            double precioFinal = pr - descuento;
            return precioFinal;
        }

        public string VerInformacion()
        {

            int h = Hora / 100;
            int m = Hora % 100;

            double montoF = CalcularCosto();
            string Ticket = $"Hora: {h:D2}:{m:D2} \r\nCategoria: {Categoria}\r\nEs dia habil: {EsDiaHabil}\r\nPrecio: {PrecioCatSelect}\r\nMonto Final: {montoF} ";
            return Ticket;
        }
    }
}