using System;
using System.Collections.Generic;

namespace student_tracker
{
    class Cohort
    {
        public int Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}