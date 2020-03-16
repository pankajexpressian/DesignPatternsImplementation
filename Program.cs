using System;
using System.Threading;
using DesignPatternsImplementation.Adapter.SimpleImplementation;
using DesignPatternsImplementation.Memento;
using DesignPatternsImplementation.Multithreading;
using DesignPatternsImplementation.ProtoType;
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
            RunProtoType();
            RunMemento();

            ThreadPooling.Run();

        }

        private static void RunMemento()
        {
            Editor editor = new Editor();
            EditorStateHistory editorStateHistory = new EditorStateHistory();
            editor.Content = "State 1";
            editorStateHistory.Push(editor.CreateState());
            editor.Content = "State 2";
            editorStateHistory.Push(editor.CreateState());
            editor.Content = "State 3";
            editor.Restore(editorStateHistory.Pop());
            editor.Content = "State 4";
            editorStateHistory.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "State 5";
            editorStateHistory.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Restore(editorStateHistory.Pop());
            Console.WriteLine(editor.Content);
            
            editor.Restore(editorStateHistory.Pop());
            Console.WriteLine(editor.Content);
            
            editor.Restore(editorStateHistory.Pop());
            Console.WriteLine(editor.Content);

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
        public static void RunProtoType()
        {
            Console.WriteLine();
            Console.WriteLine("***********************Prototype Pattern Example Ends Here****************");

            Console.WriteLine();

            Student s1 = new Student();
            s1.Id = 101;
            s1.Name = "Pankaj";
            s1.StudentAddress = new Address()
            {
                Id = 102,
                Country = "India",
                State = "Haryana",
                City = "Gurgaon",
                ContactDetail = new ContactDetail()
                {
                    Mobile = "9911881005"
                }
            };
            s1.StudentSection = new Section() { Id = 103, Name = "A" };
            Console.WriteLine("Original");
            s1.ToString();

            Student s2 = (Student)s1.Clone();
            Console.WriteLine("Shallow Copy");
            s2.ToString();


            //s2.Id = 201;
            //s2.Name = "Nitika";
            
            //s2.StudentAddress = new Address()
            //{
            //    Id = 202,
            //    Country = "India",
            //    State = "Delhi",
            //    City = "Delhi",
            //    ContactDetail = new ContactDetail()
            //    {
            //        Mobile = "119911991199"
            //    }
            //};
            //s2.StudentSection = new Section() { Id = 203, Name = "B" };

            //s1.ToString();
            //s2.ToString();

            Console.WriteLine();

            #region ShalloCopy
            //Student s3 = (Student)s1.ShalloCopy();
            //s3.ToString();
            //s3.Id = 301;
            //s3.Name = "Sachin";
            //s3.StudentAddress = new Address()
            //{
            //    Id = 302,
            //    Country = "India",
            //    State = "Punjab",
            //    City = "Ludhiyana",
            //    ContactDetail = new ContactDetail()
            //    {
            //        Mobile = "4545454545"
            //    }
            //};
            //s3.StudentSection = new Section() { Id = 303, Name = "C" };
            //s3.ToString();
            //s1.ToString();
            #endregion

            Console.WriteLine("***********************Prototype Pattern Example Ends Here****************");
        }
        public static void RunSingleton()
        {
            Console.WriteLine("***********************Singleton Pattern Example****************");

            Console.WriteLine("\t***********************Thread Safe Singleton Pattern Example****************");
            new Thread(() => { var instance = ThreadSafeSingleton.CreateInstance; }).Start();
            new Thread(() => { var instance = ThreadSafeSingleton.CreateInstance; }).Start();
            new Thread(() => { var instance = ThreadSafeSingleton.CreateInstance; }).Start();
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
