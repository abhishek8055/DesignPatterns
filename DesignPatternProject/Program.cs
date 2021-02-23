namespace SingletonDesignPattern
{
    using DesignPatternProject;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(
            //        ()=> SingletonAccess1(),
            //        ()=> SingletonAccess2()
            //    );

            //Parallel.Invoke(
            //        () => SingletonEagerAccess1(),
            //        () => SingletonEagerAccess2()
            //    );

            Parallel.Invoke(
                    () => SingletonLazyAccess1(),
                    () => SingletonLazyAccess2()
                );

            Console.ReadKey();
        }

        private static void SingletonAccess1()
        {
            Singleton instance1 = Singleton.GetInstance;
            instance1.PrintMessage("Instance 1");
        }

        private static void SingletonAccess2()
        {
            Singleton instance2 = Singleton.GetInstance;
            instance2.PrintMessage("Instance 2");
        }

        private static void SingletonEagerAccess1()
        {
            SingletonEagerLoding instance1 = SingletonEagerLoding.GetInstance;
            instance1.PrintMessage("Instance 1");
        }

        private static void SingletonEagerAccess2()
        {
            SingletonEagerLoding instance2 = SingletonEagerLoding.GetInstance;
            instance2.PrintMessage("Instance 2");
        }

        private static void SingletonLazyAccess1()
        {
            SingletonLazyLoading instance1 = SingletonLazyLoading.GetInstance;
            instance1.PrintMessage("Instance 1");
        }

        private static void SingletonLazyAccess2()
        {
            SingletonLazyLoading instance2 = SingletonLazyLoading.GetInstance;
            instance2.PrintMessage("Instance 2");
        }
    }
}
