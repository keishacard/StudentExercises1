using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentSlack { get; set; }

        public string Cohort { get; set; }

        public List<Exercise> StudExerList { get; set; }

        public void StudentExer()
        {
            StudExerList = new List<Exercise>();
        }

        public void AddExercise(Exercise ExerName)
        {
            StudExerList.Add(ExerName);
        }

        // constructor
        public Student(string firstName, string lastName, string studentSlack, string studentCohort)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentSlack = studentSlack;
            Cohort = studentCohort;
            StudExerList = new List<Exercise>();
        }

    }
}