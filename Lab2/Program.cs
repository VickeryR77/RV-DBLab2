using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Build();

        }

        public static void Build()
        {
            bool beSquared = true;
            while (beSquared)
            {

                Console.WriteLine("Learn your squares and cubes up to a number of your choice!");
                int result = GetValidNumber("Please enter an integer greater than 0: ");

                Console.Clear();
                
                //We can name these text fields as strings and interpolate if necessary.

                Console.WriteLine($"{"Number",-6}{"Squared",11}{"Cubed",10}");
                Console.WriteLine($"{"======",-7}{"=======",10}{"=====",10}");

                //Attempt at another way.
                //Console.WriteLine("{0,-10} {1,6} {2,6}\t", "Number","Squared","Cubed");

                for (int i = 1; i <= result; i++)
                {

                    //Notes: In the future, break down math into temporary code and store as a value to use in a loop.
                    //Example: i*i = Squ | i*i*i = Cu
                    //Console.WriteLine($"{i,6}{Squ,10}{Cu,9});

                    Console.WriteLine($"{i,6} {i * i,10} {i * i * i,9}");

                    //Console.WriteLine("{0,-10} {1,6} {2,6}\t", i, i * i, i * i * i);
                }

                Console.WriteLine("");

                bool loop1 = true;
                while (loop1)
                {
                    Console.WriteLine("Would you like to measure up to a different integer?: (Yes / No)");
                    string answer = Console.ReadLine();
                    string lowerAnswer = answer.ToLower();
                    if (lowerAnswer == "yes" || lowerAnswer == "y")
                    {
                        Console.Clear();
                        beSquared = true;
                        loop1 = false;
                    }
                    else if (lowerAnswer == "no" || lowerAnswer == "n")
                    {
                        beSquared = false;
                        loop1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please answer correctly. (Yes / No)");

                    }

                }
            }
        }

        public static int GetValidNumber(string prompt)
        {
            int number;
            bool isValid = false;
            Console.WriteLine(prompt);

            isValid = int.TryParse(Console.ReadLine(), out number);

            while (!isValid || number <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
                Console.WriteLine("");
                isValid = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        
    }
}

