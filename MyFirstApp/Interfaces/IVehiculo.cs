using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Interfaces
{
    interface IVehiculo
    {
        void Acelerar(int kmh);
        void Aterrizar();
        void Girar(int angulos);
        void Despegar();
        void Frenar();

    }
}
