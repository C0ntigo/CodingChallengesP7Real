using System;

class Challenges
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Coding Challenges Program! \n Please Give me a number between 1 - ??");
        var choice = Console.ReadLine();
        int choices = int.Parse(choice);
        bool work = true;
        while (work)
        {
            if (choices == 1)

            {
                Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of function for you to use. \n Please pick one.");
                Console.WriteLine("We are going to use the number adder today called sum/ Please give me two numbers.");

                var number1 = Console.ReadLine();
                int numberToUse1 = int.Parse(number1);

                Console.Write("got it give me your 2nd number. \n");


                var number2 = Console.ReadLine();
                int numberToUse2 = int.Parse(number2);

                Console.Write("The Sum of the number: " + number1 + "and the number  " + number2 + "is equal to " + Sum(numberToUse1, numberToUse2));
                Sum(numberToUse1, numberToUse2);
            }
            else if (choices == 2)
            {
                Console.WriteLine("Welcome to my coding challenge 2 program. \n Please give me a number! ");
                var number3 = Console.ReadLine();
                int numberToUse3 = int.Parse(number3);

                Console.WriteLine(" Minutes converted into seconds is: " + Convert(numberToUse3));
            }
            else if (choices == 3)
            {
                Console.WriteLine("Welcome to my coding challenge 3 program. \n Please give me a number sir! ");
                var number4 = Console.ReadLine();
                int numberToUse4 = int.Parse(number4);

                Console.WriteLine(" adding 1 to your number will change it into: " + PlusOne(numberToUse4));
            }
            else if (choices == 4)
            {
                Console.WriteLine("welcome to my coding challenge 4 program. \n Please give me a voltage number! ");
                var number5 = Console.ReadLine();
                int numberToUse5 = int.Parse(number5);
                Console.WriteLine(" got it now give me your current number. \n");
                var number6 = Console.ReadLine();
                int numberToUse6 = int.Parse(number6);

                Console.WriteLine("combining: " + number5 + "the volage and the" + number6 + "current is equal to " + CircuitPower(numberToUse5, numberToUse6));
                CircuitPower(numberToUse5, numberToUse6);
            }
            else if (choices == 5)
            {
                Console.WriteLine("Welcome to my coding challenge 5 program! \n Please give me a age number");
                var number7 = Console.ReadLine();
                int numberToUse7 = int.Parse(number7);

                Console.WriteLine("The amount of days that are in the age is " + CalcAge(numberToUse7));
            }
            else if (choices == 6)
            {
                Console.WriteLine("Welcome to my challenge 6 program! \n Please give me a number for the base");
                var number8 = Console.ReadLine();
                int numberToUse8 = int.Parse(number8);
                Console.WriteLine("got it now give me a number for your height. \n");
                var number9 = Console.ReadLine();
                int numberToUse9 = int.Parse(number9);
                Console.WriteLine("multiplying the base number" + number8 + "and the height number" + number9 + "divided by 2 equals to" + TriArea(numberToUse8, numberToUse9));
                TriArea(numberToUse8, numberToUse9);
            }
            else if (choices == 7)
            {
                Console.WriteLine("Welcome to my challenge 7 program! \n please give me a number");
                var number10 = Console.ReadLine();
                int numberToUse10 = int.Parse(number10);
                Console.WriteLine("Your number is less than or equal to 0." + lessthanOrEqualToZero(numberToUse10));
            }
            else if (choices == 8)
            {
                Console.WriteLine("Welcome to my Challenge 8 program! in this program will be about 2 numbers combining into 1 number & if that number is less than 100 its true if not FALSE! \n please give me the 1st number");
                var number11 = Console.ReadLine();
                int numberToUse11 = int.Parse(number11);
                Console.WriteLine("got it now give me the 2nd");
                var number12 = Console.ReadLine();
                int numberToUse12 = int.Parse(number12);
                Console.WriteLine("Your first number " + number11 + " and the second number " + number12 + " combined together will be " + lessThan100(numberToUse11, numberToUse12));
            }
            else if (choices == 9)
            {
                Console.WriteLine("Welcome To my Challenge 9 program! In This program you will be able to pick 2 numbers and if there equal it's true but if there different then false! \n please give me the first number!");
                var number13 = Console.ReadLine();
                int numberToUse13 = int.Parse(number13);
                Console.WriteLine("got it now give the 2nd");
                var number14 = Console.ReadLine();
                int numberToUse14 = int.Parse(number14);
                Console.WriteLine("Your first number " + number13 + " and the second number " + number14 + IsEqual(numberToUse13, numberToUse14));
            }
            else if (choices == 10)
            {
                Console.WriteLine("Welcome to My Challenge 10 program! were when typing literally anything Something will be added \n Type ANYTHING YOU WANT");
                string words3 = Console.ReadLine();

                Console.WriteLine(GiveMeSomething(words3));
            }
            else if (choices == 11)
            {
                Console.WriteLine("Welcome to My Challenge 11 Program! this program will reverse false or true \n please write true or false");
                var words1 = Console.ReadLine();
                bool wordsToUse1 = bool.Parse(words1);
                if (words1 == "true")
                {
                    Console.WriteLine("False!");
                }
                else if (words1 == "false")
                {
                    Console.WriteLine("True!");
                }

            }
            else if (choices == 12)
            {
                Console.WriteLine("welcome to my challenge 12 program! in this program will convert hours into seconds \n Please give me a number");
                var number15 = Console.ReadLine();
                int numberToUse15 = int.Parse(number15);
                Console.WriteLine("Converting " + number15 + " hours into seconds! " + howManySeconds(numberToUse15));
            }
            else if (choices == 13)
            {
                Console.WriteLine("welcome to my challenge 13 program! In this program will be finding the total sum of internal angles \n Please give me a number");
                var number16 = Console.ReadLine();
                int numberToUse16 = int.Parse(number16);
                Console.WriteLine("The sum of all measures of the angles of an n-sided polygon is " + SumPolygon(numberToUse16));
            }
            else if (choices == 14)
            {
                Console.WriteLine("WElcome to my challenge 14 program! In this program what ever you type at the end will be Edabit so TYPE WHATEVER \n Please give me anything");
                string words2 = Console.ReadLine();

                Console.WriteLine(nameString(words2));
            }
            else if (choices == 15)
            {
                Console.WriteLine("Welcome to my challenge 15 program in this program you will enter 2 words true or false \n Please give me true or false");
                var words4 = Console.ReadLine();
                bool wordsToUse4 = bool.Parse(words4);
                Console.WriteLine("got it now give me true or false again");
                var words5 = Console.ReadLine();
                bool wordsToUse5 = bool.Parse(words5);

                if (words4 == "true" && words5 == "true")
                {
                    Console.WriteLine("It's true");
                }
                else if (words4 == "false" && words5 == "true")
                {
                    Console.WriteLine(" It's false");
                }
                else if (words4 == "false" && words5 == "false")
                {
                    Console.WriteLine(" It's false");
                }
                else if (words4 == "true" && words5 == "true")
                {
                    Console.WriteLine(" It's false");
                }
            }
            if (choices == 0)
            {
                work = false;

            }

        }
        //Welcome the user to my program
    }
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }




    public static int Convert(int number3)
    {
        return number3 * 60;
    }

    public static int PlusOne(int number4)
    {
        return number4 + 1;
    }

    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }
    public static int CalcAge(int number7)
    {
        {
            return number7 * 365;
        }
    }
    public static int TriArea(int number8, int number9)
    {
        return (number8 * number9) / 2;

    }
    public static bool lessthanOrEqualToZero(int number10)
    {
        return number10 <= 0;
    }
    public static bool lessThan100(int number11, int number12)
    {
        return number11 + number12 <= 100;
    }
    public static bool IsEqual(int number13, int number14)
    {
        return number13 == number14;
    }
    public static string GiveMeSomething(string words3)
    {
        return "something " + words3;
    }



    public static bool Reverse(bool words1)
    {
        return words1;
    }
    public static int howManySeconds(int number15)
    {
        return number15 * 3600;
    }
    public static int SumPolygon(int number16)
    {
        return (number16 - 2) * 180;
    }
    public static string nameString(string words2)
    {
        return words2 + "Edabit";
    }
    public static bool Operator(bool words4, bool words5)
    {
        return words4;
        return words5;
    }
}