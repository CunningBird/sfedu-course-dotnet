using System;
using System.Threading;

namespace LaptevTask15 {
    public class JoinDemo {

        static double a;

        private static void Join_demonstration_help(object x) {
            double sum = 0;
            int n = (int) x;
            for (int i = 1; i <= n; i++) {
                sum += 1.0 / i;
            }

            Console.WriteLine("Thread:" + Thread.CurrentThread.Name + " end calculations");
            a = (int) x * sum;
        }

        public static void Join_demonstration() {
            var myThread = new Thread(new ParameterizedThreadStart(Join_demonstration_help));
            
            myThread.Start(7);
            myThread.Join();
            
            Console.WriteLine("--------");
            Console.WriteLine(a);
            Console.WriteLine("--------");
            
            double t = a;
            myThread = new Thread(new ParameterizedThreadStart(Join_demonstration_help));
            
            myThread.Start(10);
            myThread.Join();
            
            Console.WriteLine("--------");
            Console.WriteLine(a);
            Console.WriteLine("--------");
            Console.WriteLine(a - t);
        }
    }
}