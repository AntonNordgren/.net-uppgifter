// By Anton Nordgren

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgifter_Förberedande_Kurs
{
    public class Person
    {
        private string name;
        private int health;
        private int strength;
        private int luck;

        public Person(string name)
        {
            Random rnd = new Random();
            this.name = name;
            this.health = rnd.Next(1, 100);
            this.strength = rnd.Next(1, 100);
            this.luck = rnd.Next(1, 100);
        }

        public void displayPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Luck: " + luck);
            Console.WriteLine();
        }
    }

    static class Program
    {

        static void Main(string[] args)
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Förberedande Kurs Uppgifter - Anton Nordgren");
                Console.WriteLine();
                Console.WriteLine("0. Exit program");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Print person");
                Console.WriteLine("3. Change color on text");
                Console.WriteLine("4. Todays Date");
                Console.WriteLine("5. Which is greater");
                Console.WriteLine("6. Guess the number game");
                Console.WriteLine("7. Save text to file");
                Console.WriteLine("8. Read text from file");
                Console.WriteLine("9. Math problem");
                Console.WriteLine("10. Print multiplication table");
                Console.WriteLine("11. Create arrrays and sort them");
                Console.WriteLine("12. Check if palindrome");
                Console.WriteLine("13. Print all numbers beetween start and finish");
                Console.WriteLine("14. Sort by odd and even numbers");
                Console.WriteLine("15. Adding numbers");
                Console.WriteLine("16. Create Characters");
                Console.WriteLine();

                Console.Write("Choose action to start program: ");
                string input = Console.ReadLine();

                Console.Clear();

                if(input != "")
                {

                    if (input == "0")
                    {
                        Console.WriteLine("Exiting...");
                        isRunning = false;
                        return;
                    }

                    switch (input)
                    {
                        case "1":
                            printHelloWorld();
                            break;
                        case "2":
                            printPerson();
                            break;
                        case "3":
                            toggleColorInConsole();
                            break;
                        case "4":
                            printTodaysDate();
                            break;
                        case "5":
                            whichIsGreater();
                            break;
                        case "6":
                            guessTheNumberGame();
                            break;
                        case "7":
                            writeStringToFile();
                            break;
                        case "8":
                            readTextFile();
                            break;
                        case "9":
                            mathProblem();
                            break;
                        case "10":
                            printMultiplicatoinTable();
                            break;
                        case "11":
                            createAndSortArray();
                            break;
                        case "12":
                            isPalindrome();
                            break;
                        case "13":
                            printNumbersFromTo();
                            break;
                        case "14":
                            sortByEvenAndOdd();
                            break;
                        case "15":
                            addAllNumbers();
                            break;
                        case "16":
                            createCharacters();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                }

                Console.WriteLine();
                Console.Write("Press Enter to continue: ");
                Console.ReadLine();

            } while (isRunning == true);
        }

        static void createCharacters()
        {
            Console.Write("Enter name for your character: ");
            string firstCharacterName = Console.ReadLine();

            Console.Write("Enter name for the enemy: ");
            string secondCharacterName = Console.ReadLine();

            Console.WriteLine();

            Person firstCharacter = new Person(firstCharacterName);
            Person secondCharacter = new Person(secondCharacterName);

            Console.WriteLine("Your Character");

            firstCharacter.displayPerson();

            Console.WriteLine("Enemy Character");

            secondCharacter.displayPerson();

        }

        // Uppgift 15
        static void addAllNumbers()
        {
            List<int> numbersInInts = new List<int>();

            bool validInput = false;
            string[] numbersInStrings;

            int sum = 0;


            while (validInput == false)
            {
                string input = "";

                Console.Write("Enter numbers to see the summary (use , to separate them): ");
                input = Console.ReadLine();

                numbersInStrings = input.Split(",");

                foreach (string i in numbersInStrings)
                {
                    try
                    {
                        numbersInInts.Add(Int32.Parse(i));
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input");
                        numbersInInts.Clear();
                        break;
                    }
                    if (i == numbersInStrings.Last())
                    {
                        validInput = true;
                    }
                }

            }

            foreach (int nr in numbersInInts)
            {
                sum += nr;
            }

            Console.WriteLine("Sum is: " + sum);
        }


        // Uppgift 14
        static void sortByEvenAndOdd()
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers  = new List<int>();
            List<int> numbersInInts = new List<int>();
            
            bool validInput = false;
            string[] numbersInStrings;


            while (validInput == false)
            {
                string input = "";

                Console.Write("Enter numbers to see which are odd or even (use , to separate them): ");
                input = Console.ReadLine();

                numbersInStrings = input.Split(",");

                foreach (string i in numbersInStrings)
                {
                    try
                    {
                        numbersInInts.Add(Int32.Parse(i));
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input");
                        numbersInInts.Clear();
                        break;
                    }
                    if (i == numbersInStrings.Last())
                    {
                        validInput = true;
                    }
                }

            }

            foreach (int nr in numbersInInts)
            {
                if (nr % 2 == 0)
                {
                    evenNumbers.Add(nr);
                }
                else
                {
                    oddNumbers.Add(nr);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Even Numbers");
            foreach (int nr in evenNumbers)
            {
                Console.Write(nr + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Odd Numbers");
            foreach (int nr in oddNumbers)
            {
                Console.Write(nr + " ");
            }

            Console.WriteLine();

        }

        // Uppgift 13
        static void printNumbersFromTo()
        {
            int nr1 = 0, nr2 = 0;
            bool nr1Assigned = false, nr2Assigned = false;
            while (nr1Assigned == false)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    nr1 = Convert.ToInt32(Console.ReadLine());
                    nr1Assigned = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            while (nr2Assigned == false)
            {
                try
                {
                    Console.Write("Enter second number: ");
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    nr2Assigned = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            int bigNr, smallNr = 0;

            if(nr1 == nr2)
            {
                Console.WriteLine("They have the same value. Try again");
            }
            else
            {
                if(nr1 > nr2)
                {
                    bigNr = nr1;
                    smallNr = nr2;
                }
                else
                {
                    bigNr = nr2;
                    smallNr = nr1;
                }

                for(int i = smallNr + 1; i <= bigNr - 1; i++)
                {
                    Console.WriteLine(i);
                }
            }



        }

        // Uppgift 12
        static void isPalindrome()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string trimmedInput = removeCharacters(input, new char[] { ' ', '*', '.', ',', '\'', '!', '?' }).ToLower();

            bool result = true;

            for (int i = 0, j = trimmedInput.Length - 1; i < trimmedInput.Length; i++, j--)
            {

                if (trimmedInput[i] != trimmedInput[j])
                {
                    result = false;
                    break;
                }

            }

            Console.WriteLine();

            if (result == false)
            {
                Console.WriteLine("This is not a Palindrome");
            }
            else
            {
                Console.WriteLine("This is a Palindrome!");
            }
        }

        // Uppgift 11
        static void createAndSortArray()
        {
            int[] randomArray = new int[10];
            int[] sortedArray = new int[10];

            Random rnd = new Random();

            for(int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Random Array");

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(randomArray[i] + " ");
            }

            Console.WriteLine();

            sortedArray = randomArray.OrderBy(x => x).ToArray();

            Console.WriteLine();

            Console.WriteLine("Sorted Array");

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.WriteLine();
        }

        // Uppgift 10
        static void printMultiplicatoinTable()
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for(int y = 1; y <= 10; y++)
                {
                    Console.Write(i * y + "\t");
                }
                Console.WriteLine();
            }

        }

        // Uppgift 9
        static void mathProblem()
        {
            double number = 0;

            while (number == 0)
            {
                Console.Write("Enter a number (use decimal number): ");
                string input = Console.ReadLine();

                try {
                    number = Double.Parse(input);
                    if(number % 1 == 0)
                    {
                        Console.WriteLine("Does not contain a decimal.");
                        number = 0;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("((" + "√" + number + ")^2)^10 = " + Math.Pow(Math.Pow(Math.Sqrt(number), 2), 10));
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid");
                }
            }

        }

        // Uppgift 8
        static void readTextFile()
        {
            Console.Write("Enter textfile to read: ");
            string input = Console.ReadLine();

            if(File.Exists(input))
            {
                Console.WriteLine("Reading from file: " + input);
                Console.WriteLine();
                Console.Write(File.ReadAllText(input));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Couldn't read file.");
            }
        }

        // Uppgift 7
        static async void writeStringToFile()
        {
            Console.Write("Enter text for the file: ");
            string textinput = Console.ReadLine();

            Console.Write("Enter name of file (don't add filetype): ");
            string fileNameinput = Console.ReadLine();

            await File.WriteAllTextAsync(fileNameinput + ".txt", textinput);
            Console.WriteLine("Wrote to file: " + fileNameinput + ".txt");
        }

        // Uppgift 6
        static void guessTheNumberGame()
        {
            Random rnd = new Random();
            int theNumber = rnd.Next(1, 101);
            bool numberFound = false;
            int counter = 0;

            do
            {
                Console.Write("Guess number from 1-100: ");

                string input = Console.ReadLine();
                int guess;
                bool isValidNumber = Int32.TryParse(input, out guess);


                if(isValidNumber == false)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    if(guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Can not be smaller than 1 or greater than 100");
                    }
                    else
                    {
                        counter++;

                        if(guess < theNumber)
                        {
                            Console.WriteLine("The Number is greater");
                        }
                        else if(guess > theNumber)
                        {
                            Console.WriteLine("The Number is smaller");
                        }
                        else
                        {
                            if(counter == 1)
                            {
                                Console.WriteLine("You got it on the first try! Lucky! The right number was " + theNumber.ToString() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You found the number! The right number was " + theNumber.ToString() + ".");
                                Console.WriteLine("It took you " + counter + " tries to get it right.");
                            }
                            numberFound = true;
                        }
                    }
                }

            } while (numberFound == false);

        }

        // Uppgift 5
        static void whichIsGreater()
        {
            double nr1 = 0, nr2 = 0;

            while(nr1 == 0)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    nr1 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            while (nr2 == 0)
            {
                try
                {
                    Console.Write("Enter second number: ");
                    nr2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            if(nr1 > nr2)
            {
                Console.WriteLine(nr1 + " > " + nr2);
            }
            else if(nr2 > nr1)
            {
                Console.WriteLine(nr2 + " > " + nr1);
            }
            else
            {
                Console.WriteLine("They are equal");
            }


        }

        // Uppgift 4
        static void printTodaysDate()
        {
            Console.WriteLine("Today's Date: " + DateTime.UtcNow.ToString("MM-dd-yyyy"));
        }

        // Uppgift 3
        static void toggleColorInConsole()
        {
            if(Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Changed color to yellow");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Changed color to gray");
            }
        }

        // Uppgift 2
        static void printPerson()
        {
            string firstName, lastName, inputAge;
            int age = -1;
            Console.Write("Enter firstname: ");
            firstName = Console.ReadLine();

            Console.Write("Enter lastname: ");
            lastName = Console.ReadLine();

            while(age == -1)
            {
                try
                {
                    Console.Write("Enter age: ");
                    inputAge = Console.ReadLine();
                    age = Int32.Parse(inputAge);
                }
                catch
                {
                    Console.WriteLine("Not a valid number use a whole number.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Firstname: " + firstName);
            Console.WriteLine("Lastname: " + lastName);
            Console.WriteLine("Age: " + age);
        }

        // Uppgift 1
        static void printHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        public static string removeCharacters(this string source, IEnumerable<char> chars)
        {
            return new String(source.Where(x => !chars.Contains(x)).ToArray());
        }

    }
}