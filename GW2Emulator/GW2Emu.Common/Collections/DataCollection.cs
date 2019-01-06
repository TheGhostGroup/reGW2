using System;

namespace GW2Emu.Common.Collections
{
    public class DataCollection<T>
    {
        private T[] data;
        private int position;

        public DataCollection()
        {
            this.data = new T[0];
        }

        public DataCollection(T[] data)
        {
            this.data = data;
        }

        public T Read()
        {
            T tmp = data[position];

            position += 1;

            return tmp;
        }

        public T[] ReadRange(int count)
        {
            var tmp = new T[count];

            Array.Copy(data, position, tmp, 0, count);

            position += count;

            return tmp;
        }

        public void Write(T input)
        {
            var tmp = new T[data.Length + 1];

            Array.Copy(data, tmp, data.Length);
            tmp[data.Length] = input;

            data = tmp;
        }

        public void WriteRange(T[] input)
        {
            var tmp = new T[data.Length + input.Length];

            Array.Copy(data, tmp, data.Length);
            Array.Copy(input, 0, tmp, data.Length, input.Length);

            data = tmp;
        }

        public T[] ToArray()
        {
            return data;
        }

        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value > data.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                position = value;
            }
        }

        public int Length
        {
            get
            {
                return data.Length;
            }
        }
    }
}
