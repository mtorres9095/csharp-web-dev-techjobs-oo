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
            str1 += "------------------------------------------\n";
            str1 += $"ID: {JobId}\n";
            str1 += $"Name: {Name}\n";
            str1 += $"Employer: {EmployerName.Value}\n";
            str1 += $"Location: {EmployerLocation.Value}\n";
            str1 += $"Position Type: {JobType.Value}\n";
            str1 += $"Core Competency: {JobCoreCompetency.Value}\n";
            str1 += "------------------------------------------\n";
            return str1;
        }
    }
    }
