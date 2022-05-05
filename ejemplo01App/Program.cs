using ejemplo01Modelo;
using ejemplo01Modelo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01App
{
    class Program
    {
        //1 Creamos un atributo igual a la lista del PersonaDAL para actualizar la listra de acuerdo a los métodos
        private static PersonaDAL personaDAL = new PersonaDAL();
        private static PacienteDAL pacienteDAL = new PacienteDAL();
        private static MedicoDAL medicoDAL = new MedicoDAL();


        public static bool Menu()
        {
            bool continuar = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***** MENU DE OPCIONES ********");
            Console.WriteLine("1. Para Agregar una Persona.");
            Console.WriteLine("2. Para Mostrar el listado de personas.");
            Console.WriteLine("3. Para Modificar una Persona.");
            Console.WriteLine("4. Para Eliminar una Persona.");
            Console.WriteLine("0. Para Salir.");
            Console.WriteLine("--------------------------------");
            string opcion = Console.ReadLine().Trim();
			switch (opcion)
			{
                case "1":
                    Console.WriteLine(".....agregando");
                    Ingresar();
                    break;
                case "2":
                    Console.WriteLine(".....mostrando");
                    Mostrar();
                    break;
                case "3":
                    Console.WriteLine(".....modificando");
                    break;
                case "4":
                    Console.WriteLine(".....eliminando");
                    Eliminar();
                    break;
                case "0":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hasta la vista Shoro");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Solo se permiten números entre 0 y 4");
                    break;
			}

			return continuar;
        }

        static void Ingresar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string sexo;
            bool sexoValido = false;
            do
            {
                Console.WriteLine("Ingrese sexo: ");
                sexo = Console.ReadLine().Trim();
                if (sexo.Equals("masculino") || sexo.Equals("femenino"))
                {
                    sexoValido = true;
                }
                else
                {
                    sexoValido = false;
                }
            } while (!sexoValido);

            Console.WriteLine("Ingrese RUN: ");
            string run = Console.ReadLine().Trim();

            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine().Trim();

            Console.WriteLine("Ingrese su apellido: ");
            String apellido = Console.ReadLine().Trim();

            bool pesoValido = false;
            Double peso;
            do
            {
                Console.WriteLine("Ingrese su peso: ");
                string pesoTxt = Console.ReadLine().Trim();
                pesoValido = Double.TryParse(pesoTxt, out peso);
            } while (!pesoValido);

            bool estaturaValida = false;
            Double estatura;
            do
            {
                Console.WriteLine("Ingrese su estatura: ");
                estaturaValida = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!estaturaValida);
            
            // Ahora que tenemos todos los atributos, creamos un objeto
            Persona p = new Persona(sexo, run, nombre, apellido, peso, estatura);
            //********************** Esto lo agregamos con elñ struct *******
            //Parametrizaremos el Estado (struct)
            if (p.IMC < 0.185)
            {
                p.Estado = PersonaDAL.DELGADO;
            }else if(p.IMC >= 0.185 && p.IMC < 0.25)
            {
                p.Estado = PersonaDAL.NORMAL;
            }
            else
            {
                p.Estado = PersonaDAL.OBESIDAD;
            }
            //***************************************************************
            // Agregamos el objeto creado a la lista del DAL
            personaDAL.Ingresar(p);
        }

        private static void Mostrar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***** LISTADO DE PERSONAS *******");
            Console.WriteLine("---------------------------------");
            //Crear una lista igualita a la que tiene el dal para cargar en pantalla
            List<Persona> personas = personaDAL.Mostrar();
            if (personas.Count < 1)
            {
                Console.WriteLine("....NO SE REGISTRAN PERSONAS EN EL LISTADO");
            }
            else
            {
                foreach (var px in personas)
                    {
                    Console.WriteLine(px + " - IMC: " + px.IMC + " - Estado: " 
                        + px.Estado.Nombre + " (" + px.Estado.Codigo + ").");
                    }
            }            
            Console.WriteLine("---------------------------------");
        }

        private static void Eliminar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // creamos una lista igualita a la que esta en personaDAL
            List<Persona> personas = personaDAL.Mostrar();

            if (personas.Count < 1)
            {
                Console.WriteLine("....NO SE REGISTRAN PERSONAS EN EL LISTADO");
            }
            else
            {
                for (int i = 0; i < personas.Count(); i++)
                {
                    Console.WriteLine("{0} ==> {1}", i, personas[i]);
                }
                Console.WriteLine("Ingrese el indice del elemento que desea eliminar:\n");

                bool indiceValido = false;
                int indice;
                do
                {
                    indiceValido = Int32.TryParse(Console.ReadLine().Trim(), out indice);
                } while (!indiceValido);

                personaDAL.Eliminar(personas[indice]);
                Mostrar();
                /**
                 * por hacer: 
                 * Mostramos la lista actualizada
                 */
            }

            //1 Mostramos el listado actual
            Mostrar();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Buenas tardes");

            while (Menu()) ;            
        }
    }
}
