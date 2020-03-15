using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsImplementation.Singleton
{
    public class LazySingleton
    {
        private static int _instanceCounter = 0;
        private LazySingleton()
        {
            Console.WriteLine("Lazy Singleton : "+_instanceCounter++);
        }

        private static Lazy<LazySingleton> _instance=new Lazy<LazySingleton>(()=>new LazySingleton());
        public static LazySingleton CreateInstance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
