
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


    }
}

