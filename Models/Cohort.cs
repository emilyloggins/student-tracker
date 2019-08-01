using System;
using System.Collections.Generic;

namespace student_tracker
{
    class Cohort
    {
        public int Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}