using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_FirstLab
{
    class CompositionOfNumberThatNotEqualZero
    {
        
        public int Action(QueueRealisation<int> queue)
        {
             int cmpstn = 1;
            foreach  (int item in queue)
            {
                if (item != 0)
                {
                    cmpstn *= item;
                }
            }
            return cmpstn;
        }
        //used anonymous method and pipeline. completed 4 lab 
        public int asd(QueueRealisation<int> queue)
        {
            int cmpstn = 1;
            IEnumerable<int> queueWithPositiveNumbers = queue.Que.Where(x => x != 0); // OH THAT WAS BAD IDEA, NEVERMIND
            foreach (int item in queueWithPositiveNumbers) { cmpstn *= item;}
            return cmpstn;
        }
    }
}
