using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static Thread Thread1;
        public static Thread Thread2;
        public static void Thread1Loop()
        {
            for (int loopCount1 = 0; loopCount1 <= 2; loopCount1++)
            {
                Thread1 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread1.Name + " = " + loopCount1);
                Thread.Sleep(500);
            }
            
        }

        public static void Thread2Loop()
        {
            for (int loopCount2 = 0; loopCount2 <= 6; loopCount2++)
            {
                Thread2 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread2.Name + " = " + loopCount2);
                Thread.Sleep(1500);
            }
        }
        
    }
}
