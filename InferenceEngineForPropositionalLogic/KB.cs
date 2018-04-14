using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngineForPropositionalLogic
{
    //Represents our KB as set of clauses
    public class KB
    {
        public List<Clause> clauses { get; set; }

        public bool TryReduce()
        {
            var isReduced = false;

            for (int i = 0; i < clauses.Count; i++)
            {
                for (int j = 0; j < clauses.Count; j++)
                {
                    if (!clauses[i].litelars.Any( o => o != 0))
                    {
                        clauses.Remove(clauses[i]);
                        isReduced = true;
                    }
                    if (clauses[i].litelars.SequenceEqual(clauses[j].litelars))
                    {
                        clauses.Remove(clauses[i]);
                        isReduced = true;
                    }
                }
            }

            return isReduced;
        }

        public KB()
        {
            initialize();
        }

        //Put some data into our KB as list of literals, do we need a function to convert any logic formula into CNF?
        private void initialize()
        {
            var clause1 = new Clause { litelars = { 1, -1, 0, 0 } };
            var clause2 = new Clause { litelars = { 0, 1, -1, -1 } };
            var clause3 = new Clause { litelars = { 0, 1, 1, -1 } };
            var clause4 = new Clause { litelars = { 0, 0, 0, 1 } };
        }
    }
}
