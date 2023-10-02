using System;
namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public string? Name { get; set; }
        public Employer? EmployerName { get; set; }
        public Location? EmployerLocation { get; set; }
        public PositionType? JobType { get; set; }
        public CoreCompetency? JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            List<string> values = new List<string> {Name, EmployerName?.ToString(), EmployerLocation?.ToString(), JobType?.ToString(), JobCoreCompetency?.ToString() };
            List<string> output = new List<string> {};

            foreach(string? value in values)
            {
                if (value == null)
                {
                    output.Add("Data Not Available\n");
                }
                else
                {
                    output.Add(value + "\n");
                }

            }

            string jobID = "ID: " + Id + "\n";
            string name = "Name: " + output[0];
            string employer = "Employer: " + output[1];
            string location = "Location: " + output[2];
            string positionType = "Position Type: " + output[3];
            string coreCompetency = "Core Competency: " + output[4];
            
            return "\n" + jobID + name + employer + location + positionType
            + coreCompetency;

        }


    }
}

