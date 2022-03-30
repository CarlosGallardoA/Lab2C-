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
       
        public int CalcularArea()
        {
            
            int area = Math.Abs((p1.x * p2.y) + (p2.x * p3.y) + (p3.x * p4.y) - ((p2.x * p1.y) + (p3.x * p2.y) + (p4.x * p3.y)));

            return area / 2;
        }
        public int CalcularPerimetro()
        {
            int perimetro = (int)Math.Sqrt(Math.Pow((p4.x - p1.x), 2) + Math.Pow((p4.y - p1.y),2)) + (int)Math.Sqrt(Math.Pow((p3.x - p2.x), 2) + Math.Pow((p3.y - p2.y), 2)) + (int)Math.Sqrt(Math.Pow((p2.x - p3.x), 2) + Math.Pow((p2.y - p3.y), 2)) + (int)Math.Sqrt(Math.Pow((p1.x - p4.x), 2) + Math.Pow((p1.y - p4.y), 2));
            return perimetro;
        }
    }
}
