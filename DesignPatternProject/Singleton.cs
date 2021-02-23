
namespace DesignPatternProject
{
    using System;
    public sealed class Singleton
    {
        private static int counter;
        private static Singleton _instance;
        private static readonly object lockOnMultithreading = new object();
        public static Singleton GetInstance {
            get{
                if (_instance == null)
                {
                    lock (lockOnMultithreading)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }                   
                    }
                }
                return _instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Singleton Instance Count: {0}", counter);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //NESTED CLASS VOILATES THE SINGLE INSTANCE OF SINGLOTON DESIGN PATTERN THAT'S WHY SINGLETON CLASS SHOULD BE-
        // 1. DEFAULT CONSTRUCTOR SHOULD BE PRIVATE
        // 2. CLASS MUST BE DECLEARED AS SEALED.

        //public class DerivedSingleton : Singleton
        //{
            
        //}
    }
}
