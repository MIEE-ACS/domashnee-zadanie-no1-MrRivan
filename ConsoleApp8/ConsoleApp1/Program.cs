using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X= ");
            string number_text = Console.ReadLine();

            if ((int.TryParse(number_text, out int int_number_x)) && (int_number_x <= 35) && (int_number_x >= -35))// проверка размеров. Max число в 6 стени типа int 35. 
            {
                int int_sum_y = 4 * (int)Math.Pow((int_number_x - 3), 6) - 7 * (int)Math.Pow((int_number_x - 3), 3) + 2;
                Console.WriteLine($"Результат уравнения: 4 * (x - 3) ^ 6 - 7 * (x - 3) ^ 3) + 2. Равно {int_sum_y}");
            }
            else
            {
                if ((float.TryParse(number_text, out float float_number_x))&&(float_number_x<=1.2*Math.Pow(10,6))&&(float_number_x >= 1.0 * Math.Pow(10, - 7)))//на 2 порядка меньше чем границы float 
                {
                    float float_sum_y = 4 * (float)Math.Pow((float_number_x - 3), 6) - 7 * (float)Math.Pow((float_number_x - 3), 3) + 2;
                    Math.Round(float_sum_y, 3);
                    Console.WriteLine($"Результат уравнения: 4 * (x - 3) ^ 6 - 7 * (x - 3) ^ 3) + 2. Равно {float_sum_y}");
                }

                else
                {
                    Console.WriteLine("Введено не правильное значение");
                    Console.WriteLine(". . . . . . . . . . . . . . . . ");
                    Console.WriteLine("Программа прекращает работу");
                    Environment.Exit(0);
                }
            }
        
        }   
    }
}
