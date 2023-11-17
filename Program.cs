﻿namespace Laboration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            int numberOfFamilyMembers = 0;
            int[] familyAges = Array.Empty<int>();
            string[] familyNames = Array.Empty <string>();
            while (menuChoice != 5)
            {
                Console.WriteLine("\n---------------------------------------------------------------\n" +
                    " Välj ett alternativ, ange ditt val genom att skriva in den siffra som motsvarar det du vill göra. \n" +
                    "1. Ange namn och ålder på familjemedlemmar. Du anger själv hur många familjemedlemmar du vill ange information om. \n" +
                    "2. Skriv ut namn på alla familjemedlemmar som du angivit. \n" +
                    "3. Skriv ut summan av åldrarna för de familjemedlemmar som du angivit. \n" +
                    "4. Skriv ut medelåldern för de familjemedlemmar som du angivit. \n" +
                    "5. Avluta programmet");
                menuChoice = int.Parse(Console.ReadLine());
                {
                    switch (menuChoice)
                     
                    {
                        case 1:
                            Console.WriteLine("Hur många familjemedlemmar vill du mata in i programmet?");
                            numberOfFamilyMembers = int.Parse(Console.ReadLine());
                            familyAges = new int[numberOfFamilyMembers];
                            familyNames = new string[numberOfFamilyMembers];
                                for (int i = 0; i < numberOfFamilyMembers; i++)
                                {
                                    Console.WriteLine($"Vad heter familjemedlem {i + 1}?");
                                    familyNames[i] = Console.ReadLine();
                                    Console.WriteLine(familyNames.Length);
                                    Console.WriteLine($"Hur gammal är {familyNames[i]}?");
                                    familyAges[i] = int.Parse(Console.ReadLine());
                                }
                            break;
                        case 2:
                            if (numberOfFamilyMembers == 0)
                                Console.WriteLine("Du har inte lagt till några familjemedlemmar än. Välj 1 i menyn för att lägga till familjemedlemmar");
                            else
                                Console.WriteLine("Dessa familjemedlemmar har du lagt till i programmet: ");
                                for (int i = 0; i < familyNames.Length; i++)
                                Console.WriteLine($"{familyNames[i]} \n");
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            System.Environment.Exit("Programmet avslutas nu.");
                        }
                    }
                }
            }
        }
    }

