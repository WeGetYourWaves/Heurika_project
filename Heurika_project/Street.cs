using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Street
    {
        Intersection start;
        Intersection end;
        string streetName;
        int streetLength;

        public Street(Intersection startIn, string name, Intersection endIn)
        {
            this.start = startIn;
            this.end = endIn;
            this.streetName = name;
            computeStreetLength();
        }

        private void computeStreetLength()
        { //street length == length of arrow from start to end
            streetLength = Convert.ToInt32(Math.Sqrt(Math.Pow(end.X()- start.X(), 2)+ Math.Pow(end.Y()-start.Y(),2)));
        }

        public Intersection Start()
        {
            return start;
        }

        public Intersection End() {
            return end;
        }
        public string Name()
        {
            return streetName;
        }

        public int Length()
        {
            return streetLength;
        }

        public string print()
        {
            return (start.print() + " " + streetName + " " +end.print() + "  streetLength: " + streetLength);
        }
    }
}
