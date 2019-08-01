using System;
using System.Collections.Generic;

namespace student_tracker
{
    class Student : NSSPerson
    {
        public string SlackHandle { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}