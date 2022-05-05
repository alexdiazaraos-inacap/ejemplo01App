using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo
{
	public class PersonaDAL
	{
		//1 atributos
		// Crear una lista para emular la gestión en la tabla de la BD
		public static List<Persona> personas = new List<Persona>();

		public static readonly Estado OBESIDAD = new Estado()
		{
			Nombre = "Awuatonao", Codigo = "E01"

		};

		public static readonly Estado NORMAL = new Estado()
		{
			Nombre = "Tay Joya",
			Codigo = "E02"

		};

		public static readonly Estado DELGADO = new Estado()
		{
			Nombre = "Gueso Pollo",
			Codigo = "E03"

		};


		//2 Metodos
		public void Ingresar(Persona p)
		{
			personas.Add(p);
		}

		public List<Persona> Mostrar()
		{
			return personas;
		}

		public void Eliminar(Persona p)
		{
			personas.Remove(p);
		}
	}
}
