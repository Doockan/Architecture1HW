using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1HW
{    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число. ");
            Console.WriteLine("Для выхода из приложения введите 0.");

            int Input = Int32.Parse(Console.ReadLine());

            if (Input == 0)
            {
                return;
            }
            Console.WriteLine($"Факториал равет {Factorial(Input)}");
            Console.WriteLine($"Сума от 1 до N равна {SumOfNumbers(Input)}");
            Console.WriteLine($"Максимальное четное число меньше N равно {PreviousEvenNumber(Input)}");
            Console.ReadLine();
        }

        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        static int SumOfNumbers(int num)
        {
            int result = 0;
            for (int i = 0; i <= num; i++)
            {
                result += i;
            }
            return result;
        }

        static int PreviousEvenNumber(int num)
        {
            if(num % 2 == 0)
            {
                return num - 2;
            }
            else
            {
                return num - 1;
            }
        }
    }
}
