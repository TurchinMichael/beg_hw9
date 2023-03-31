using System;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region натуральные значения от N до 1 рекурсией
            PrintUintToOneRecursion(printInputUint($"\nВведите число, от которого вам необходимо получить натуральные числа до 1"));
            #endregion
            #region сумма натуральных элементов от M до N рекурсией
            Print($"\n{SumNaturalUintRecursion(printInputUint($"\nВведите число, от которого вам необходимо получить сумму"), printInputUint($"\nВведите число, до которого вам необходимо получить сумму"))}");
            #endregion
            #region функция аккермана рекурсией
            Print($"\nA(m,n) = {A(printInputUint($"\nВведите число, от которого вам необходимо получить значение функции Аккермана"), printInputUint($"\nВведите число, до которого вам необходимо получить значение функции Аккермана"))}");
            #endregion
            Console.ReadLine();
        }

        static void PrintUintToOneRecursion(uint n)
        {
            if (n != 0 && n > 0)
            {
                Print($"{n}");
                PrintUintToOneRecursion(n - 1);
            }
        }

        /// <summary>
        /// Складывает все значения натуральных чисел в промежутке от m до n
        /// </summary>
        /// <param name="m">сумма натуральных чисел от</param>
        /// <param name="n">сумма натуральных чисел до</param>
        /// <returns>Сумма всех значений натуральных чисел в промежутке от m до n</returns>
        static uint SumNaturalUintRecursion(uint m, uint n)
        {
            if (m <= n)
            {
                uint z = m;

                if (m == n + 1)
                {
                    return 0;
                }
                else
                {
                    m++;
                    z = z + SumNaturalUintRecursion(m, n);
                    return z;
                }
            }
            return 0;
        }

        /// <summary>
        /// Рассчитывает значение функции Аккермана от m до n
        /// </summary>
        /// <param name="m">значение функции Аккермана от</param>
        /// <param name="n">значение функции Аккермана до</param>
        /// <returns>значение функции Аккермана от m до n</returns>
        static uint A(uint m, uint n) // понятия не имею, для чего используется данная функция, но перенес систему уравнений в код 1 к 1, вроде работает как задумано
        {
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return A(m - 1, 1);
            }

            if (m > 0 && n > 0)
            {
                return A(m - 1, A (m, n - 1));
            }

            return 0;
        }

        /// <summary>
        /// удобство вывода без лишнего текста
        /// </summary>
        /// <param name="mes">текст для вывода в консоль</param>
        static void Print(string mes)
        {
            Console.WriteLine(mes);
        }

        /// </summary>
        /// отображение сообщения, прием из консоли значения, перевод полученного значения в натуральное число
        /// <param name="mes">сообщение перед запросом числа</param>
        /// <returns>натуральное число, введенное пользователем в консоли</returns>
        static uint printInputUint(string mes)
        {
            Console.WriteLine(mes);
            uint z = 0;
            uint.TryParse(Console.ReadLine(), out z);
            return z;
        }
    }
}