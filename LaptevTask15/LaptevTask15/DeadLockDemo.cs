using System;
using System.Threading;

namespace LaptevTask15 {
    public class DeadLockDemo {
        
        private static object creditBalance = 1000;
        
        private static object debetBalance = 0;

        private static int s = 10000;

        private static void PayOnCredit() {
            lock (creditBalance) {
                Console.WriteLine("PayOnCredit changed creditBalance!");
                Thread.Sleep(100);
                Console.WriteLine("PayOnCredit checking s!");
                if ((int) creditBalance > 0) {
                    Console.WriteLine("PayOnCredit try to change debetBalance!");
                    lock (debetBalance)
                    {
                        Console.WriteLine("PayOnCredit changing debetBalance!");
                    }

                    Console.WriteLine("Done NO DEADLOCK!");
                }
            }
        }

        private static void GetMoney() {
            lock (debetBalance) {
                Console.WriteLine("GetMoney Checking Balance");
                Thread.Sleep(350);
                if ((int) debetBalance <= 0) {
                    Console.WriteLine("GetMoney asking from credit balance");
                    lock (creditBalance) {
                        Console.WriteLine("Locked credit balance");
                    }

                    Console.WriteLine("Done NO DEADLOCK!");
                }
            }
        }

        public static void DeadLockDemonstration() {
            while (true) {
                new Thread(PayOnCredit).Start();
                Thread.Sleep(50);
                var t = new Thread(GetMoney);
                t.Priority = ThreadPriority.Highest;
                t.Start();
            }
        }
    }
}