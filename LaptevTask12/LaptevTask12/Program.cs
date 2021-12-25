using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Reflection {
    class Program {
        static void Main(string[] args) {
            StudentTasks();

            Task12_3();

            Task12_4();
        }

        static void StudentTasks() {
            Assembly assembly = Assembly.LoadFrom("Student.dll");
            Console.WriteLine(" - Class deserializing\n ");

            foreach (var temp in assembly.GetTypes()) {
                var methods = temp.GetMethods();
                var props = temp.GetProperties();
                Console.WriteLine(temp);
                
                foreach (var m in methods) {
                    Console.WriteLine("Method " + m);
                }

                foreach (var m in props) {
                    Console.WriteLine("Property " + m);
                }

                Console.WriteLine("---------------------");
            }

            Type type = assembly.GetType("Student");


            Console.WriteLine("Object of Student class creating ");
            var obj = Activator.CreateInstance(type, "Ivan", "Ivanov", 22, 4, 2);
            
            Task12_1(type, obj);
            
            Task12_2(assembly, type, obj);
        }

        static void Task12_1(Type type, Object obj) {
            type.GetMethod("Print")?.Invoke(obj, new object[] { });
            Console.WriteLine("Source course " + type.GetProperty("Course")?.GetValue(obj, null));
            type.GetProperty("Course")?.SetValue(obj, 2);
            Console.WriteLine("Changed course " + type.GetProperty("Course")?.GetValue(obj, null));
        }
        
        static void Task12_2(Assembly assembly, Type type, Object obj) {
            Console.WriteLine(" - Student type parents");
            foreach (var i in assembly.GetTypes().Where(to => type.IsAssignableFrom(to))) {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine(" - Student type interfaces");
            var interfacesInStudent = obj.GetType().GetInterfaces();
            foreach (var i in interfacesInStudent) {
                Console.WriteLine("Interface " + i);
            }

            Console.WriteLine();
        }

        static void Task12_3() {
            Type type2 = typeof(Dictionary<string, int>);
            var activator = Activator.CreateInstance(type2);

            type2.GetMethod("Add")?.Invoke(activator, new object[] {"First", 123});
            type2.GetMethod("Add")?.Invoke(activator, new object[] {"Second", 321});
            type2.GetMethod("Add")?.Invoke(activator, new object[] {"Third", 12});

            object[] parameters = {"First", null};
            object result = type2.GetMethod("TryGetValue")?.Invoke(activator, parameters);
            if ((bool) result) {
                Console.WriteLine("First object parameter" + (int) parameters[1]);
            }
        }

        static void Task12_4() {
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = d.GetFiles("*.dll");
            foreach (FileInfo file in files) {
                Assembly assembly = Assembly.LoadFrom(file.Name);
                foreach (var temp in assembly.GetTypes()) {
                    if (temp.GetInterface("IBinary") != null) {
                        Console.Write("Interface " + temp + " contains IBinary \n");

                        var obj = Activator.CreateInstance(temp);
                        var r = temp.GetMethod("f")?.Invoke(obj, new object[] {2, 4});
                        Console.WriteLine(r);
                    }
                }
            }

            Console.WriteLine("Plugin downloaded");
        }
    }
}