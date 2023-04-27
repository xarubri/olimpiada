//Для использования методов Console.ReadLine() и Console.WriteLine() нужно добавить using System в начале файла.

//Для использования метода Enumerable.Range() нужно добавить using System.Linq в начале файла.

/*В ZadanieOne методе One() следует добавить проверку на ввод пользователем отрицательного числа, 
и если число отрицательное, сообщить об этом и попросить ввести положительное число.*/

/*В ZadanieTwo методе Two() необходимо добавить проверку на ввод пользователем числа, меньшего или равного 3,
и если введенное число меньше или равно 3, сообщить об этом и попросить ввести число, большее 3.*/

//Можно добавить вывод сообщения перед каждым результатом работы методов One() и Two() с описанием того, что будет выведено на экран.

/*Чтобы обеспечить возможность повторного использования классов ZadanieOne и ZadanieTwo в других частях кода, 
стоит сделать их статическими и добавить возвращаемое значение типа string вместо вывода результата на консоль.*/


//измененный код:

using System;
using System.Linq;

namespace Library
{
    public static class ZadanieOne
    {
        public static string One()
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Введите положительное число.");
                return "";
            }
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine($"Последовательность чисел от 1 до {n}: {result}");
            return result;
        }
    }

    public static class ZadanieTwo
    {
        public static string Two()
        {
            Console.Write("Введите нечетное число N (больше 3): ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 3 || n % 2 == 0)
            {
                Console.WriteLine("Вы ввели неправильное число. Введите нечетное число, больше 3.");
                return "";
            }
            string result = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1) result += " ";
                    else result += "#";
                }
                result += "\n";
            }
            Console.WriteLine($"Квадрат из символов # со стороной {n} и дыркой в центре:\n{result}");
            return result;
        }
    }
}
