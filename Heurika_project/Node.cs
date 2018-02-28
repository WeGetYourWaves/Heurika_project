using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Node
    {
        Intersection state;  //current intersection
        Node parent; //where we come from
        Street action; //street that has been taken to get to us
        int pathCost;  //cost till here..


        //initial state, parent == state
        public Node(Intersection stateIn, Node parentIn, int pathCostIn)
        {
            this.state = stateIn;
            this.parent = parentIn;
            this.pathCost = pathCostIn;
        }

        //child Node
        public Node(Intersection stateIn, Node parentIn, Street actionIn, int pathCostIn)
        {
            this.state = stateIn;
            this.parent = parentIn;
            this.action = actionIn; 
            this.pathCost = pathCostIn;
        }


        public List<Node> getChildren(Problem problem) //action is always the same: take a street..
        {
            List<Street> connectedStreets = problem.data().possibleActions(state);
            List<Node> children = new List<Node>();
            foreach (Street street in connectedStreets)
            {
                street.print();
                Node newChild = new Node(street.End(), this, street, this.pathCost + street.Length());
                children.Add(newChild);
            }
            return children;
        }

        public Intersection State()
        {
            return this.state;
        }

        public int cost()
        {
            return pathCost;
        }

        public Node parentNode()
        {
            return this.parent;
        }

        public Street takenStreet()
        {
            return this.action;
        }
    }

}
