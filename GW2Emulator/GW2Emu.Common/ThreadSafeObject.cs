using System;

namespace GW2Emu.Common
{
    public class ThreadSafeObject<T>
    {
        private readonly object objectLock = new object();
        private T value;
        private bool canWrite;

        public ThreadSafeObject(T value)
        {
            this.value = value;
            this.canWrite = true;
        }

        public ThreadSafeObject(T value, bool canWrite)
        {
            this.value = value;
            this.canWrite = canWrite;
        }

        public T Value
        {
            get
            {
                lock (objectLock)
                {
                    return value;
                }
            }

            set
            {
                lock (objectLock)
                {
                    if (!canWrite)
                    {
                        throw new InvalidOperationException("This object is readonly.");
                    }

                    this.value = value;
                }
            }
        }
    }
}
