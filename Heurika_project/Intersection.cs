using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Intersection
    {
        int x;
        int y;

        //list with arrows/streets..
        public Intersection(int Xin, int Yin)
        {
            this.x = Xin;
            this.y = Yin;
        }

        public int X()
        {
            return x;
        }

        public int Y()
        {
            return y;
        }

        public string print()
        {
            return (Convert.ToString(x)+" "+Convert.ToString(y));
        }

        public bool equals(Intersection check)
        {
            return (check.X() == this.x) && (check.Y() == this.y);
        }
    }
}
