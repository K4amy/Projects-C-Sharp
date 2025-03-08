using System;

namespace Calcualtor
{

    internal class Program
    {

        static void Main(string[] args)
        {
            InputsMath();
        }
        static void InputsMath()
        {
            bool Continue = true;
            while (Continue)
            {
                try
                {
                    Console.WriteLine("Enter First Number :");
                    double FirstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("? [ + - * / ]");
                    string ArrowMath = Console.ReadLine();
                    Console.WriteLine("Please Enter Second Numbef :");
                    double SecondNumber = Convert.ToDouble(Console.ReadLine());
                    switch (ArrowMath)
                    {
                        case "+":
                            {
                                Console.WriteLine($"{FirstNumber} {ArrowMath} {SecondNumber} = {FirstNumber + SecondNumber}");
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine($"{FirstNumber} {ArrowMath} {SecondNumber} = {FirstNumber - SecondNumber}");
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine($"{FirstNumber} {ArrowMath} {SecondNumber} = {FirstNumber * SecondNumber}");
                                break;
                            }
                        case "/":
                            {
                                if (SecondNumber == 0)
                                {
                                    Console.WriteLine($"{FirstNumber} Cannot be divided by {SecondNumber}");
                                    break;
                                }
                                Console.WriteLine($"{FirstNumber} {ArrowMath} {SecondNumber} = {FirstNumber / SecondNumber}");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please Just use { + - / * }");
                                break;
                            }
                    }
                    Console.WriteLine("Enter the number 1 to continue and 0 to end.");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    if (Number == 1)
                    {
                        Continue = true;
                    }
                    else if (Number == 0)
                    {
                        Continue = false;
                    }
                    else
                    {
                        Continue = false;
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine($"Your error is : {a.Message}");
                }
            }
        }


    }

    
}
