using System;
namespace TechJobsOO
{
    public class Job
    {
        //public int Id { get; }
        //private static int nextId = 1;
        private static int jobId = 1;

        public int JobId { get; set; }
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency) 
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
            return obj is Job job && JobId == job.JobId;//Check,
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(JobId);
        }

    }
}
