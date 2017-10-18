using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KPO_FirstLab
{
    public class QueueRealisation<T> : IQueueRealisation<T>, IEnumerable
    {

        public T[] Que = new T[1];
        public int count = 0;

        public T Pop()
        {
            if (IsEmpty()) //fixed with method (there was count checker)
            {
                throw new Exception("massive is empty");
            }
            else
            {
                T savedElement = Que[0];
                for (int i = 0; i < Que.Length - 1; i++)
                {
                    Que[i] = Que[i + 1];
                }
                count--;
                if (Que.Length == 1)
                {
                    return savedElement;
                }
                else
                {
                    Array.Resize(ref Que, Que.Length - 1);
                    return savedElement;
                }
            }

        }

        public void Push(T take)
        {
            if (Que.Length == count)
            {
                Array.Resize(ref Que, Que.Length + 1);
                Que[count] = take;
                count++;
            }
            else
            {
                Que[count] = take;
                count++;
            }
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T TakeTop()
        {
            if (IsEmpty()) // also fixed
            {
                throw new Exception("massive is empty");
            }
            else
            {
                return Que[0];
            }
        }
            public IEnumerator GetEnumerator()
            {
                return Que.GetEnumerator();
            }
        }
    }
