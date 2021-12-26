using System;
using System.Collections.Generic;
using System.Threading;

namespace LaptevTask15 {
    public class StackDemo {

        static SafeStack safeStack;
        
        static Stack<int> stack;

        static void Test1(object o) {
            for (int i = 0; i < 9; i++) {
                if ((bool) o) {
                    safeStack.Push(1);
                } else {
                    safeStack.Pop();
                }
            }
        }

        static void Test2(object o) {
            for (int i = 0; i < 9; i++) {
                if ((bool) o) {
                    stack.Push(1);
                } else if (stack.Count != 0) {
                    stack.Pop();
                }
            }
        }

        public static void StackDemonstration() {
            for (int i = 0; i < 5; i++) {
                var myThread = new Thread(new ParameterizedThreadStart(Test1));
                myThread.Start(true);
            }

            for (int i = 0; i < 5; i++) {
                var myThread = new Thread(new ParameterizedThreadStart(Test1));
                myThread.Start(false);
            }

            Thread.Sleep(100);
            Console.WriteLine("Length " + safeStack.Length());
            Console.WriteLine("NOT SAFE");
            Thread.Sleep(100);
            
            for (int i = 0; i < 5; i++) {
                var myThread = new Thread(new ParameterizedThreadStart(Test2));
                myThread.Start(true);
            }

            for (int i = 0; i < 5; i++) {
                var thread = new Thread(new ParameterizedThreadStart(Test2));
                thread.Start(false);
            }

            Thread.Sleep(200);
            Console.WriteLine("Count " + stack.Count);
        }
    }
}