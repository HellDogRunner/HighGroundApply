using System;
using System.Collections.Generic;

namespace NumbersService
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Введите номер задания 1-3");
            userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out int taskNumber))
            {
                switch (taskNumber)
                {
                    case 1:
                        var task1Data = new Dictionary<int, string>()
                        {
                            {15 , "fizz - buzz"},
                            {3 , "fizz"},
                            {5 , "buzz"},
                        };
                        Task(task1Data, 1);
                        break;
                    case 2:
                        var task2Data = new Dictionary<int, string>()
                        {
                            {15 , "fizz - buzz"},
                            {3 , "fizz"},
                            {5 , "buzz"},
                            {4 , "muzz"},
                            {7 , "guzz"},
                        };
                        Task(task2Data, 2);
                        break;
                    case 3:
                        var task3Data = new Dictionary<int, string>()
                        {
                            {15 , "good - boy"},
                            {3 , "dog"},
                            {4 , "muzz"},
                            {7 , "guzz"},
                            {5 , "cat"},
                        };
                        Task(task3Data, 3);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы неверно указали номер задания");
                return;
            }
        }

        private static void Task(Dictionary<int, string> values, int taskNumber) 
        {
            Console.WriteLine("Введите набор чисел через пробел");
            string userInput = Console.ReadLine();

            string[] splittedInput = userInput.Split(' ');
            List<string> programmOutput = new List<string>();

            foreach (string input in splittedInput)
            {
                int counter = 0;
                if (!int.TryParse(input, out int number))
                {
                    continue;
                }

                foreach (var valuePair in values)
                {
                    if ((number % valuePair.Key == 0))
                    {
                        counter++;
                        if (counter > 1)
                        {
                            if (valuePair.Key == 3 || valuePair.Key == 5)
                            {
                                continue;
                            }
                            programmOutput.Add("- " + valuePair.Value);
                            continue;
                        }
                        programmOutput.Add(valuePair.Value);
                    }
                }
                if (counter < 1)
                {
                    programmOutput.Add(number.ToString());
                }

            }
            string outputString = string.Join(' ', programmOutput);
            Console.WriteLine(outputString);
        }
    }
}
