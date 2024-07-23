using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_43_Singleton_Implementation_Section_43_3
{
    public sealed class ThreadSafeSingleton
    {
        private static volatile ThreadSafeSingleton instance;
        private static object lockObject = new Object();

        private ThreadSafeSingleton()
        {

        }

        public static ThreadSafeSingleton Instance
        {

            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        {
                            if (instance == null)
                            {
                                instance = new ThreadSafeSingleton();
                            }
                        }
                    }
                }

                return instance;
            }
        }
    }
}
