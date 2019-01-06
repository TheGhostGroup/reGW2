using System;
using System.Threading;

namespace GW2Emu.Common
{
    public class ThreadExecutor
    {
        private readonly object runningLock = new object();

        private Thread thread;
        private bool running;

        public event Action Tick;

        public ThreadExecutor()
        {
            thread = new Thread(ThreadLoop);
        }

        public ThreadExecutor(bool isBackground)
        {
            thread = new Thread(ThreadLoop);
            thread.IsBackground = isBackground;
        }

        public void Start()
        {
            if (!Running)
            {
                Running = true;
                thread.Start();
            }
        }

        public void Stop()
        {
            if (Running)
            {
                Running = false;
            }
        }

        private void ThreadLoop()
        {
            while (Running)
            {
                if (Tick != null) Tick.Invoke();
            }
        }

        public bool Running
        {
            get
            {
                lock (runningLock)
                {
                    return running;
                }
            }
            set
            {
                lock (runningLock)
                {
                    running = value;
                }
            }
        }
    }
}
