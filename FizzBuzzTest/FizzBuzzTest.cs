using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizz()
        {   
            //skapa
            CFizzBuzz fb= new CFizzBuzz();
            bool borvarde=true;
            bool arvarde;

            //anropa
            arvarde = fb.fizz(6);

            //j�mf�r
            Assert.AreEqual(arvarde, borvarde);

        }

        [TestMethod]
        public void TestBuzz()
        {
            //skapa
            CFizzBuzz fb = new CFizzBuzz();
            bool borvarde = true;
            bool arvarde;

            //anropa
            arvarde = fb.buzz(10);

            //j�mf�r
            Assert.AreEqual(arvarde, borvarde);
        }

        [TestMethod]    
        public void TestFizzBuzz()
        {
            //skapa
            CFizzBuzz fb = new CFizzBuzz();
            bool borvarde = true;
            bool arvarde;

            //anropa
            arvarde = fb.FizzBuzz(15);

            //j�mf�r
            Assert.AreEqual(arvarde, borvarde);
        }
    }
}