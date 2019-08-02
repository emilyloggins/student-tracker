using System;
using System.Collections.Generic;
using System.Linq;

namespace student_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating exercise instances
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

            // Creating cohort instances
            Cohort thirtyOne = new Cohort
            {
                Name = 31
            };
            Cohort thirtyTwo = new Cohort
            {
                Name = 32
            };

            // Creating student instances
            Student studentOne = new Student
            {
                FirstName = "Shelley",
                LastName = "Arnold",
                SlackHandle = "sarnold",
            };
            Student studentTwo = new Student
            {
                FirstName = "Emily",
                LastName = "Loggins",
                SlackHandle = "eloggins",
            };
            Student studentThree = new Student
            {
                FirstName = "Heather",
                LastName = "Cleland",
                SlackHandle = "hcleland",
            };
            Student studentFour = new Student
            {
                FirstName = "Addam",
                LastName = "Joor",
                SlackHandle = "ajoor",
            };
            Student studentFive = new Student 
            {
                FirstName = "Abby",
                LastName = "Loggins",
                SlackHandle = "aloggins",
            };

            // Creating instructor instances
            Instructor instructorOne = new Instructor
            {
                FirstName = "Brenda",
                LastName = "Long",
                SlackHandle = "blong",
                Specialty = "Lollipops"
            };
            Instructor instructorTwo = new Instructor
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "aSheaffer",
                Specialty = "Hats"
            };
            Instructor instructorThree = new Instructor
            {
                FirstName = "Bryan",
                LastName = "Nilsen",
                SlackHandle = "bnilsen",
                Specialty = "High Fives"
            };

            // Add student instances to the student list
            List<Student> students = new List<Student>();
            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);
            students.Add(studentFour);
            students.Add(studentFive);

            // Add exercise instances to the exercise list
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(dictionaries);
            exercises.Add(forLoops);
            exercises.Add(routing);
            exercises.Add(interfaces);

            // Adding instructors to the instructors list
            List<Instructor> instructors = new List<Instructor>()
            {
                instructorOne,
                instructorTwo,
                instructorThree
            };

            // Adding cohorts to the cohort list
            List<Cohort> cohorts = new List<Cohort>()
            {
                thirtyOne,
                thirtyTwo
            };

            // Assigning exercises to students
            instructorOne.AssignExercise(forLoops, studentTwo);
            instructorTwo.AssignExercise(dictionaries, studentThree);
            instructorThree.AssignExercise(routing, studentOne);
            instructorTwo.AssignExercise(interfaces, studentThree);

            // Adding students and instructors to their respective cohorts
            thirtyOne.Students.Add(studentOne);
            thirtyOne.Students.Add(studentThree);
            thirtyOne.Students.Add(studentFive);
            thirtyTwo.Students.Add(studentTwo);
            thirtyTwo.Students.Add(studentFour);
            thirtyOne.Instructors.Add(instructorOne);
            thirtyTwo.Instructors.Add(instructorTwo);
            thirtyTwo.Instructors.Add(instructorThree);

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JavascriptExercises =
            from exercise in exercises
            where exercise.Language == "Javascript"
            select exercise;

            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> CohortThirtyTwoStudents =
            from student in thirtyTwo.Students
            select student;

            // List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> CohortThirtyTwoInstructors =
            from instructor in thirtyTwo.Instructors
            select instructor;

            // Sort the students by their last name.
            IEnumerable<Student> AscendingNames = 
            from student in students
            orderby student.LastName
            select student;

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> StudentsWithoutAssignments =
            from s in students
            where s.Exercises.Count == 0
            select s;

            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<string> OverachievingStudent =
            students.Where(student => student.Exercises.Count() == students.Max(s => s.Exercises.Count())).Select(student => student.FirstName);
            
            //How many students in each cohort?
            Console.WriteLine($"Cohort 31 has {thirtyOne.Students.Count()} student(s) and {thirtyOne.Instructors.Count()} instructor(s)");
            Console.WriteLine($"Cohort 32 has {thirtyTwo.Students.Count()} student(s) and {thirtyTwo.Instructors.Count()} instructor(s)");
        }
    }
}
