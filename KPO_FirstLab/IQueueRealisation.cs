using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_FirstLab
{
  public interface IQueueRealisation<T>
    {
        void Push(T take);
        T Pop();
        bool IsEmpty();
        T TakeTop();
        
    }
}
