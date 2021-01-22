using System;

namespace Exercise3
{
    delegate int GetRandom();
    delegate double Average(Delegate[] array);
    class Program
    {
        static void Main(string[] args)
        {
            int GetRandomInt() => new Random().Next(0, 100);

            Delegate[] array = (new GetRandom(GetRandomInt) + new GetRandom(GetRandomInt) + new GetRandom(GetRandomInt)).GetInvocationList();

            Average average = (Delegate[] array) =>
            {
                int summ = default;
                foreach (var item in array)
                {
                    int number = ((GetRandom)item).Invoke();
                    Console.WriteLine(number);
                    summ += number;
                }

                return summ / array.Length;
            };

            Console.WriteLine($"Среднее арифметическое {average(array)}");;
        }
    }
}
