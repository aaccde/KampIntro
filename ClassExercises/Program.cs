using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result=Add2(2, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1,int number2)
        {
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
