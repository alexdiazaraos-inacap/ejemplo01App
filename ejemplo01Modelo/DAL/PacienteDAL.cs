using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo.DAL
{
    public class PacienteDAL
    {
        //1 atributos
        // Crear una lista para emular la gestión en la tabla de la BD
        public static List<Paciente> pacientes = new List<Paciente>();

        //2 Metodos
        public void Agregar(Paciente p)
        {
            pacientes.Add(p);
        }

        public List<Paciente> Mostrar()
        {
            return pacientes;
        }

        public void Eliminar(Paciente p)
        {
            pacientes.Remove(p);
        }

        //Por hacer:(tarea) implementar el modificar y un buscar
    }
}
