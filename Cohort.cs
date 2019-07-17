using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Cohort
    {
        public string CohortName { get; set; }

        public List<Student> StudentList { get; set; }

        public void ListStudents()
        {
            StudentList = new List<Student>();
        }

        public void AddStudent(Student FirstName)
        {
            StudentList.Add(FirstName);
        }


        public List<Instructor> InstructorList { get; set; }

        public void ListInstructors()
        {
            InstructorList = new List<Instructor>();
        }

        public void AddInstructor(Instructor InstFirstName)
        {
            InstructorList.Add(InstFirstName);
        }


        // constructor
        public Cohort(string cohortName)
        {
            CohortName = cohortName;
            // StudentList = new List<ListStudents>();
        }

    }
}