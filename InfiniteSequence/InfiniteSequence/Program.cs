using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = new Random().Next(1, 100000);
            x = 13;
            foreach (int item in Generate(x))
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }

        private static IEnumerable<int> Generate(int x)
        {
            while(true)
            {
                int midResult = Mid(x * x);
                yield return midResult;
                x = midResult;
            }
        }

        private static int Mid(int num)
        {
            if (num < 10)
            {
                return 0;
            }
            else
            {
                return int.Parse(string.Join("", num.ToString().Reverse().Take(4).Skip(1).Reverse()));
            }
        }
    }
}


// Напишите метод, возвращающий последовательность псевдослучайных целых чисел.
// Алгоритм генерации чисел следующий:
// Берется какое-то начальное неотрицательное число (оно будет передаваться в ваш метод проверяющей системой).
// Первый элемент последовательности устанавливается равным этому числу.
// Следующие элементы вычисляются по рекуррентной формулеRn+1=mid(R2n)Rn+1=mid(Rn2), где mid — это функция, 
// выделяющая второй, третий и четвертый разряд переданного числа.Например, mid(123456)=345mid(123456)=345.
// Алгоритм, конечно, дурацкий и не выдерживающий никакой критики, но для практики работы со стримами сойдет :)
