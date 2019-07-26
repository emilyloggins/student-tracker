using System;

namespace student_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise dictionaries = new Exercise
            {
                Name = "Dictionaries",
                Language = "C#"
            };
            Exercise forLoops = new Exercise
            {
                Name = "For Loops",
                Language = "Javascript"
            };
            Exercise routing = new Exercise
            {
                Name = "Routing",
                Language = "React"
            };
            Exercise interfaces = new Exercise
            {
                Name = "Interfaces",
                Language = "C#"
            };
            Cohort twentyNine = new Cohort
            {
                Name = 29
            };
            Cohort thirtyOne = new Cohort
            {
                Name = 31
            };
            Cohort thirtyTwo = new Cohort
            {
                Name = 32
            };
        }
    }
}
