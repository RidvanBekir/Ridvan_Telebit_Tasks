using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally

class SquareRoot
{
    static void CheckNumberSign(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid number! Square root is defined only for positive numbers!");
        }
    }

    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
            CheckNumberSign(number);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
        }
        catch (FormatException fe)
        {
            throw new FormatException("Invalid number! " + fe.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number! It's either too big or too small to fit in Int32!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}