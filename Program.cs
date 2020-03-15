using System;
using System.Threading;
using DesignPatternsImplementation.Adapter.SimpleImplementation;
using DesignPatternsImplementation.Singleton;

namespace DesignPatternsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RunAdapter();
            RunSingleton();
        }

        public static void RunAdapter()
        {
            Console.WriteLine("***********************Adapter Pattern Example****************");
            var xmlList = new EmployeeManager().GetAllEmployees();
            Console.WriteLine(xmlList);

            IEmployeeAdapter employeeAdapter = new EmployeeAdapter();
            var jsonLsst = employeeAdapter.GetAllEmployees();
            Console.WriteLine(jsonLsst);

            Console.WriteLine("***********************Adapter Pattern Example Ends Here****************");
        }
        public void RunAbstractFactory()
        {

        }
        public static void RunSingleton()
        {
            Console.WriteLine("***********************Singleton Pattern Example****************");

            Console.WriteLine("\t***********************Thread Safe Singleton Pattern Example****************");
            new Thread(() => { var instance =  ThreadSafeSingleton.CreateInstance; }).Start();
            new Thread(() => { var instance =  ThreadSafeSingleton.CreateInstance; }).Start();
            new Thread(() => { var instance =  ThreadSafeSingleton.CreateInstance; }).Start();
            Console.WriteLine("\t***********************Thread Safe Singleton Pattern Ends HereExample****************");
            Console.WriteLine();
           Console.WriteLine("\t***********************Lazy Singleton Pattern Example****************");
            new Thread(() => { var instance = LazySingleton.CreateInstance; }).Start();
            new Thread(() => { var instance = LazySingleton.CreateInstance; }).Start();
            new Thread(() => { var instance = LazySingleton.CreateInstance; }).Start();
            Console.WriteLine("\t***********************Lazy Singleton Pattern Ends HereExample****************");
            Console.WriteLine("***********************Singleton Pattern Example****************");
        }
    }
}
