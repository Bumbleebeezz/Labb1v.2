using System.ComponentModel.Design;

namespace Labb1v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long sumOfNumbers = 0;
            char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.Write("Write a string: ");
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++) 
            {
                int counter = 0;
                string numberFound = string.Empty;
                if (!numbers.Contains(inputString[i]))
                {
                    continue;
                }
                numberFound += inputString[i]; 
                counter++;
                
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    if (!numbers.Contains(inputString[j]))
                    {
                        break;
                    }
                    numberFound += inputString[j];
                    counter++;

                    if (counter >= 3) 
                    { 
                        if (inputString[i] == inputString[j])
                        {
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
            }
            Console.WriteLine("");
            Console.WriteLine("Total = " + sumOfNumbers);
        }
    }
}