using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitTestDemo
{


    [TestFixture]
    class TestClass
    {
        [TestCase]

        

        public void Add()
        {
            myClass addition = new myClass();
            Assert.AreEqual(30, addition.Add(10, 20));

        }


        [TestCase]
        public void Sub()
        {
            myClass addition = new myClass();
            Assert.AreEqual(10, addition.Sub(20, 10));

        }



    }
}
