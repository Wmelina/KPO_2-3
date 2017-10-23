using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KPO_FirstLab;

namespace QueueRealisation_Test
{
    [TestFixture]
    public class Class1
    {

        [Test()]
        [ExpectedException(typeof(Exception))]
        public void Test1()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            int act = asd.Pop();


        }
        [Test()]
        public void Test_push3_pop1()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(1);
            asd.Push(2);
            asd.Push(3);
            int expec = 2;
            asd.Pop();
            int act = asd.Pop();
            Assert.AreEqual(expec, act);

        }
        [Test()]
        public void Test_count1()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(8);
            int expec = 1;
            int act = asd.count;
            Assert.AreEqual(expec, act);
        }
        [Test()]
        public void Test_count2()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();

            asd.Push(1);
            asd.Push(2);
            int expec = 2;
            int act = asd.count;
            Assert.AreEqual(expec, act);
        }
        [Test()]
        public void Test_push2_pop1()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();

            asd.Push(1);
            asd.Push(2);
            asd.Pop();
            int expec = 1;
            int act = asd.count;
            Assert.AreEqual(expec, act);
        }
        [Test()]
        public void Test_pus_pop_check()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(4);
            asd.Push(2);
            asd.Push(6);
            int expec = 4;
            int act = asd.TakeTop();
            Assert.AreEqual(expec, act);
            asd.Pop();
            expec = 2;
            act = asd.TakeTop();
            Assert.AreEqual(expec, act);
            asd.Pop();
            expec = 6;
            act = asd.TakeTop();
            Assert.AreEqual(expec, act);
            asd.Pop();
            expec = 0;
            act = asd.TakeTop();
            Assert.AreEqual(expec, act);

        }

        [Test()]
        public void Test_IEnumerable()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(4);
            asd.Push(2);
            asd.Push(6);

            string result = "";

            foreach (int x in asd)
            {
                result += x.ToString();
            }

            string expeted = "426";

            Assert.AreEqual(expeted, result);
        }


        [Test()]
        public void Test_Clone()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(4);
            asd.Push(2);
            asd.Push(6);

            QueueRealisation<int> act = (QueueRealisation<int>)asd.Clone();

            asd.Pop();
            asd.Pop();

            Assert.AreEqual(1, asd.count);
            Assert.AreEqual(3, act.count);
            Assert.AreEqual(6, act.Pop());
        }
    }
}