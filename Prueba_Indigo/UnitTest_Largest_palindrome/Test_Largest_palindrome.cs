using System;
using Largest_palindrome_product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class Test_Largest_palindrome
    {
        [TestMethod]
        public void TestMethod1()
        {
            var palindromo = new Palindrome();
            try
            {
                palindromo.N = Convert.ToInt32("800000");
                palindromo.Palindromo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
