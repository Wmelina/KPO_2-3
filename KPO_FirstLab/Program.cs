using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            Console.WriteLine(asd.IsEmpty());
            asd.Push(1);
            asd.Push(2);
            asd.Push(3);
            asd.Push(4);
            CompositionOfNumberThatNotEqualZero kek = new CompositionOfNumberThatNotEqualZero();
            Console.WriteLine(kek.Action(asd));
            Console.WriteLine(kek.asd(asd));
            asd.Push(0);
            Console.WriteLine(kek.Action(asd));
            Console.WriteLine(kek.asd(asd));
            Console.ReadKey();
        }
    }
}
