using System;
using System.Collections.Generic;
using System.Linq;

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
            Instructor instructorOne = new Instructor
            {
                FirstName = "Brenda",
                LastName = "Long",
                SlackHandle = "blong",
                Cohort = 34,
                Specialty = "Lollipops"
            };
            Instructor instructorTwo = new Instructor
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "aSheaffer",
                Cohort = 32,
                Specialty = "Hats"
            };
            Instructor instructorThree = new Instructor
            {
                FirstName = "Bryan",
                LastName = "Nilsen",
                SlackHandle = "bnilsen",
                Cohort = 34,
                Specialty = "High Fives"
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

            instructorOne.AssignExercise(forLoops, studentTwo);
            instructorTwo.AssignExercise(dictionaries, studentThree);
            instructorThree.AssignExercise(routing, studentOne);
            instructorTwo.AssignExercise(interfaces, studentThree);

            List<Instructor> instructors = new List<Instructor>()
            {
                instructorOne,
                instructorTwo,
                instructorThree
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                twentyNine,
                thirtyOne,
                thirtyTwo
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JavascriptExercises =
            from exercise in exercises
            where exercise.Language == "Javascript"
            select exercise;

            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> CohortThirtyTwoStudents =
            from student in students
            where student.Cohort == 32
            select student;

            // List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> CohortThirtyTwoInstructors =
            from instructor in instructors
            where instructor.Cohort == 32
            select instructor;

            // Sort the students by their last name.
            IEnumerable<Student> AscendingNames = 
            from student in students
            orderby student.LastName
            select student;

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Student student4 = new Student
            {
                FirstName = "Addam",
                LastName = "Joor",
                SlackHandle = "ajoor",
                Cohort = 32
            };
            Student student5 = new Student 
            {
                FirstName = "Abby",
                LastName = "Loggins",
                SlackHandle = "aloggins",
                Cohort = 29
            };

            students.Add(student4);
            students.Add(student5);

            IEnumerable<Student> StudentsWithoutAssignments =
            from s in students
            where s.Exercises.Count == 0
            select s;

            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<string> OverachievingStudent =
            students.Where(student => student.Exercises.Count() == students.Max(s => s.Exercises.Count())).Select(student => student.FirstName);

            Console.WriteLine($"Cohort 32:");
            foreach (Student s in CohortThirtyTwoStudents)
            {
                Console.WriteLine($"{s.FirstName}");
            }
        }
    }
}
