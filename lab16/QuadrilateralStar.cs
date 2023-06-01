using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    public class QuadrilateralStar
    {
        public int a { get; set; }
        public int b { get; set; }

        public QuadrilateralStar(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Draw(Graphics g)
        {
            // Розрахунок координат вершин зірки
            int x1 = 0;
            int y1 = b / 2;
            int x2 = a / 2;
            int y2 = 0;
            int x3 = a;
            int y3 = b / 2;
            int x4 = a / 2;
            int y4 = b;

            // Малювання зірки за допомогою графічного об'єкта
            g.DrawLine(Pens.Black, x1, y1, x3, y3);
            g.DrawLine(Pens.Black, x2, y2, x4, y4);
            g.DrawLine(Pens.Black, x1, y1, x4, y4);
            g.DrawLine(Pens.Black, x2, y2, x3, y3);
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            g.DrawLine(Pens.Black, x3, y3, x4, y4);
        }
    }

}
