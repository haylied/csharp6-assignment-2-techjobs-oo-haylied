
using System;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1, job2, "Test that the ID are NOT the same");

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Test name field");
            Assert.AreEqual("ACME", job3.EmployerName.Value, "Test EmployerName field");
            Assert.AreEqual("Desert", job3.EmployerLocation.Value, "Test EmployerLocation field");
            Assert.AreEqual("Quality control", job3.JobType.Value, "Test JobType field");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value, "Test JobCoreCompetency field");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3, job4, "Test Equals() returns false");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.AreEqual(true, job3.ToString().StartsWith("\n"), "Job.ToString() starts with new line");
            Assert.AreEqual(true, job3.ToString().EndsWith("\n"), "Job.ToString() ends with new line");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(true, job3.ToString().Contains("ID: " + job3.Id), "ID: returns same value");
            Assert.AreEqual(true, job3.ToString().Contains("Name: " + job3.Name), "Name: returns same value");
            Assert.AreEqual(true, job3.ToString().Contains("Employer: " + job3.EmployerName), "Employer: returns same value");
            Assert.AreEqual(true, job3.ToString().Contains("Location: " + job3.EmployerLocation), "Location: returns same value");
            Assert.AreEqual(true, job3.ToString().Contains("Position Type: " + job3.JobType), "Position Type: returns same value");
            Assert.AreEqual(true, job3.ToString().Contains("Core Competency: " + job3.JobCoreCompetency), "Core Competency: returns same value");
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(true, job1.ToString().Contains("Data not available"), "ToString() handles Empty Field");
        }
    }

}