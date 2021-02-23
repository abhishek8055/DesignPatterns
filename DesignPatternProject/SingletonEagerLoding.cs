namespace SingletonDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public sealed class SingletonEagerLoding
    {
        private static int counter;
        private static readonly SingletonEagerLoding _instance = new SingletonEagerLoding();
        public static SingletonEagerLoding GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private SingletonEagerLoding()
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
