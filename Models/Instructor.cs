using System;

namespace student_tracker
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public string Specialty { get; set; }
        public void AssignExercise (Exercise exercise, Student student) {
            student.Exercises.Add(exercise);
        }
    }
}