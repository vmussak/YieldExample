using System;
using System.Diagnostics;
using System.Linq;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Stopwatch();
            time.Start();
            var yieldReturn = Iterator.GetYield();
            time.Stop();
            Console.WriteLine("Tempo com Yield: {0}", time.Elapsed);
            Console.WriteLine();
            time.Restart();
            var defaultReturn = Iterator.GetDefault();
            time.Stop();
            Console.WriteLine("Tempo com Default: {0}", time.Elapsed);
            Console.WriteLine();
            time.Restart();
            var yieldReturnToList = Iterator.GetDefault().ToList();
            time.Stop();
            Console.WriteLine("Tempo com Yield .ToList(): {0}", time.Elapsed);
            Console.WriteLine();
            time.Restart();
            var defaultReturnToList = Iterator.GetDefault().ToList();
            time.Stop();
            Console.WriteLine("Tempo com Default .ToList(): {0}", time.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Count do yield return: {0}", yieldReturn.Count());
            Console.WriteLine("Count do default return: {0}", defaultReturn.Count());
            Console.WriteLine("Count do default return .ToList(): {0}", defaultReturnToList.Count());
            Console.WriteLine("Count do yield return .ToList(): {0}", yieldReturnToList.Count());

            Console.ReadKey();
        }
    }
}
