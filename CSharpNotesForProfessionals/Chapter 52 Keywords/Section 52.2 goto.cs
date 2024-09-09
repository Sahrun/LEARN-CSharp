using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_2
{
    enum Permissions { Read, Write };

    internal class Section_52_2
    {

        internal void InfiniteHello()
        {
        sayHello:
            Console.WriteLine("Hello!");
            goto sayHello;
        }


        internal bool GetPermission(Permissions permission)
        {
            switch (permission)
            {
                case Permissions.Read:
                    return true;
                    break;
                case Permissions.Write:
                    goto case Permissions.Read; //People with write access also get read
                    return true;
            }

            return false;
        }

        internal void RetryGoto()
        {
            var exCount = 0;
        retry:
            try
            {
                Console.WriteLine("Trying.. xcount : {0}", exCount);
                throw new IOException();
            }
            catch (IOException)
            {
                exCount++;
                if (exCount < 3)
                {
                    Thread.Sleep(100);
                    goto retry;
                }
                return;
            }

        }
    }
}
