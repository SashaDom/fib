using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace cs_async_computing
namespace Fibonachi
{
    class Program
    {
        private delegate UInt64 AsyncSumDel(UInt64 n);
        static void Main(string[] args)
        {


            FibonachiAsync(40);
            FibonachiAsync(38);
            FibonachiAsync(35);
            Console.ReadKey();
        }
        public static UInt64 Fibonachi(UInt64 n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static async void FibonachiAsync(UInt64 n)
        {
            await Task.Run(() => Console.WriteLine(" число = " + Fibonachi(n)));
        }


    }
}
