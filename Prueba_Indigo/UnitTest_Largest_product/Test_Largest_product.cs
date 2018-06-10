using System;
using Largest_product_in_a_series;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Largest_product
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var serie = new Series();
                string valores = "";
                string[] Val = new string[2];
                valores = "10 5";
                Val = valores.Split(' ');
                serie.L = Convert.ToInt32(Val[0]);
                serie.K = Convert.ToInt32(Val[1]);

                serie.N = Convert.ToInt32("3675356291");
                serie.Serie();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
