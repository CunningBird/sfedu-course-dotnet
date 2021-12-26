using System;
using System.Threading;

namespace LaptevTask15 {
    public class HashCodeDemo {
        public static void PrintHashCode() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("HashCode:" + Thread.CurrentThread.GetHashCode() + " Priority" + Thread.CurrentThread.Priority);
                //Thread.Sleep(1);
                //Thread.Sleep(10);
                //Thread.Sleep(0);
            }
        }
        
        public static void ChangePriority() {
            for (int i = 0; i < 5; i++) {
                if (i % 3 == 0) {
                    Thread.CurrentThread.Priority = ThreadPriority.Highest;
                } else if (i % 2 == 0) {
                    Thread.CurrentThread.Priority = ThreadPriority.Lowest;
                } else {
                    Thread.CurrentThread.Priority = ThreadPriority.Normal;
                }

                Console.WriteLine("HashCode:" + Thread.CurrentThread.GetHashCode() + " Priority" + Thread.CurrentThread.Priority);
            }
        }
    }
}