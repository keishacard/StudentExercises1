using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // OBJECTIVES:
            // Create 4, or more, exercises.
            // Create 3, or more, cohorts.
            // Create 4, or more, students and assign them to one of the cohorts.
            // Create 3, or more, instructors and assign them to one of the cohorts.
            // Have each instructor assign 2 exercises to each of the students.

            var FindRing = new Exercise("Find a mysterious ring", "CSS");
            var EscapeSpiders = new Exercise("Escape the spider tunnels", "JavaScript");
            var DragonsLair = new Exercise("Enter the dragon's lair for treasure", "C#");
            var LonelyMountain = new Exercise("Reclaim the Lonely Mountain for the Dwarves", "C#");

            var Day50 = new Cohort("Day Cohort 50");
            var Eve51 = new Cohort("Evening Cohort 51");
            var Day52 = new Cohort("Day Cohort 52");

            var Bilbo = new Student("Bilbo", "Baggins", "treasureHunter", "Day Cohort 50");
            var Thorin = new Student("Thorin", "Oakenshield", "kingUnderTheMtn", "Evening Cohort 51");
            var Fili = new Student("Fili", "Durin", "blueCloak", "Day Cohort 52");
            var Kili = new Student("Kili", "Durin", "yellowBeard", "Day Cohort 52");

            var Gandalf = new Instructor("Gandalf", "The Grey", "greyWizard", "firework mischief", "Day Cohort 50");
            var Elrond = new Instructor("Elrond", "Of Rivendale", "waterMagic", "helping hobbits", "Evening Cohort 51");
            var Beorn = new Instructor("Beorn", "Skinchanger", "bearsRcool", "transforming into a bear", "Day Cohort 52");

            // var JsExer = excercises.Where(exer => exer.ExerLang == "JavaScript");
            // foreach (string exer in excercises)
            // {
            //     Console.WriteLine($"{exer.ExerName} is a JS exercise");
            // }

            /*  PART II: List exercises for the JavaScript language by using the Where() LINQ method.*/


            List<string> excercises = new List<string>() { "Find a mysterious ring", "Escape the spider tunnels", "Enter the dragon's lair for treasure", "Reclaim the Lonely Mountain for the Dwarves" };


            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> instructors = new List<Instructor>();
            instructors.AddRange(new[] { Gandalf, Elrond, Beorn });
            IEnumerable<Instructor> Cohort32Instructors = Instructor.Where(inst => inst.Cohort == 32);

            /* List students in a particular cohort by using the Where() LINQ method.
            List instructors in a particular cohort by using the Where() LINQ method.
            //


k

            Sort the students by their last name.
            Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            How many students in each cohort?*/


        }
    }
}
