using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1ESTESI
{
    internal class Ticket
    {
        public int hora;
        public int categoria;
        public double monto;
        public double descuento;
        public double montoF;
        public double minutos;
        public bool diaHabil;
        public int mes;
        public int dia;
        public int patentenumeros;
        public string patenteletras;


        public Ticket(int hr,int cat,double preciocategoria, double min, bool eshab,int d,int m,string patenteL,int patenteN)
        {
            patenteletras = patenteL;
            patentenumeros = patenteN;
            hora = hr;
            dia = d;
            mes = m;
            diaHabil = eshab;
            categoria = cat;
            monto = preciocategoria;
            minutos = min;
            descuento = 0;
        }

        public Ticket() { }

        public double CalcularMonto()
        {
            if ((hora >= 22 && minutos > 30) || (hora <= 6 && minutos ==0))
            {
                if (diaHabil == true)
                {
                    descuento = 15;
                }
                else
                {
                    descuento = 25;
                }
            }
            else if ((hora >= 6 && minutos > 0) || (hora <= 20 && minutos==0))
            {
                if (diaHabil == true)
                {
                    descuento = 10;
                }
                else
                {
                    descuento = 15;
                }
            }
            else if ((hora >= 20 && minutos > 0) || (hora <= 22 && minutos <= 30))
            {
                if (diaHabil == true)
                {
                    descuento = 12;
                }
                else
                {
                    descuento = 20;
                }
            }

            montoF = monto - ((descuento * monto) / 100);
            return montoF;
        }

        public string TicketImpreso()
        {
            double montofinal = CalcularMonto();
            string papel = $"Fecha: {mes:00}|{dia:00} \r\nHora: {hora}:{minutos:00}  \r\nCategoria: {categoria} \r\nPatente: {patenteletras}-{patentenumeros}\r\nMonto: {monto} \r\nDescuento: {descuento} \r\nMonto Final: {montoF} \r\n";
            return papel;
        }
    }
}
