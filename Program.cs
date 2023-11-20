namespace Laboration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här deklareras de variabler och arrays som kommer användas i programmet.
            int menuChoice = 0;
            int numberOfFamilyMembers = 0;
            double sumOfAges = 0;
            double meanOfAges = 0;
            double[] familyAges = Array.Empty<double>();
            string[] familyNames = Array.Empty <string>();
            while (menuChoice != 5)
            {
                Console.WriteLine("\n---------------------------------------------------------------\n" +
                    " Välj ett alternativ, ange ditt val genom att skriva in den siffra som motsvarar det du vill göra. \n" +
                    "1. Ange namn och ålder på familjemedlemmar. Du anger själv hur många familjemedlemmar du vill ange information om. \n" +
                    "2. Skriv ut namn på alla familjemedlemmar som du angivit. \n" +
                    "3. Skriv ut summan av åldrarna för de familjemedlemmar som du angivit. \n" +
                    "4. Skriv ut medelåldern för de familjemedlemmar som du angivit. \n" +
                    "5. Avluta programmet \n---------------------------------------------------------------\n");
                // Här läser programmet in vilket menyval som användaren gör och lagrar inputen i variabeln menuChoice. Baserat på vilket val användaren gör kommer
                // olika case i switchsatsen exekveras. 
                menuChoice = int.Parse(Console.ReadLine());
                {
                    switch (menuChoice)
                     
                    {
                        // Array.Clear har lagts in i början av case 1 för att om användaren kör programmet flera gånger och väljer alternativ 1 igen
                        // så vill jag att familjemedlemmars ålder ska lagras i en tom array, inte läggas på de värden som redan fanns lagrade.  
                        case 1:
                            Console.WriteLine("Hur många familjemedlemmar vill du mata in i programmet?");
                            numberOfFamilyMembers = int.Parse(Console.ReadLine());
                            familyAges = new double[numberOfFamilyMembers];
                            familyNames = new string[numberOfFamilyMembers];
                                for (int i = 0; i < numberOfFamilyMembers; i++)
                                {
                                    Console.WriteLine($"Vad heter familjemedlem {i + 1}?");
                                    familyNames[i] = Console.ReadLine();
                                    Console.WriteLine(familyNames.Length);
                                    Console.WriteLine($"Hur gammal är {familyNames[i]}?");
                                    familyAges[i] = Convert.ToDouble(Console.ReadLine());
                                }
                            break;
                        case 2:
                            if (numberOfFamilyMembers == 0)
                                Console.WriteLine("\n Du har inte lagt till några familjemedlemmar än. Välj 1 i menyn för att lägga till familjemedlemmar \n");
                            else
                            {
                                Console.WriteLine("Dessa familjemedlemmar har du lagt till i programmet: ");
                                for (int i = 0; i < familyNames.Length; i++)
                                    Console.WriteLine($"{familyNames[i]} \n");
                            }
                            break;
                            // Precis som i case 1 finns en sats tilldelar variabeln sumOfAges värdet 0 för varje gång case 3 körs. 
                        case 3:
                            if (numberOfFamilyMembers == 0)
                                Console.WriteLine("\n Du har inte lagt till några familjemedlemmar än. Välj 1 i menyn för att lägga till familjemedlemmar \n");
                            else
                            {
                                sumOfAges = 0;
                                {
                                    for (int i = 0; i < familyAges.Length; i++)
                                        sumOfAges += familyAges[i];
                                }
                                Console.WriteLine($"\n Summan av de familjemedlemmar du har angivit är: {sumOfAges:#} \n");
                            }
                            break;
                        // Precis som i case 1 finns en sats tilldelar variabeln meanOfAges värdet 0 för varje gång case 4 körs. 
                        case 4:
                            if (numberOfFamilyMembers == 0)
                                Console.WriteLine("\n Du har inte lagt till några familjemedlemmar än. Välj 1 i menyn för att lägga till familjemedlemmar \n");
                            else
                            {
                                meanOfAges = 0;
                                {
                                    for (int i = 0; i < familyAges.Length; i++)
                                        meanOfAges += familyAges[i];
                                }
                                Console.WriteLine($"\n Medelåldern för de familjemedlemmar du har angivit är: {meanOfAges / numberOfFamilyMembers:#.##}");
                            }
                            break;
                        }
                    }
                }
            if (menuChoice == 5)
            {
                Console.WriteLine("\n Programmet avslutas nu. \n");
            }
            }
        }
    }

