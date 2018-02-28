using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Algorithms
    {
        public Algorithms()
        {

        }

        //it is like Breadth first reach, but we have an ordered queue
        public Boolean Astar(Problem problem)
        {
            Node node = new Node(problem.initial(), null, null, 0);
            if (problem.equalsGoal(node)) { return true; }
            List<Node> frontier = new List<Node>();
            frontier.Add(node);
            List<Node> expanded = new List<Node>();

            while (frontier.Any())
            {
                frontier.OrderBy(x => x.cost()); //orders frontier in ascending order
                node = frontier[0]; //picks the one with lowest value
                Console.WriteLine("current node: " + node.State().print());
                frontier.Remove(node);
                expanded.Add(node);
                foreach (Node child in node.getChildren(problem))
                {   //if child state not in frontier and not in expanded
                    if (!frontier.Exists(x => x.State() == child.State()) && !expanded.Exists(x => x.State() == child.State()))
                    {
                        if (problem.equalsGoal(child)) { return true; } //here we should return solution... parent of parent..
                        frontier.Add(child);
                    }
                }
            }
            return false; //if frontier is empty
        }

        private int h()//h(Intersection start, Intersection end)
        { //straigth line from start to end.
            //return Convert.ToInt32(Math.Sqrt(Math.Pow(end.X() - start.X(), 2) + Math.Pow(end.Y() - start.Y(), 2)));
            return 0;
        }

        public Boolean UniformCostSearch(Intersection start, Intersection end)
        {
            //node = node with state initial state

            //frontier = priority queue, ordered by path cost, with node as the only element
            //explored = explored nodes, now an empty set
            //loop do
                //if frontier==empty: return failure
                //node= pop(frontier)//choose lowest node from frontier, delete it from frontier
                //if(node==goal): return solution(node)(true & whole path..)
                //add node to explored
                //for each action in problem.Actions(node.state) do:
                    //child = node.child(given node and action and state)
                    //if child is not explored and not in frontier, then
                        //frontier adds child
                    //else if child is in frontier, but with higher path cost:
                        //replace that frontier node  with child

            return false;
        }

        //only optimal if all streets have the same length
        public Boolean BreadthFirstSearch(Problem problem)
        {
            Node node = new Node(problem.initial(), null, null, 0);
            if (problem.equalsGoal(node)) { return true; }
            List<Node> frontier = new List<Node>();
            frontier.Add(node);
            List<Node> expanded = new List<Node>();
      
            while (frontier.Any())
            {
                node = frontier[0];
                Console.WriteLine("current node: " +node.State().print());
                frontier.Remove(node);
                expanded.Add(node);
                foreach (Node child in node.getChildren(problem))
                {   //if child state not in frontier and not in expanded
                    if ( !frontier.Exists(x=> x.State() == child.State()) && !expanded.Exists(x=> x.State() == child.State())){
                        if (problem.equalsGoal(child)) {
                            solution(child);
                            return true; } //here we should return solution... parent of parent..
                        frontier.Add(child);
                    }
                }
            }
            return false; //if frontier is empty
        }

        private void solution(Node node)
        {

            Console.WriteLine("\n" + "\n" +"Goal state is reached with total path cost: " + Convert.ToString(node.cost()));
            Console.WriteLine("\n" + "path from end to start:");
            while (node.parentNode()!= null)
            {
                node.takenStreet().print();
                node = node.parentNode();
            }
        }

    }
}
