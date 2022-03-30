using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana02
{
    class Persona
    {
        public Punto p1 { get; set; }
        public Punto p2 { get; set; }
        public Punto p3 { get; set; }
        public Punto p4 { get; set; }

        public double devolverCateto1A()
        {
            return  p2.x - p1.x;
        }
        public double devolverCateto2A()
        {
            return p2.y - p1.y;
        }
        public double devolverCateto1B()
        {
            return p2.x - p3.x;
        }
        public double devolverCateto2B()
        {
            return p3.y - p2.y;
        }
    }
}
