using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Snake2
{
    public abstract class GameObject
    {
        public List<Point> body { get; }
        public char sign { get; }
        public ConsoleColor color { get; }

        public GameObject() { }

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

            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);

                Console.Write(sign);
            }
        }

         public void Clear()
         {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);

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