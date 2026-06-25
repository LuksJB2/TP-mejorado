using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TrabajoPractico1ESTESI
{
    internal class PuestoDeControl
    { 
        
        double precioCat1;
        double precioCat2;
        double precioCat3;
        double precioCat4;
        int totalTickets;
        int totalMonto;
        int totalCat1;
        int totalCat2;
        int totalCat3;
        int totalCat4;
        double totalPrepaga;

        public Ticket[] todosLosTickets;
        public int contadorTickets;

        public string[] vehiculosPesados;
        public int contadorVehiculosPesados;

        public PuestoDeControl(int pr1,int pr2,int pr3,int pr4)
        {
            precioCat1 = pr1;
            precioCat2 = pr2;
            precioCat3 = pr3;
            precioCat4 = pr4;
            totalTickets = 0;
            totalMonto = 0;
            totalCat1 = 0;
            totalCat2 = 0;
            totalCat3 = 0;
            totalCat4 = 0;
            totalPrepaga = 0;
            contadorTickets = 0;
            contadorVehiculosPesados = 0;
            vehiculosPesados = new string[500000];
            todosLosTickets = new Ticket[500000];

        }

        public string RegistrarPeaje(bool prepago,int hr,int cat,int min,bool esHab,int d,int m, string patenteL, int patenteN)
        {
            Ticket tickets = new Ticket();
            if(prepago == true)
            {
                totalPrepaga++;
            }
            switch (cat)
            {
                case 1:
                    tickets= new Ticket(hr, cat, precioCat1, min, esHab,d,m,patenteL,patenteN);
                    totalCat1++;
                    break;
                case 2:
                    tickets = new Ticket(hr, cat, precioCat2, min, esHab,d,m, patenteL, patenteN);
                    totalCat2++;
                    break;
                case 3:
                    tickets = new Ticket(hr, cat, precioCat3, min, esHab, d, m, patenteL, patenteN);
                    totalCat3++;
                    if (esHab == false)
                    {
                        if (hr >=00 && min > 29 || hr <= 23 && min < 01)
                        {
                            vehiculosPesados[contadorVehiculosPesados] = tickets.ToString();
                        }
                    }
                    contadorVehiculosPesados++;
                    break;
                case 4:
                    tickets = new Ticket(hr, cat, precioCat4, min, esHab, d, m, patenteL, patenteN);
                    totalCat4++;
                    if (esHab == false)
                    {
                        if (hr >= 00 && min > 29 || hr <= 23 && min < 01)
                        {
                            vehiculosPesados[contadorVehiculosPesados] = tickets.ToString();
                        }
                    }
                    contadorVehiculosPesados++;
                    break;
            }
            todosLosTickets[contadorTickets] = tickets;
            contadorTickets++;
            
            string ticket = tickets.TicketImpreso();
            if (cat == 1)
            {
                precioCat1 = tickets.montoF;
            }
            else if (cat == 2)
            {
                precioCat2 = tickets.montoF;
            }
            else if (cat == 3)
            {
                precioCat3 = tickets.montoF;
            }
            else if (cat == 4)
            {
                precioCat4 = tickets.montoF;
            }
            return ticket;
        }
        public int VerCantidadTickets()
        {
            int cantidadTicket = contadorTickets;
            return cantidadTicket;
        }
        
        public string[] VerVehiculosCarga()
        {
            return vehiculosPesados;
        }
        
        public double[] VerPorcentajePorCategoria()
        {
            double porcentaje1;
            double porcentaje2;
            double porcentaje3;
            double porcentaje4;
            double[] Porcentaje= new double[4];
            porcentaje1 = ((double)totalCat1 / contadorTickets) * 100;
            porcentaje2 = ((double)totalCat2 / contadorTickets) * 100;
            porcentaje3 = ((double)totalCat3 / contadorTickets) * 100;
            porcentaje4 = ((double)totalCat4 / contadorTickets) * 100;

            Porcentaje[0] = porcentaje1;
            Porcentaje[1] = porcentaje2;
            Porcentaje[2] = porcentaje3;
            Porcentaje[3] = porcentaje4;

            return Porcentaje;
        }

        public double VerPorcentajePorSistemaPrepago()
        {
            double porcentajePrepago = (totalPrepaga / contadorTickets)*100;
            return porcentajePrepago;
        } 

        public double VerRecaudacionTotal()
        {
            double recaudacion = precioCat1 + precioCat2 + precioCat3 + precioCat4;
            return recaudacion;
        }

        public Ticket[] VerHistorial()
        {
            return todosLosTickets;
        }
    }
}
