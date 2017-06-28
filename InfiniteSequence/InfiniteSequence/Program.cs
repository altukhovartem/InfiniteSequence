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
            Console.WriteLine(Mid(x));


            IEnumerable<int> currentSequence = Generate(x);
        }

        private static IEnumerable<int> Generate(int x)
        {
            List<int> resultSequence = new List<int>();
            resultSequence.Add(x);
            return resultSequence;
        }

        private static int Mid(int num)
        {
            var resultStr = string.Join(string.Empty, num.ToString().Take(4).Skip(1));
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
