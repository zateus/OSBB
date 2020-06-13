using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        public string ID { get; private set; }
        private static object syncRoot = new Object();

        protected Singleton(string ID)
        {
            this.ID = ID;
        }

        public static Singleton getInstance(string ID)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Singleton(ID);
                }
            }
            return instance;
        }
    }
}
