using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Instructor
    {

        public string InstFirstName { get; set; }

        public string InstLastName { get; set; }

        public string InstSlack { get; set; }

        public string InstCohort { get; set; }

        public string InstSpecialty { get; set; }


        // method
        public void AssignExercise(Student studName, Exercise exName)
        {
            studName.AddExercise(exName);
        }

        // constructor
        public Instructor(string firstName, string lastName, string instSlack, string instCohort, string instSpecialty)
        {
            InstFirstName = firstName;
            InstLastName = lastName;
            InstSlack = instSlack;
            InstCohort = instCohort;
            InstSpecialty = instSpecialty;
        }

    }
}