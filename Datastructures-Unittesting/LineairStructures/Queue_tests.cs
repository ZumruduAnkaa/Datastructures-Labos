using System;
using Datastructures_ClassLibrary.LineairStructures;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_ClassLibrary.Helpers;

namespace Datastructures_Unittesting.LineairStructures
{
    [TestClass]
    public class Queue_tests
    {
        [TestMethod]
        public void TestQueue()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1 };
            Queue q = new Queue();

            //TODO: first check if queue is empty

            Assert.AreEqual(0, q.Count);

            //TODO: then add each item in list to the queue

            for (int i = 0; i < list.Length; i++)
            {
                q.Enqueue(list[i]);
            }

            //TODO: check if queue now contains 5 items (without removing them)

            Assert.AreEqual(5, q.Count);

            //TODO: get all items from the queue again and compare if they are still in the same order as the list above
            for (int i = 0; i < list.Length; i++)
            {
                Assert.AreEqual(list[i], q.Dequeue());
            }
            //TODO: check if queue is now empty

            Assert.AreEqual(0, q.Count);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestQueueWith11Elements()
        {
            Queue q = new Queue();

            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(i);
            }

            q.Enqueue(11);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestQueueWith0Element()
        {
            Queue q = new Queue();

            q.Dequeue();
        }

        [TestMethod]
        public void TestQueueWith100Capacity()
        {
            Queue q = new Queue(100);

            Assert.AreEqual(100, q.Capacity);
        }

        [TestMethod]
        public void TestQueueWith500Capacity()
        {
            int[] list = RandomArrayGenerator.Generate(500, 1, 1000, false);
            Queue q = new Queue(500);

            for (int i = 0; i < list.Length; i++)
            {
                q.Enqueue(list[i]);
            }

            for (int i = 0; i < list.Length; i++)
            {
                Assert.AreEqual(list[i], q.Dequeue());
            }
        }

        [TestMethod]
        public void TestCanGrowQueueWith21Elements()
        {
            Queue q = new Queue(10, true);

            for (int i = 0; i < 21; i++)
            {
                q.Enqueue(i);
            }

            Assert.AreEqual(40, q.Capacity);
        }
    }
}
