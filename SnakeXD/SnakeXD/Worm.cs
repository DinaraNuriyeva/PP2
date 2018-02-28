using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeXD
{
    public class Worm : GameObject
    {
        Game game = null;

        public void LinkToGame(Game game)
        {
            this.game = game;
        }

        public int dx;
        public int dy;

       

        public Worm(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {
        }

        public void Generate()
        {
            this.body.Add(new Point(10, 10));
        }

        public void Move()
        {
            while (true)
            {
                Thread.Sleep(Game.SPEED);

                if (body[0].x + dx < 0) continue;
                if (body[0].y + dy < 0) continue;
                if (body[0].x + dx > Game.WIDTH) continue;
                if (body[0].y + dy > Game.HEIGTH) continue;

                this.Clear();

                for (int i = body.Count - 1; i > 0; --i)
                {
                    body[i].x = body[i - 1].x;
                    body[i].y = body[i - 1].y;
                }

                body[0].x = body[0].x + dx;
                body[0].y = body[0].y + dy;

                this.Draw();

                game.CanEat();
            }
        }


    }
}
