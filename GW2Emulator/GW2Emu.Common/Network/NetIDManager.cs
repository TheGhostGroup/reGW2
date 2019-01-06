using System;
using System.Collections.Generic;

namespace GW2Emu.Common
{
    public class NetIDManager
    {
        private readonly Stack<int> freeIds = new Stack<int>();
        private int min;
        private int max;
        private int count;

        public NetIDManager(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.count = min;
        }

        public int Acquire()
        {
            if (HasMore())
            {
                return freeIds.Pop();
            }
            else
            {
                if (count < max)
                {
                    count++;
                    return count - 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public void Push(int item)
        {
            freeIds.Push(item);
        }

        private bool HasMore()
        {
            return (freeIds.Count > 0);
        }
    }
}
