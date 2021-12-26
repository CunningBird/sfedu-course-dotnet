using System;

namespace LaptevTask15 {
    class Program {
        static void Main(string[] args) {
            Task15_1();
            Task15_2();
            Task15_3();
            Task15_4();
            Task15_5();
        }

        static void Task15_1() {
            Console.WriteLine("First usual");
            HashCodeDemo.PrintHashCode();
            Console.WriteLine("First with changed priority");
            HashCodeDemo.ChangePriority();
            Console.WriteLine();
        }

        static void Task15_2() {
            JoinDemo.Join_demonstration();
            Console.WriteLine();
        }

        static void Task15_3() {
            CriticalDemo.CriticalDemonstration();
            Console.WriteLine();
        }

        static void Task15_4() {
            StackDemo.StackDemonstration();
            Console.WriteLine();
        }

        static void Task15_5() {
            DeadLockDemo.DeadLockDemonstration();
            Console.WriteLine();
            Console.WriteLine(11111111111111111);
        }
    }
}