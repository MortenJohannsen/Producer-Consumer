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
            Consumer con = new Consumer(buf);
            Consumer con2 = new Consumer(buf);

            Parallel.Invoke(prod.Run, con.Run, con2.Run);


            Console.WriteLine("--- Done ---");
            Console.ReadKey();
        }
    }
}
