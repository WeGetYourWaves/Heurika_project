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
            string start1 = "SktPedersStraede";
            string start2 = "Larsbjoernsstraede";
            Console.WriteLine("\n"+"my start intersection is at:"+ map.getIntersectionFrom2Streetnames(start1,start2).print());
            Intersection start = new Intersection(35, 80);
            Intersection end = new Intersection(45, 70);
            Problem problem = new Problem(map, start, end);
            Console.WriteLine("Problem is created");

            //run algo
            Algorithms algo = new Algorithms();
            //Console.WriteLine("result Breadth First seach algo: "+algo.BreadthFirstSearch(problem));
            Console.WriteLine("result AStart algo: " + algo.Astar(problem));
            //wait with closing console
            Console.ReadLine();
        }


    }
}
