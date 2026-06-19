using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

            todosLosTickets = new Ticket[1000];
            contadorTickets = 0;

            vehiculosPesados = new string[1000];
            contadorVehiculosPesados = 0;
        }

        public string RegistrarPeaje(int hr,int cat,int esHab)
        {
            
        }
    }
}
