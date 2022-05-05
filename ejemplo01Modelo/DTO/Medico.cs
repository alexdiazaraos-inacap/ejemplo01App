using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo.DTO
{
    public class Medico:Persona
    {
        //1 Atributos
        private String especialidad;
        private List<Paciente> pacientes = new List<Paciente>();

        public Medico(string sexo, string run,string nombre,
            string apellido,Double peso,Double estatura,
            string especialidad, List<Paciente> pacientes)
            :base(sexo,run,nombre,apellido,peso,estatura)
        {
            this.especialidad = especialidad;
            this.pacientes = pacientes;
            base.Sexo = sexo;
            base.Run = run;
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.Peso = peso;
            base.Estatura = estatura;
        }

        //2 Métodos
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }

        public override string ToString()
        {
            return base.ToString() + " - Especialidad: " + this.especialidad;
        }

    }
}
