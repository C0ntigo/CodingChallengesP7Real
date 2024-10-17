using System;

class Challenges
{


    public static void Main(string[] args)
    {

        //Welcome the user to my program
         Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of function for you to use. \n Please pick one.");
         Console.WriteLine("We are going to use the number adder today called sum/ Please give me two numbers.");

        var number1 = Console.ReadLine();
         int numberToUse1 = int.Parse(number1);

         Console.Write("got it give me your 2nd number. \n");


        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);

        Console.Write("The Sum of the number: " +  number1  + "and the number  " +  number2  + "is equal to " + Sum(numberToUse1, numberToUse2));
        Sum(numberToUse1, numberToUse2);

        Console.WriteLine("Welcome to my coding challenge 2 program. \n Please give me a number! ");
        var number3 = Console.ReadLine();
        int numberToUse3 = int.Parse(number3);

        Console.WriteLine(" Minutes converted into seconds is: " + Convert(numberToUse3));

        Console.WriteLine("Welcome to my coding challenge 3 program. \n Please give me a number sir! ");
        var number4 = Console.ReadLine();
        int numberToUse4 = int.Parse(number4);

        Console.WriteLine(" adding 1 to your number will change it into: " + PlusOne(numberToUse4 ));

        Console.WriteLine("welcome to my coding challenge 4 program. \n Please give me a voltage number! ");
        var number5 = Console.ReadLine();
        int numberToUse5 = int.Parse(number5);
        Console.WriteLine(" got it now give me your current number. \n");
        var number6 = Console.ReadLine();
        int numberToUse6 = int.Parse(number6);

        Console.WriteLine("combining: " + number5 + "the volage and the" + number6 + "current is equal to " + CircuitPower(numberToUse5, numberToUse6));
        CircuitPower(numberToUse5 , numberToUse6);

        Console.WriteLine("Welcome to my coding challenge 5 program! \n Please give me a age number");
        var number7 = Console.ReadLine();
        int numberToUse7 = int.Parse(number7);

        Console.WriteLine("The amount of days that are in the age is " + CalcAge(numberToUse7 ));

        Console.WriteLine("Welcome to my challenge 6 program! \n Please give me a number for the base");
        var number8 = Console.ReadLine();
        int numberToUse8 = int.Parse(number8);
        Console.WriteLine("got it now give me a number for your height. \n");
        var number9 = Console.ReadLine();
        int numberToUse9 = int.Parse(number9);
        Console.WriteLine("multiplying the base number" + number8 + "and the height number" + number9 + "divided by 2 equals to" + TriArea(numberToUse8, numberToUse9));
        TriArea(numberToUse8, numberToUse9);

        Console.WriteLine("Welcome to my challenge 7 program! \n please give me a number");
        var number10 = Console.ReadLine();
        int numberToUse10 = int.Parse(number10);
        Console.WriteLine("Your number is less than or equal to 0." + lessthanOrEqualToZero(numberToUse10));
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
}


