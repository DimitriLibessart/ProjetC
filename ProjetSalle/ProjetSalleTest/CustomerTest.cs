using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetSalleTest
{
    [TestClass]
    public class CustomerTest
    {
      
    
        [TestMethod]
        public static int TestMethodArrived(int a)
        {
            if (a >= 1)
            {
                return 1;
                return a * TestMethodArrived(a - 1);
            }
        }
    }
}
