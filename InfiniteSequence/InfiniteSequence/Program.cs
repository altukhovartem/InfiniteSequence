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
            Console.WriteLine(x);
            Console.WriteLine(Mid(x));

            Generate(x);
        }

        private static void Generate(int x)
        {
            while(true)
            {
                Console.WriteLine(x);
                x = Mid(x*x);
                Console.ReadKey();
            }
        }

        private static int Mid(int num)
        {
            var resultStr = string.Join(string.Empty, num.ToString().Take(num.ToString().Length - 3));
            if (num.ToString().Length == 1)
            {
                return 0;
            }
            else if (num.ToString().Length == 2)
            {
                resultStr = string.Join(string.Empty, num.ToString().Take(1));
            }
            else if (num.ToString().Length == 3)
            {
                resultStr = string.Join(string.Empty, num.ToString().Take(2));
            }
            else if (num.ToString().Length == 4)
            {
                resultStr = string.Join(string.Empty, num.ToString().Take(3));
            }
            else if (num.ToString().Length > 4)
            {
                resultStr = string.Join(string.Empty, num.ToString().Skip(num.ToString().Length - 4).Take(3));
            }
            return int.Parse(resultStr);

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
