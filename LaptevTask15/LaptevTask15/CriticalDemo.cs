using System;
using System.Threading;

namespace LaptevTask15 {
    public class CriticalDemo {
        
        private static object balance = 10000;

        private static void IncreaseBill(object s) {
            balance = (int) balance + (int) s;
            Console.WriteLine(balance);
        }

        private static void IncreaseBillSafe(object s) {
            lock (balance) {
                balance = (int) balance + (int) s;
                Console.WriteLine(balance);
            }
        }

        public static void CriticalDemonstration() {
            for (int i = 0; i < 5; i++) {
                var myThread = new Thread(new ParameterizedThreadStart(IncreaseBill));
                myThread.Start(50);
            }

            balance = 1000;
            Console.WriteLine("Critical section - balance changed");
            for (int i = 0; i < 5; i++) {
                var myThread = new Thread(new ParameterizedThreadStart(IncreaseBillSafe));
                myThread.Start(50);
            }
        }
    }
}