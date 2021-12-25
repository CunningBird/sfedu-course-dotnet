using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LaptevTask10
{
    public class FileUtils {
        public static void ReadingPrint(string filename, Encoding encoder) {
            using (var reader = new StreamReader(filename, encoder)) {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine();
        }

        public static void Single_byteEncodings(string txt) {
            File.WriteAllText("dos.txt", "MS DOS:" + txt, Encoding.GetEncoding("ibm850"));
            ReadingPrint("dos.txt", Encoding.GetEncoding("ibm850"));

            File.WriteAllText("koi8.txt", "koi8:" + txt, Encoding.GetEncoding("koi8-r"));
            ReadingPrint("koi8.txt", Encoding.GetEncoding("koi8-r"));

            File.WriteAllText("cp1251.txt", "1251:" + txt, Encoding.GetEncoding(1251));
            ReadingPrint("cp1251.txt", Encoding.GetEncoding(1251));
        }

        public static void UnicodeEncodings(string txt) {
            File.WriteAllText("utf8.txt", "utf8:" + txt, Encoding.UTF8);
            ReadingPrint("utf8.txt", Encoding.UTF8);

            File.WriteAllText("utf16.txt", "utf16:" + txt, Encoding.GetEncoding("Utf-16"));
            ReadingPrint("utf16.txt", Encoding.GetEncoding("Utf-16"));
        }


        public static void DeleteInFile(string txt, int k) {
            File.WriteAllLines("testt.txt", File.ReadAllLines(txt).Reverse().Skip(k).Reverse());
            Console.WriteLine("Delete 5 strings in end of testt.txt are successful");
        }


        public static void SumInFile(string txt) {
            var s = File.ReadAllLines(txt)
                .Select(a => Regex.Replace(a, @"\s+", " ").Replace(@"^\s", "").Split(' ').Select
                    (x => {
                        try {
                            var k = double.Parse(x);
                            return k;
                        }catch (Exception e) {
                            return 0;
                        }
                    }).Sum()).Sum();
            
            Console.WriteLine("Sum in " + txt + ": " + s);
        }

        public static void DataSqare(string txt) {
            var path = txt;
            using (var fin = File.Create(path))
            using (var binfin = new BinaryWriter(fin)) {
                for (var i = 0; i < 10; i++) {
                    binfin.Write(i);
                }
            }


            using (var fin = File.Open(path, FileMode.Open))
            using (var binfout = new BinaryReader(fin))
            using (var binfin = new BinaryWriter(fin)) {
                var len = fin.Length / sizeof(int);
                for (var i = 0; i < len; i++) {
                    var x = binfout.ReadInt32();
                    binfin.Seek(-sizeof(int), SeekOrigin.Current);
                    binfin.Write(x * x);
                }
            }


            using (var fin = File.OpenRead(path))
            using (var binfout = new BinaryReader(fin)) {
                var size = binfout.BaseStream.Length / sizeof(int);
                for (var i = 0; i < size; i++) Console.Write(binfout.ReadInt32() + " ");

                Console.WriteLine();
            }
        }

        public static void CurrentDirectory(string dir, int k = 0) {
            var currDir = dir.Split('\\').Last() + ":";
            Console.WriteLine(currDir.PadLeft(currDir.Length + k * 4));

            foreach (var ndir in Directory.GetDirectories(dir)) CurrentDirectory(ndir, k + 1);

            foreach (var file in Directory.GetFiles(dir, "*")) {
                var fname = file.Replace(dir + "\\", "");
                Console.WriteLine(fname.PadLeft(fname.Length + (k + 1) * 4));
            }
        }
    }
}