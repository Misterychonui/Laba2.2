using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2._2
{
    static class Program
    {
        //На вход программы подаются результаты измерений, выполняемых прибором с интервалом 1 минуту.
        //Все данные – целые числа(возможно, отрицательные). 
        //Требуется найти наибольшую сумму двух результатов измерений, выполненных с интервалом не менее, чем в 7 минут.
        //Описание входных данных
        //В первой строке вводится одно целое положительное число – количество измерений N, которое может быть очень велико.
        //Гарантируется, что N > 7. Каждая из следующих N строк содержит по одному целому числу – результат очередного измерения.
        //Описание выходных данных
        //Программа должна вывести одно число наибольшую сумму двух результатов измерений, выполненных с интервалом не менее, чем в 7 минут.
        //Пример входных данных:
        //10
        //1
        //2
        //3
        //4
        //5
        //6
        //7
        //8
        //9
        //10
        //Пример выходных данных для приведённого выше примера входных данных:
        //13

        static void Main()
        {
            const int digit = 7;
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            int[] boof = new int[digit];
            for (int i = 0; i < digit; i++)
                boof[i] = int.Parse(Console.ReadLine());
            for (int i = digit; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (boof[i % digit] > max)
                    max = boof[i % digit];
                if (a + boof[i % digit] > sum)
                    sum = a + boof[i % digit];
                boof[i % digit] = a;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

