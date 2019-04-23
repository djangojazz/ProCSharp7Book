using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter15
{
    public static class Runner
    {
        public static void FindInformationOnTypeConsole()
        {
            Console.WriteLine("************* Welcome to MyTypeViewer **********");
            string typeName = string.Empty;

            do
            {
                Console.WriteLine("\nEnter a type name to evaluate"); ;
                Console.WriteLine("or enter Q to quit: ");

                typeName = Console.ReadLine();

                if(typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    var t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, cannot find the type");
                }

            } while (true);
        }

        static void ListMethods(Type t) => Lister("Methods", () => t.GetMethods().ToList().ForEach(x => Console.WriteLine(x.Name)));

        static void ListFields(Type t) => Lister("Fields", () => t.GetFields().ToList().ForEach(x => Console.WriteLine(x.Name)));

        static void ListProps(Type t) => Lister("Fields", () => t.GetProperties().ToList().ForEach(x => Console.WriteLine(x.Name)));

        static void ListInterfaces(Type t) => Lister("Interfaces", () => t.GetInterfaces().ToList().ForEach(x => Console.WriteLine(x.Name)));

        static void ListVariousStats(Type t) => Lister("Various Statistics", () =>
        {
            Console.WriteLine($"Base class is: {t.BaseType}");
            Console.WriteLine($"is type abstract?: {t.IsAbstract}");
            Console.WriteLine($"is type sealed?: {t.IsSealed}");
            Console.WriteLine($"is type generic?: {t.IsGenericTypeDefinition}");
            Console.WriteLine($"is type a class type?: {t.IsClass}");
        });

        static void Lister(string hdr, Action doer)
        {
            Console.WriteLine($"******** {hdr} *********");
            doer();
            Console.WriteLine();
        }
    }
}
