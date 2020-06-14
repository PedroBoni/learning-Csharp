using System;

namespace exercise01
{
    class Program
    {
        
        static void Main()
        {
            //declaring variables
            int i = 0;
            string programRun;
            bool result,nameTrue = false;
            Console.WriteLine("---------------------- Progam List ----------------------");
            Console.WriteLine("| - InformationsUser or Ex01");
            Console.WriteLine("| - IntDouble or Ex02");
            Console.WriteLine("| - IntSquare or Ex03");
            Console.WriteLine("| - Equation01 or Ex04 -> A² * 5 – C / (B – A % 4)");
            Console.WriteLine("| - TestAdulthood or Ex05");
            Console.WriteLine("| - BRLtoUSD or Ex06");
            Console.WriteLine("| - NamesInfos or Ex07");
            Console.WriteLine("| - BRLtoEURandUSD or Ex08");
            Console.WriteLine("| - InvertVariables or Ex09");
            Console.WriteLine("| - LogicalEquation or Ex10 -> ");
            Console.WriteLine("| - Exit ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.Write("| Enter the name of the program to run: ");
            programRun = Console.ReadLine();
            result = int.TryParse(programRun, out i);
            while (result)
            {
                Console.WriteLine("| Name cannot be a number!");
                Console.Write("| Your name: ");
                programRun = Console.ReadLine();
                result = int.TryParse(programRun, out i);
            }
            Console.WriteLine();
            while (!nameTrue)
            {
                if (programRun == "InformationsUser" || programRun == "Ex01")
                {
                    InformationsUser();
                    nameTrue = true;
                }
                if (programRun == "IntDouble" || programRun == "Ex02")
                {
                    IntDouble();
                    nameTrue = true;
                }
                if (programRun == "IntSquare" || programRun == "Ex03")
                {
                    IntSquare();
                    nameTrue = true;
                }
                if (programRun == "Equation01" || programRun == "Ex04")
                {
                    Equation01();
                    nameTrue = true;
                }
                if (programRun == "TestAdulthood" || programRun == "Ex05")
                {
                    TestAdulthood();
                    nameTrue = true;
                }
                if (programRun == "BRLtoUSD" || programRun == "Ex06")
                {
                    BRLtoUSD();
                    nameTrue = true;
                }
                if (programRun == "NamesInfos" || programRun == "Ex07")
                {
                    NameInfos();
                    nameTrue = true;
                }
                if (programRun == "BRLtoEURandUSD" || programRun == "Ex08")
                {
                    BRLtoEURandUSD();
                    nameTrue = true;
                }
                if (programRun == "InvertVariables" || programRun == "Ex09")
                {
                    InvertVariables();
                    nameTrue = true;
                }
                if (programRun == "LogicalEquation" || programRun == "Ex10")
                {
                    LogicalEquation();
                    nameTrue = true;
                }
                if (programRun == "Exit")
                {
                    Console.WriteLine("| Any key to exit");
                    Console.ReadKey();
                    nameTrue = true;
                }
                if (!nameTrue)
                {
                    Console.WriteLine("The program name does not match!");
                    Console.Write("| Enter the name of the program to run: ");
                    programRun = Console.ReadLine();
                    while (result)
                    {
                        Console.WriteLine("| Name cannot be a number!");
                        Console.Write("| Your name: ");
                        programRun = Console.ReadLine();
                        result = int.TryParse(programRun, out i);
                    }
                }
            }
        }
        static void InformationsUser()
         { 
            string name, city, testNumber;
            int age,i = 0;
            bool result = false;
            //ask information
            Console.WriteLine("----------------- Your user information -----------------");
            Console.Write("| Your name:");
            name = Console.ReadLine();
            //testing if it's a text
            result = int.TryParse(name, out i);
            while (result)
            {
                Console.WriteLine("| Name cannot be a number!");
                Console.Write("| Your name: ");
                name = Console.ReadLine();
                result = int.TryParse(name, out i);
            }
            Console.WriteLine();
            Console.Write("| Your age: ");
            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Age not be a text!");
                Console.Write("| Your age: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            age = int.Parse(testNumber);
            Console.WriteLine();
            Console.Write("| The city you live: ");
            city = Console.ReadLine();
            //testing if it's a text
            result = int.TryParse(city, out i);
            while (result)
            {
                Console.WriteLine("| City cannot be a number!");
                Console.Write("| The city you live: ");
                city = Console.ReadLine();
                result = int.TryParse(city, out i);
            }
            Console.WriteLine();
            //printing results
            Console.WriteLine("------------------- Your Informations -------------------");
            Console.WriteLine();
            Console.WriteLine("| Your name is " + name + ".");
            Console.WriteLine();
            Console.WriteLine("| You are " + age + " years old.");
            Console.WriteLine();
            Console.WriteLine("| You live in " + city + ".");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();          
        }
        static void IntDouble()
        {
            //declaring variables
            int number,i = 0;
            string testNumber;
            bool result;
            Console.WriteLine("----------------------- Int Double ----------------------");
            Console.WriteLine();
            Console.Write("| Enter an integer: ");
            
            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter an integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            number = int.Parse(testNumber);
            //result
            Console.WriteLine();
            Console.WriteLine("| Double " + number + " is " + (number * 2) + ".");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void IntSquare()
        {
            int number,i = 0;
            string testNumber;
            bool result;
            Console.WriteLine("---------------------- Int Square ----------------------");
            Console.WriteLine();
            Console.Write("| Enter an integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter an integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            number = int.Parse(testNumber);
            //result
            Console.WriteLine();
            Console.WriteLine("| The square of " + number + " is " + (Math.Pow(number,2)) + ".");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void Equation01()
        {
            int numberA, numberB, numberC, i = 0;
            double answer;
            string testNumber;
            bool result;
            Console.WriteLine("---------------------- Equation 01 ----------------------");
            Console.WriteLine();
            Console.WriteLine("Equation format: A² * 5 – C / (B – A % 4)");
            Console.WriteLine();

            //number A
            Console.Write("| Enter the first integer: ");
            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the first integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberA = int.Parse(testNumber);

            //number B
            Console.Write("| Enter the second integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the second integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberB = int.Parse(testNumber);
            //number C
            Console.Write("| Enter the third integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the third integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberC = int.Parse(testNumber);
            //calculing 
            answer = (Math.Pow(numberA, 2) * 5 - numberC) / (numberB - numberA % 4);
            //result
            Console.WriteLine();
            Console.WriteLine("| The result of the equation is " + answer + ".");
            Console.WriteLine("---------------------------------------------------------");
            
            Console.WriteLine();
            Main();
        }
        static void TestAdulthood()
        {
            int age, i = 0;
            string testNumber;
            bool result;
            Console.WriteLine("--------------------- Test Adulthood --------------------");
            Console.WriteLine();
            Console.Write("| Enter your age: ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = int.TryParse(testNumber, out i);
            while(!result)
            {
                Console.WriteLine("| Age cannot be a text, try again!");
                Console.Write("| Enter your age: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            age = int.Parse(testNumber);
            if(age >= 18)
            {
                Console.WriteLine("| You are adult");
            }
            else
            {
                Console.WriteLine("| You are not an adult");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void BRLtoUSD()
        {
            int j = 0;
            double real, dolar, answer, i = 0;
            string testNumber;
            bool result;
            Console.WriteLine("----------------------- BRL to USD ----------------------");
            Console.WriteLine();
            Console.Write("| Amount in reais (BRL) to be converted to dollars (USD): ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = double.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| The amount in reais must be a dotted number, try again!");
                Console.Write("| Amount in reais (BRL) to be converted to dollars (USD): ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out j);
            }
            real = double.Parse(testNumber);
            Console.WriteLine();
            Console.Write("| Dollar price (USD): ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = double.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Dollar (USD) quote must be a dotted number, try again!");
                Console.Write("| Dollar price (USD): ");
                testNumber = Console.ReadLine();
                result = double.TryParse(testNumber, out i);
            }
            dolar = double.Parse(testNumber);
            answer = real / dolar;
            Console.WriteLine("With R" + real.ToString("C2") +" you will have " + answer.ToString("C2") + ".");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void NameInfos()
        {
            int i = 0;
            string nameA, nameB, testNumber;
            bool result;
            Console.WriteLine("----------------------- Name Info -----------------------");
            Console.WriteLine();
            Console.Write("| Please enter a name: ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = int.TryParse(testNumber, out i);
            while (result)
            {
                Console.WriteLine("| The name cannot be a number, try again!");
                Console.Write("| Please enter a name: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            nameA = testNumber;
            Console.WriteLine();
            Console.Write("| Please enter other name: ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = int.TryParse(testNumber, out i);
            while (result)
            {
                Console.WriteLine("| The name cannot be a number, try again!");
                Console.Write("| Please enter other name: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            nameB = testNumber;

            Console.WriteLine("| First name: " + nameA.ToUpper() + "; Second name: " + nameB.ToUpper() + ".");
            Console.WriteLine("| First name lenght: " + nameA.Length + "; Second name lenght: " + nameB.Length + ".");
            Console.WriteLine("| First name three letters: " + nameA.Substring(0,3) + "; Second three letters: " + nameB.Substring(0,3) + ".");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void BRLtoEURandUSD()
        {
            int j = 0;
            double real, dolar, euro, answerUSD, answerEUR, i = 0; 
            string testNumber;
            bool result;
            Console.WriteLine("------------------- BRL to EUR and USD ------------------");
            Console.WriteLine();
            Console.Write("| Amount in Real (BRL) to be converted to Dolar (USD) and Euro (EUR): ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = double.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| The amount in reais must be a dotted number, try again!");
                Console.Write("| Amount in Real (BRL) to be converted to Dolar (USD) and Euro (EUR): ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out j);
            }
            real = double.Parse(testNumber);
            Console.WriteLine();
            Console.Write("| Dollar price (USD): ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = double.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Dollar (USD) quote must be a dotted number, try again!");
                Console.Write("| Dollar price (USD): ");
                testNumber = Console.ReadLine();
                result = double.TryParse(testNumber, out i);
            }
            dolar = double.Parse(testNumber);
            Console.WriteLine();
            Console.Write("| Euro price (EUR): ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = double.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| The Euro (EUR) quotation must be a dotted number, try again!");
                Console.Write("| Euro price (EUR): ");
                testNumber = Console.ReadLine();
                result = double.TryParse(testNumber, out i);
            }
            euro = double.Parse(testNumber);
            answerUSD = real / dolar;
            answerEUR = real / euro;
            Console.WriteLine("With R" + real.ToString("C2") + " you will have US " + answerUSD.ToString("C2") + " or EUR" + answerEUR.ToString("C2") + ".");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void InvertVariables()
        {
            int numberA, numberB, exchange, i = 0;
            string testNumber;
            bool result;
            Console.WriteLine("-------------------- Invert Variables -------------------");
            Console.WriteLine();
            Console.Write("| Enter an integer: ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| The number cannot be a text, try again!");
                Console.Write("| Enter an integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberA = int.Parse(testNumber);
            Console.WriteLine();
            Console.Write("| Enter another integer: ");
            testNumber = Console.ReadLine();
            Console.WriteLine();
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| The number cannot be a text, try again!");
                Console.Write("| Enter another integerr: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberB = int.Parse(testNumber);
            exchange = numberA;
            numberA = numberB;
            numberB = exchange;

            Console.WriteLine(numberB + " turned " + numberA + " and " + numberA + " turned " + numberB + ".");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Main();
        }
        static void LogicalEquation()
        {
            int numberX, numberW, numberY, numberZ, i = 0;
            string testNumber;
            bool result, answer;
            Console.WriteLine("-------------------- Logical Equation -------------------");
            Console.WriteLine();
            Console.WriteLine("Equation format: ((X >= Y) AND (Z <=X)) OR ((X == W) AND (Y == Z)) OR (NOT(X != W))");
            Console.WriteLine();

            //number A
            Console.Write("| Enter the first integer: ");
            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the first integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberX = int.Parse(testNumber);

            //number B
            Console.Write("| Enter the second integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the second integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberW = int.Parse(testNumber);
            //number C
            Console.Write("| Enter the third integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the third integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberY = int.Parse(testNumber);
            Console.Write("| Enter the four integer: ");

            testNumber = Console.ReadLine();
            //testing if it's a number
            result = int.TryParse(testNumber, out i);
            while (!result)
            {
                Console.WriteLine("| Type a number not a text!");
                Console.Write("| Enter the four integer: ");
                testNumber = Console.ReadLine();
                result = int.TryParse(testNumber, out i);
            }
            numberZ = int.Parse(testNumber);
            //calculing 
            answer = ((numberX >= numberY) && (numberZ <= numberX)) || ((numberX == numberW) && (numberY == numberZ)) || (!(numberX != numberW));
            Console.WriteLine();
            if (answer) 
            {
                Console.WriteLine("| the result of the logical equation is true.");
            }
            else
            {
                Console.WriteLine("| the result of the logical equation is false.");
            }
            
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine();
            Main();
        }
    }
}