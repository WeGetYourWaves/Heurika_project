using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngineForPropositionalLogic
{
    //representation of clause
    public class Clause
    {
        public List<int> litelars { get; set; }

        public List<int> Resolve(Clause clause)
        {
            for (int i = 0; i < litelars.Count; i++)
            {
                if (litelars[i] == -clause.litelars[i])
                {
                    litelars[i] = clause.litelars[i] = 0;
                }
            }

            return litelars;
        }

        private int calculateHeuristic(Clause clause)
        {
            var counter = 0;

            for (int i = 0; i < litelars.Count; i++)
            {
                if (litelars[i] == -clause.litelars[i])
                    counter++;
            }

            return counter;
        }

    }
}
