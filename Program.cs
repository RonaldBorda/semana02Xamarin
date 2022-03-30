using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coordenadas");
            Persona rectLado = new Persona();
            

            Console.WriteLine("Ingresar x1:");
            double x1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar y1:");
            double y1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar x2:");
            double x2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar y2:");
            double y2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar x3:");
            double x3 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar y3:");
            double y3 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar x4:");
            double x4 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar y4:");
            double y4 = (int)Convert.ToDouble(Console.ReadLine());

 

            rectLado.p1 = new Punto(x1,y1);
            rectLado.p2 = new Punto(x2, y2);
            rectLado.p3 = new Punto(x3, y3);
            rectLado.p4 = new Punto(x4, y4);

            double cateto1 = rectLado.devolverCateto1A();
            double cateto2 = rectLado.devolverCateto2A();
            double cateto3 = rectLado.devolverCateto1B();
            double cateto4 = rectLado.devolverCateto2B();

            double largo = Math.Sqrt(Math.Pow((int)Convert.ToDouble(cateto1),2)+ Math.Pow((int)Convert.ToDouble(cateto2),2));
            double ancho = Math.Sqrt(Math.Pow((int)Convert.ToDouble(cateto3), 2) + Math.Pow((int)Convert.ToDouble(cateto4), 2));


            Console.WriteLine("Largo del rectangulo: ");
            Console.WriteLine(largo);
            Console.WriteLine("Ancho del rectangulo: ");
            Console.WriteLine(ancho);

            Console.WriteLine("Perimetro: ");
            Console.WriteLine((largo)*2+(ancho)*2);
            Console.WriteLine("Area: ");
            Console.WriteLine(largo*ancho);

            Console.ReadKey();
        }
    }
}
