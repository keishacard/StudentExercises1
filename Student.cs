using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentSlack { get; set; }

        public string StudentCohort { get; set; }

        public List<Exercise> StudExerList { get; set; }

        public void StudentExer()
        {
            StudExerList = new List<Exercise>();
        }

        public void AddExercise(Exercise ExerName)
        {
            StudExerList.Add(ExerName);
        }

        public void ListExercises()
        {
            foreach (Exercise ex in StudExerList)
            {
                Console.WriteLine(ex.ExerName);
            }
        }

        // constructor
        public Student(string firstName, string lastName, string studentSlack, string studentCohort)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentSlack = studentSlack;
            StudentCohort = studentCohort;
            StudExerList = new List<Exercise>();
        }

    }
}