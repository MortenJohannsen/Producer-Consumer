using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProducerConsumer
{
    public class Producer
    {
        private BoundedBuffer _buffer;
        private int _max;
        public Producer(BoundedBuffer buf, int howMany)
        {
            this._buffer = buf;
            this._max = howMany;
        }

        public void Run()
        {
            for (int i = 0; i < this._max; i++)
            {
                    this._buffer.Put(i);   
            }
            this._buffer.Put(-1);
        }
    }//End of class
}//End of namespace
