using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeXD
{
    public abstract class GameObject : IDrawable
    {
     
        public List<Point> body { get; }
        public char sign { get; }
        public ConsoleColor color { get; }

        //public GameObject() { }

        public GameObject(Point firstPoint, ConsoleColor color, char sign)
        {
            this.body = new List<Point>();
            if (firstPoint != null)
            {
                this.body.Add(firstPoint);
            }
            this.color = color;
            this.sign = sign;
        }

        public void Draw()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(' ');
            }
        }

        public GameObject Load()
        {
            GameObject result = null;

            string fname = this.GetType().Name;
            XmlSerializer xs = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(string.Format("{0}.xml", fname), FileMode.Open, FileAccess.Read))
            {
                result = xs.Deserialize(fs) as GameObject;
            }

            return result;
        }

        public void Save()
        {
            string fname = this.GetType().Name;
            XmlSerializer xs = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(string.Format("{0}.xml", fname), FileMode.OpenOrCreate, FileAccess.Write))
            {
                xs.Serialize(fs, this);
            }
        }
    }
}
