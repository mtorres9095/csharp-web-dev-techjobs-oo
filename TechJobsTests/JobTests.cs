using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests

{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestJobIDCounter1()//1 Empty
        {
            Job testingID1 = new Job();
            Assert.AreEqual(1, testingID1.JobId);
        }
        [TestMethod]
        public void TestJobIDCounter2()//2 Empty
        {
            Job testingID2 = new Job();
            Assert.AreEqual(2, testingID2.JobId);
        }

        //[TestMethod]
        //public void TestJobConstructorSetsAllFields()
        //{
        //    Job testConstructor = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
        //    Assert.AreEqual("Product tester", testConstructor.Name);
        //    Assert.AreEqual("ACME", testConstructor.EmployerName);
        //    Assert.AreEqual("Desert", testConstructor.EmployerLocation);
        //    Assert.AreEqual("Quality control", testConstructor.JobType);
        //    Assert.AreEqual("Persistence", testConstructor.JobCoreCompetency);
        //}
        //[TestMethod]
        //public void TestJobsForEquality()
        //{
            
        //    Assert.IsFalse
        //}
    }
}
