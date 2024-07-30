using System;

namespace Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int tempValue;
            int numberOfShifting;

            Console.WriteLine("Представлен массив до сдвига: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.Write("\n\nУкажите количество сдвигов: ");

            numberOfShifting = Convert.ToInt32(Console.ReadLine());
            numberOfShifting = numberOfShifting % numbers.Length;

            for (int i = 0; i < numberOfShifting; i++)
            {
                tempValue = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++) 
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = tempValue;
            }

            Console.WriteLine("\n\nМассив после сдвига: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
