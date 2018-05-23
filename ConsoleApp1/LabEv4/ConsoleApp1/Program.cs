using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using ClassLibrary1;
using System.Globalization;

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
                Console.WriteLine("Escriba apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Escriba fecha de nacimiento (YYYY-MM-DD): ");
                string fecha3 = Console.ReadLine();
                DateTime fecha2 = DateTime.ParseExact(fecha3, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("Escriba rut: ");
                string rut = Console.ReadLine();
            }
            if (opcion == "2")
            {
                Console.WriteLine("Escriba nombre de la Calle de la propiedad: ");
                string calle = Console.ReadLine();
                Console.WriteLine("Escriba numero de la propiedad: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Escriba la comuna: ");
                string comuna = Console.ReadLine();
                Console.WriteLine("Escriba la ciudad: ");
                string ciudad = Console.ReadLine();
                Console.WriteLine("Escriba rut de dueño: ");
                string rut = Console.ReadLine();
                Console.WriteLine("Escriba año de construccion: ");
                int anodeC = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de piezas: ");
                int piezas = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de baños: ");
                int baños = int.Parse(Console.ReadLine());
                Console.WriteLine("Tiene patio?: ");
                string opcion2 = Console.ReadLine();
                bool patio = false;
                if (opcion2 == "si")
                {
                    patio = true;
                }
                Console.WriteLine("Tiene piscina?: ");
                string opcion3 = Console.ReadLine();
                bool piscina = false;
                if (opcion3 == "si")
                {
                    piscina = true;
                }
                
            }
            if (opcion == "3")
            {
                Console.WriteLine("Escriba marca de automoviles: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Escriba modelo automovil: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Escriba año de automovil: ");
                int ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba rut dueño: ");
                string rut = Console.ReadLine();
                Console.WriteLine("Escriba patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Cantidad de Cinturones: ");
                int cinturones = int.Parse(Console.ReadLine());
                Console.WriteLine("Es diesel?: ");
                string opcion4 = Console.ReadLine();
                bool diesel = false;
                if (opcion4 == "si")
                {
                    diesel = true;
                }
                
            }
        }
    }
}
