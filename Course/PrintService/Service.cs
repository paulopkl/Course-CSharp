using System;
using System.Collections.Generic;
using System.Text;

namespace Course.PrintService
{
    class Service<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (this._count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            this._values[this._count] = value;
            this._count++;
        }

        public T First()
        {
            if (this._count == 10)
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return this._values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < this._count; i++)
            {
                Console.Write($"{this._values[i]}, ");
                //if ((int)this._values[i + 1] != 0 || this._values[i + 1] != null)
                //{
                //    Console.Write(", ");
                //}
            }
            Console.Write("]");
        }
    }
}
