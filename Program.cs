using System;

namespace CSharp.LabExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
        }

        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            string answer = "y";
            while (answer == "y" || answer == "Y")
            {
                Console.Write("Enter Length: ");
                Decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter Width: ");
                Decimal width = Convert.ToDecimal(Console.ReadLine());

                Decimal area = length * width;
                Console.WriteLine("Area: " + area);

                Decimal perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Perimeter: " + perimeter);


                Console.Write("Continue? y/n: ");
                answer = Console.ReadLine();

            }
        }

        static void Number2()
        {
            Console.WriteLine("Welcome to the Grade Calculator");
            string answer = "y";
            while (answer == "y" || answer == "Y")
            {
                Console.Write("Enter Numerical Grade: ");
                int numericalGrade = Convert.ToInt32(Console.ReadLine());

                if (numericalGrade <= 100 && numericalGrade >= 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numericalGrade <= 87 && numericalGrade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (numericalGrade <= 79 && numericalGrade >= 67)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (numericalGrade <= 66 && numericalGrade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (numericalGrade < 60 && numericalGrade >= 0)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                else
                {
                    Console.WriteLine("Please enter Grade from 0 - 100.");
                }

                    Console.Write("Continue? y/n: ");
                answer = Console.ReadLine();

            }
        }

        static void Number3()
        {
            Console.WriteLine("Welcome to Download Time Calculator!");
            Console.WriteLine("This program calculates how long it will take to download a file with a 56K analog modem");
            string answer = "y";
            while (answer == "y" || answer == "Y")
            {
                Console.Write("Enter a file size (MB): ");
                int fileSizeMB = Convert.ToInt32(Console.ReadLine());
                
                int fileSizeKB = fileSizeMB * 1024;
                double downloadSpeedinSecond = fileSizeKB / 5.2;
                int downloadSpeedHour = (int) downloadSpeedinSecond / 3600;
                int downloadSpeedMinute = (int) (downloadSpeedinSecond / 60 ) -(downloadSpeedHour * 60);
                int downloadSpeedSecond = (int) downloadSpeedinSecond - (downloadSpeedMinute * 60) - (downloadSpeedHour * 3600);

                Console.WriteLine("A '56k' modem will take {0} hours {1} minutes {2} seconds", downloadSpeedHour, downloadSpeedMinute, downloadSpeedSecond);



                Console.Write("Continue? y/n: ");
                answer = Console.ReadLine();

            }
        }

        static void Number4()
        {
            Console.Write("Enter Square Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int i, j;
            for( i = 1; i <= size; i++)
            {
                if (i <= size)
                {
                    for (j = 1; j <= size; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
