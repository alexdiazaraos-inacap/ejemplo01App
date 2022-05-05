using ejemplo01Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo.DAL
{
    public class MedicoDAL
    {
        //1 atributos
        // Crear una lista para emular la gestión en la tabla de la BD
        public static List<Medico> medicos = new List<Medico>();

        //2 Metodos
        public void Agregar(Medico p)
        {
            medicos.Add(p);
        }

        public List<Medico> Mostrar()
        {
            return medicos;
        }

        public void Eliminar(Medico p)
        {
            medicos.Remove(p);
        }

        //Por hacer:(tarea) implementar el modificar y un buscar
    }
}
