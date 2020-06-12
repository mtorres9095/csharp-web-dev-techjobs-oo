using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests

{
    [TestClass]
    public class JobTests
    {
        readonly Job testingId1 = new Job();
        readonly Job testingId2 = new Job();
        readonly Job testConstructor = new Job("Product tester", new Employer("Acme"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        readonly Job testOne = new Job("Product tester", new Employer("Acme"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        // readonly Job testTwo = new Job("Product tester", new Employer("Acme"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        [TestMethod]
        public void TestJobIDCounter1()//1 Empty
        {
            Assert.AreEqual(1, testingId1.JobId);
            Assert.AreEqual(2, testingId2.JobId);
            Assert.IsTrue(testingId2.JobId != testingId1.JobId);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {       
            Assert.IsTrue("Product tester" == testConstructor.Name);
            Assert.IsTrue("Acme" == testConstructor.EmployerName.Value);
            Assert.IsTrue("Desert" == testConstructor.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == testConstructor.JobType.Value);
            Assert.IsTrue("Persistence" == testConstructor.JobCoreCompetency.Value);
        }
        //[TestMethod]
        //public void TestJobsForEquality()
        //{
        //    Assert.AreEqual(testingId2.JobId, testingId1.JobId);
        //}
        [TestMethod]
        public void TestJobsToString()
        {
            Assert.IsNotNull(testOne.ToString()); 
        }


    }
}
