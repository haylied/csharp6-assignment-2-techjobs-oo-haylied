
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
            Assert.AreEqual(new Employer("ACME"), job3.EmployerName, "Test EmployerName field");
            Assert.AreEqual(new Location("Desert"), job3.EmployerLocation, "Test EmployerLocation field");
            Assert.AreEqual(new PositionType("Quality control"), job3.JobType, "Test JobType field");
            Assert.AreEqual(new CoreCompetency("Persistence"), job3.JobCoreCompetency, "Test JobCoreCompetency field");
        }

        //[TestMethod]
        //public void TestJobsForEquality()
        //{
        //    Assert.Equals(job3, job4, "Test Equals() returns false");
        //}
    }
}

