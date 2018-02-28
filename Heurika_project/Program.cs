using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Program
    {

        static void Main(string[] args)
        {
            //load map
            Map map = new Map();
            map.print();
            Console.ReadLine();

            //set up problem
            Intersection start = new Intersection(10, 70);
            Intersection end = new Intersection(45, 70);
            Problem problem = new Problem(map, start, end);
            Console.WriteLine("Problem is created");

            //run algo
            Algorithms algo = new Algorithms();
            Console.WriteLine("result Breadth First seach algo: "+algo.BreadthFirstSearch(problem));

            //wait with closing console
            Console.ReadLine();
        }


    }
}
