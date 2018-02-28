using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{   [Serializable]
    public class Score
    {
        public void DrawScore(string info)
        {
            Console.SetCursorPosition(0, 33);
            Console.WriteLine(info);
        }
    }
}
