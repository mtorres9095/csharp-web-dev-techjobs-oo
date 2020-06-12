using System;
namespace TechJobsOO
{
    public class Job 
    {
        //public int Id { get; }
        //private static int nextId = 1;
        private static int jobId = 1;

        public int JobId { get; }
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()  
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        public Job()
        {
            JobId = jobId;
            jobId++;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job && JobId == job.JobId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(JobId);
        }

        public override string ToString()
        {
            string str1 = "";
            str1 += "------------------------------------------";
            str1 += $"ID: {JobId}";  
            str1 += $"Name: {Name}";
            str1 += $"Employer: {EmployerName.Value}";
            str1 += $"Location: {EmployerLocation.Value}";
            str1 += $"Position Type: {JobType.Value}";
            str1 += $"Core Competency: {JobCoreCompetency.Value}";
            str1 += "------------------------------------------";
            return str1;
        }
    }
}
