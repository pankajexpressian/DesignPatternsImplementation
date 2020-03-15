using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsImplementation.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        //Thread Safe Singleton
        private static int _instanceCounter = 0;
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Thread Safe Singleton : " + _instanceCounter++);
        }

        private static ThreadSafeSingleton _instance;
        private static object obj = new object();
        public static ThreadSafeSingleton CreateInstance
        {
            get
            {
                if (_instance==null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
