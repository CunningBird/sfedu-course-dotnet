using System;
using System.IO;
using static LaptevTask10.FileUtils;

namespace LaptevTask10
{
    class Program {
        private static void Main(string[] args) {
            var text =
                "Невероятно прекрасный, лаконичный и, что самое главное, полезный текст, который, к тому же, " +
                "разбит на две строки, и содержит английские слова, такие как Three, hundred и bucks";

            task10_1a(text);

            task10_1b(text);

            task10_2();

            task10_3();

            task10_4();

            task10_5();
        }

        private static void task10_1a(string text) {
            Console.WriteLine(" Single_byte Encodings");
            Single_byteEncodings(text);
            Console.WriteLine();
        }

        private static void task10_1b(string text) {
            Console.WriteLine(" Unicode Ecodings");
            UnicodeEncodings(text);
            Console.WriteLine();
        }

        private static void task10_2() {
            Console.WriteLine(" Delete In File");
            DeleteInFile("test.txt", 5);
            Console.WriteLine();
        }

        private static void task10_3() {
            Console.WriteLine(" Sum In File");
            SumInFile("numbers.txt");
            Console.WriteLine();
        }

        private static void task10_4() {
            Console.WriteLine(" Folders and files in current directory");
            DataSqare("numbers.dat");
            Console.WriteLine();
        }

        private static void task10_5() {
            Console.WriteLine(" Mod2 Numbers");
            CurrentDirectory(Directory.GetCurrentDirectory());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}