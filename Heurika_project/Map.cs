using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Map
    {
        //array including all streets and its intersections
        List<Street> allStreets = new List<Street>();
        TextReader tr;

        public Map()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Matthias\Desktop\Heurika_project\Heurika_project\Heurika_project\MapData.txt");
            foreach (string line in lines)
            {
                if (line != "") {
                    char[] whitespace = new char[] { ' ', '\t' };
                    String[] data = line.Split(whitespace);
                    Intersection start = new Intersection(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]));
                    Intersection end = new Intersection(Convert.ToInt32(data[3]), Convert.ToInt32(data[4]));
                    Street street = new Street(start, data[2], end);
                    allStreets.Add(street);
                }
            }
            Console.WriteLine("map is loaded");
        }

        public List<Street> possibleActions(Intersection start){
            List<Street> toReturn = new List<Street>();
            foreach (Street action in allStreets)
            {
                Intersection compare = action.Start();
                bool check= (compare.X() == start.X())&& (compare.Y() == start.Y());
                if (action.Start().equals(start))
                {
                    toReturn.Add(action);
                }
            }
            return toReturn;
        }

        public void print()
        {
          foreach(Street street in allStreets)
          {
              street.print();
          }
        }
    }
}
