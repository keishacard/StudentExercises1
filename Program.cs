using System;

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

        }
    }
}
