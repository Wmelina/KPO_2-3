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
        public int cmpstn = 1;
        public int Action(QueueRealisation<int> queue)
        {
            foreach  (int item in queue)
            {
                if (item != 0)
                {
                    cmpstn *= item;
                }
            }
            return cmpstn;
        }
    }
}
