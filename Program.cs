using System;
using System.Collections.Generic;

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
            Student studentOne = new Student
            {
                FirstName = "Shelley",
                LastName = "Arnold",
                SlackHandle = "sarnold",
                Cohort = 32
            };
            Student studentTwo = new Student
            {
                FirstName = "Emily",
                LastName = "Loggins",
                SlackHandle = "eloggins",
                Cohort = 32
            };
            Student studentThree = new Student
            {
                FirstName = "Heather",
                LastName = "Cleland",
                SlackHandle = "hcleland",
                Cohort = 32
            };

            List<Student> students = new List<Student>();
            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(dictionaries);
            exercises.Add(forLoops);
            exercises.Add(routing);
            exercises.Add(interfaces);
        }
    }
}
