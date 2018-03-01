using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heurika_project
{
    class Problem
    {
        Map map;
        Intersection initialState;
        Intersection goalState;

        public Problem(Map mapIn, Intersection init, Intersection goal)
        {
            this.map = mapIn;
            this.initialState = init;
            this.goalState = goal;
        }

        public Boolean equalsGoal(Node nodeInQuestion)
        {
            return (goalState.equals(nodeInQuestion.State()));
        }
        public Map data()
        {
            return map;
        }
        public Intersection initial()
        {
            return initialState;
        }
        public int heuristic(Intersection currentState)
        { //straigth line from currentState to goalState.
            //return Convert.ToInt32(Math.Sqrt(Math.Pow(goalState.X() - currentState.X(), 2) + Math.Pow(goalState.Y() - currentState.Y(), 2)));
            return 0;
        }
    }
}
