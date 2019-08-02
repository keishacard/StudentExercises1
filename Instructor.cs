using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Instructor
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string InstSlack { get; set; }

        public string cohort { get; set; }

        public string InstSpecialty { get; set; }


        // method
        // public void AssignExercise()
        // {
        //     assign exercise to student
        // }

        // constructor
        public Instructor(string firstName, string lastName, string instSlack, string Cohort, string instSpecialty)
        {
            FirstName = firstName;
            LastName = lastName;
            InstSlack = instSlack;
            Cohort = cohort;
            InstSpecialty = instSpecialty;
        }

    }
}