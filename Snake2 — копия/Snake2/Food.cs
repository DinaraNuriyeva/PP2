using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Food : GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public Food() { }
        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);
            
            Point firstPoint = new Point();
        }
    }
}