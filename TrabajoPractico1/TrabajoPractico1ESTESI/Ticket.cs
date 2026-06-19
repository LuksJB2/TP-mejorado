using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1ESTESI
{
    internal class Ticket
    {
        public int hora;
        public string patente;
        public string categoria;
        public double monto;
        public double descuento;
        public double montoFinal;

        public Ticket(int hr,string pat,string cat, double mot,double desc, double montoF)
        {
            hora = hr;
            patente = pat;
            categoria = cat;
            monto = mot;
            descuento = desc;
            montoFinal = montoF;
        }

        public string TicketImpreso()
        {
            string papel = $"Hora: {hora} \nPatente: {patente} \nCategoria: {categoria} \nMonto: {monto} \nDescuento: {descuento} \nMonto Final: {montoFinal}";
            return papel;
        }
    }
}
