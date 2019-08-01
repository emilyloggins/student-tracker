using System;
using System.Collections.Generic;

namespace student_tracker
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}