using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Wall : GameObject
    {
        public Wall(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public Wall() { }

        public void LoadLevel(int gamelevel)
        {
           // string fname = "";

            FileStream fs = new FileStream(string.Format(@"C:\Users\Admin\Documents\PP2\PP2\Snake2\Snake2\Levels\Level{0}.txt", gamelevel), FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
    }
}