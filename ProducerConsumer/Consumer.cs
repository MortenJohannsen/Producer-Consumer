using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProducerConsumer
{
    public class Consumer
    {

        private BoundedBuffer buffer;
        private int _max;

        public Consumer(BoundedBuffer buf)
        {
            this.buffer = buf;
        }

        public void Run()
        {
            
            int temp = this.buffer.Take();
            while (temp != -1)
            {
                temp = this.buffer.Take();
            }

        }

    }//End of class
}//End of namespace
