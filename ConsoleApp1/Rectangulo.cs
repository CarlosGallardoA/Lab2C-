using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangulo
    {
        public punto p1 { get; set; }
        public punto p2 { get; set; }
        public punto p3 { get; set; }
        public punto p4 { get; set; }
       
        public int CalcularArea(int x1,int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int area = Math.Abs((x1 * y2) + (x2 * y3) + (x3 * y4) - ((x2 * y1) + (x3 * y2) + (x4 * y3)));

            return area / 2;
        }
        public int CalcularPerimetro(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int perimetro = (int)Math.Sqrt(Math.Pow((x4 - x1), 2) + Math.Pow((y4 - y1),2)) + (int)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)) + (int)Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)) + (int)Math.Sqrt(Math.Pow((x1 - x4), 2) + Math.Pow((y1 - y4), 2));
            return perimetro;
        }
    }
}
