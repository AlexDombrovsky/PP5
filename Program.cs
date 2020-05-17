using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PP_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число: ");
            int n = Int32.Parse(Console.ReadLine());
            Task<int[]> task = ArrayAsync(n);
            task.Wait();
            Console.WriteLine(string.Join(",", task.Result));
            Console.Read();
        }

        static async Task<int[]> ArrayAsync(int n)
        {
            int[] array = new int[n];
            Console.WriteLine("Начало метода ArrayAsync");
            await Task.Run(() =>
            {
                for (int i = 0; i < n; i++)
                    array[i] = i;
            });
            Console.WriteLine("Конец метода ArrayAsync");
            return array;
        }
    }
}