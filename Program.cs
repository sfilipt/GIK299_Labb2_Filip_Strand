namespace Laboration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            while (menuChoice != 5)
            {
                Console.WriteLine("/n------------------" +
                    " Välj ett alternativ, ange ditt val genom att skriva in den siffra som motsvarar det du vill göra." +
                    "1. Ange namn och ålder på familjemedlemmar. Du anger själv hur många familjemedlemmar du vill ange information om." +
                    "2. Skriv ut namn på alla familjemedlemmar som du angivit." +
                    "3. Skriv ut summan av åldrarna för de familjemedlemmar som du angivit." +
                    "4. Skriv ut medelåldern för de familjemedlemmar som du angivit." +
                    "5. Avluta programmet");
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice) 
                {
                    case 1: int numberOfFamilyMembers = int.Parse(Console.ReadLine());
                        string [] familyNames = new string[numberOfFamilyMembers];
                        string[] familyAges = new int[numberOfFamilyMembers];
                        break;
                } 
                    
            }
        }
    }
}