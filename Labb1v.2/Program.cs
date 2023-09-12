using System.ComponentModel.Design;

namespace Labb1v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren efter en sträng 
            Console.Write("Write a string: ");
            // Deklarera en variabel som sparar inputen
            string inputString = Console.ReadLine();

            // Deklare en variabel, typ long, som håller den totala summan av alla hittade nummersträngar
            long sumOfNumbers = 0;
            // Skapa en array som innehåller alla godkända tecken 0 - 9
            char[] acceptableChar = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // Loppa igenom varje tecken i (inputString)
            for (int i = 0; i < inputString.Length; i++) 
            {
                // Deklarera en variabel som håller den nummersträngen som hittats, nollställs varje gång (i) ökar med 1
                string numberFound = string.Empty;
                // Deklarera en variabel, en counter som håller koll på antalet tecken i numberFound
                int counter = 0;

                // Om värdet på plats (i) inte finns med i (acceptableChar)
                if (!acceptableChar.Contains(inputString[i]))
                {
                    // Öka (i) med 1 och börja om loop (i)
                    continue;
                }
                // Annars lägg till värdet på plats (i)
                numberFound += inputString[i];
                // Öka couter med 1
                counter++;
                
                // Loopa igenom nästkommande tecken från (i)
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    // Om värdet  på plats (j) finns med i (acceptableChar)
                    if (!acceptableChar.Contains(inputString[j]))
                    {
                        // Avbryt j loopen
                        break;
                    }
                    // Annars lägg till värdet på plats (j) i (numberFound)
                    numberFound += inputString[j];
                    // Öka counter med 1
                    counter++;

                    // Om (counter) är mer eller mindre än 3
                    if (counter >= 3) 
                    { 
                        // Om värdet på plats (i) är samma som värdet på plats (j)
                        if (inputString[i] == inputString[j])
                        {
                            // Deklarera en variabel som innehåller en substräng från inputString[0] till inputString[i]
                            var beforeNumberFound = inputString.Substring(0, i);
                            // Deklarera en variabel som innehåller en substräng från inputString[j + 1] till sista tecknet i (inputString)
                            var afterNumberFound = inputString.Substring(j + 1, inputString.Length - j - 1);

                            // Konvertera (numberFound) till long och spara det i (SumOfNumbers)
                            sumOfNumbers += long.Parse(numberFound);
                            // Skapa ny rad för nästkommande utskrift
                            Console.WriteLine("");
                            // Skriv ut (beforeNumberFound)
                            Console.Write(beforeNumberFound);
                            // Ändra färgen på kommande utskrift
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            // Skriv ut (numberFound)
                            Console.Write(numberFound);
                            // Återställ färgen till default
                            Console.ResetColor();
                            // Skriv ut (afterNumberFound)
                            Console.Write(afterNumberFound);

                            // Avbryt (i) loopen
                            break;
                        }
                    }
                }
            }
            // Skapa ny rad för kommande utskrift
            Console.WriteLine("");
            // Skriv ut den totala summan av alla nummersträngar, (sumOfNumbers)
            Console.WriteLine("Total = " + sumOfNumbers);
        }
    }
}