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
            WorkWithData s = new WorkWithData();
            Person fi = new Person("Сёма", 12);
            Person sec = new Person("Саша", 17);
            Person thi = new Person("Ира", 27);
            QueueRealisation<Person> persons = new QueueRealisation<Person>();
            persons.Push(fi);
            persons.Push(sec);
            persons.Push(thi);
            s.IDKH2N(persons);
            Console.ReadKey();
        }
    }
}
