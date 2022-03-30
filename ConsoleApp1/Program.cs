using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la coordenada en x del punto 1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en y del punto 1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en x del punto 2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en y del punto 2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en x del punto 3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en y del punto 3: ");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en x del punto 4: ");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada en y del punto 4: ");
            int y4 = int.Parse(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo();
            
            int area = rectangulo.CalcularArea(x1,y1,x2,y2,x3,y3,x4,y4);
            int perimetro = rectangulo.CalcularPerimetro(x1,y1,x2,y2,x3,y3,x4,y4);

            Console.WriteLine("El area es " + area);
            Console.WriteLine("El perimetro es " + perimetro);
            Console.ReadLine();

        }
    }
}
