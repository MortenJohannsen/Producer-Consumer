using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buf = new BoundedBuffer(4);

            Producer prod = new Producer(buf, 10);
            Consumer con = new Consumer(buf, 10);

            Parallel.Invoke(prod.Run, con.Run);


            Console.WriteLine("--- Done ---");
            Console.ReadKey();
        }
    }
}
