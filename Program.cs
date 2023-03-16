using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the total number of scripts to be marked.
            Console.Write("Enter the total number of scripts to be marked: ");
            int totalScripts = Convert.ToInt32(Console.ReadLine());
            if (totalScripts <= 0)
            {
                Console.WriteLine("The total number of scripts must be greater than 0.");
                return;
            }

            // Prompt the user to enter the number of questions constituting the test.
            Console.Write("Enter the number of questions constituting the test (between 1 and 10): ");
            int numQuestions = Convert.ToInt32(Console.ReadLine());
            if (numQuestions < 1 || numQuestions > 10)
            {
                Console.WriteLine("The number of questions must be between 1 and 10.");
                return;
            }

            // Prompt the user to enter the subtotal of each question.
            int[] subtotals = new int[numQuestions];
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"Enter the subtotal of question {i + 1}: ");
                subtotals[i] = Convert.ToInt32(Console.ReadLine());
                if (subtotals[i] <= 0)
                {
                    Console.WriteLine("Each subtotal must be greater than 0.");
                    return;
                }
            }

            // Prompt the user to enter the number of lecturers who are going to mark the scripts.
            Console.Write("Enter the number of lecturers who are going to mark the scripts: ");
            int numLecturers = Convert.ToInt32(Console.ReadLine());
            if (numLecturers <= 0)
            {
                Console.WriteLine("The number of lecturers must be greater than 0.");
                return;
            }

            // Calculate the total marks for the test.
            int totalMarks = 0;
            foreach (int subtotal in subtotals)
            {
                totalMarks += subtotal;
            }

            // Calculate the number of marks each lecturer will be responsible for.
            int marksPerLecturer = totalMarks / numLecturers;

            // Calculate the estimated time it will take each lecturer to finish marking their allocated scripts.
            int secondsPerMark = 10;
            int totalSecondsPerLecturer = marksPerLecturer * secondsPerMark;
            int hours = totalSecondsPerLecturer / 3600;
            int minutes = (totalSecondsPerLecturer % 3600) / 60;
            int remainingSeconds = totalSecondsPerLecturer % 60;
            if (remainingSeconds > 30 && remainingSeconds < 60)
            {
                minutes++;
            }

            // Display the results.
            Console.WriteLine($"Each lecturer will mark {marksPerLecturer} scripts.");
            Console.WriteLine($"Estimated time to finish marking: {hours} hours and {minutes} minutes.");
        }
    }
}



