using System;

namespace Intro
{
    class Program
    {
        // void keyword does not return anything
        // Main keyword -> program entrypoint
        static void Main(string[] args)
        {
            //declare variable type, name the variable = value
            string name = "Adam";
            int cohort = 34;

            // reassigning variables

            name = "Jisie";
            cohort = 35;

            //String concatenation
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            //string interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";
            //declare boolian variable
            bool isTheBest = cohort == 35;
            //conditionals
            if (isTheBest)
            {
                Console.WriteLine("ahh the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("not cohort, but she cool");
            }
            else
            {
                Console.WriteLine("you may want to rethink your decisions");
            }

            //Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            //foreach Loop
            foreach (int c in cohorts)
            {
                Console.WriteLine($"Cohort {c}");
            }

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            // Console.WriteLine(greeting2);
        }
    }
}