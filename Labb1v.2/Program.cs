using System.ComponentModel.Design;

namespace Labb1v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            long sumOfNumbers = 0;
            char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.Write("Write a string: ");
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++) 
            {
                string numberFound = string.Empty;
                if (!numbers.Contains(inputString[i]))
                {
                    continue;
                }
                numberFound += inputString[i]; 
                
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    if (!numbers.Contains(inputString[j]))
                    {
                        break;
                    }
                    numberFound += inputString[j];
                    

                    if (inputString[i] == inputString[j])
                    {
                        count++;
                        var beforeNumberFound = inputString.Substring(0, i);
                        var afterNumberFound = inputString.Substring(j + 1, inputString.Length - j - 1);

                        sumOfNumbers += long.Parse(numberFound);
                        Console.WriteLine("");
                        Console.Write(beforeNumberFound);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(numberFound);
                        Console.ResetColor();
                        Console.Write(afterNumberFound);

                        break;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Total = " + sumOfNumbers);
        }
    }
}