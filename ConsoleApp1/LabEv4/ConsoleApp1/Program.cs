using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("ClassLibrary1")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        static void Main(string[] args)
        {
            List<Person> personas = new List<Person>();
            Assembly assembly = Assembly.LoadFile("");
            Console.WriteLine("Bienvenido al Registro Civil!");
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1) Inscribir Persona");
            Console.WriteLine("2) Inscribir Propiedades");
            Console.WriteLine("3) Inscribir Automoviles");
            Console.WriteLine("Escriba su opcion: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Escriba Nombre: ");
                string nombre = Console.ReadLine();

            }
        }
    }
}
