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

        public Consumer(BoundedBuffer buf, int howMany)
        {
            this.buffer = buf;
            this._max = howMany;
        }

        public void Run()
        {
            for (int i = 0; i < this._max; i++)
            {
                    int temp = this.buffer.Take();
                    
            }
            
        }

    }//End of class
}//End of namespace
