using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwitchCaseWhen.Tests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void WorkingVersion()
      {
         var class1 = new Class1();

         Assert.IsTrue(class1.SwitchCaseThatWorks("String"));
         Assert.IsTrue(class1.SwitchCaseThatWorks(12));
         Assert.IsTrue(class1.SwitchCaseThatWorks(12.123));
      }

      [TestMethod]
      public void FailingVersionInVS2019()
      {
         var class1 = new Class1();

         Assert.IsTrue(class1.SwitchCaseThatFails("String"));
         Assert.IsTrue(class1.SwitchCaseThatFails(12));
         Assert.IsTrue(class1.SwitchCaseThatFails(12.123));
      }
   }
}
