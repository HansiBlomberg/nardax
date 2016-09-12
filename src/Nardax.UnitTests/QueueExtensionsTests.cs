using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nardax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nardax.Tests
{
    [TestClass()]
    public class QueueExtensionsTests
    {

        Queue<string> _queue;

        public QueueExtensionsTests()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            _queue.Enqueue("cc");


        }



        [TestMethod()]
        public void EnqueueRangeTest()
        {
            _queue.EnqueueRange(new[] { "dd", "ee" });
            Assert.AreEqual("aa", _queue.Dequeue());
            Assert.AreEqual("bb", _queue.Dequeue());
            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());

        }


        public void going-bananas[eerrladkfjkasfj]
    }
}