using System;

namespace MethodsExerciseMathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Add!");
            int x = GetNumberFromUser("I need a number!");
            int y = GetNumberFromUser("Another one please!");
            int sum = Add(x, y);
            Console.WriteLine($"{x} + {y} = {sum}");

            Console.WriteLine("Try Multipling!");
            int a = GetNumberFromUser("Give me a number!");
            int b = GetNumberFromUser("Give me another number!");
            int product = Multiply(a, b);
            Console.WriteLine($"{a} * {b} = {product}");

            Console.WriteLine("Now Let's Try Division!");
            int c = GetNumberFromUser("Give me a good number.");
            int d = GetNumberFromUser("Now, try to give a number in the range of hundreds.");
            int dividend = Divide(c, d);
            Console.WriteLine($"{c} / {d} = {dividend}");

            Console.WriteLine("Lastly, We Will Subtract!");
            int e = GetNumberFromUser("I want a number!");
            int f = GetNumberFromUser("Let's do this one more time.");
            int result = Subtract(e, f);
            Console.WriteLine($"{e} - {f} = {result}");
        }

        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }

        static int Divide(int num1, int num2)
        {
            int dividend = num1 / num2;
            return dividend;
        }

        static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
    }
}
