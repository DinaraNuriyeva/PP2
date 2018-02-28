using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeXD
{
    public class Wall : GameObject
    {
        public Wall(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {
        }
       
        public void LoadLevel()
        {
            string fname = "";
            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        body.Add(new Point { });
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
            /*public void Generate()
            {
                this.points.Add(new Point(2, 3));
                this.points.Add(new Point(2, 31));
                this.points.Add(new Point(23, 3));
                this.points.Add(new Point(2, 35));
            }*/
        }
    
}
