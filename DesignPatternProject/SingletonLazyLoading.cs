namespace SingletonDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public sealed class SingletonLazyLoading
    {
        private static int counter;
        private static readonly Lazy<SingletonLazyLoading> _instance = new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());
        public static SingletonLazyLoading GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        private SingletonLazyLoading()
        {
            counter++;
            Console.WriteLine("Singleton Instance Count: {0}", counter);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
