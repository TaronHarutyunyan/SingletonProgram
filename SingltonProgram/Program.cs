using System;
using System.Threading;

namespace SingltonProgram
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Mutex mutex = new(false, "Name");
            if (!mutex.WaitOne(0))
            {
                return;
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
        }
    }
}
