using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo
{
    public class Paciente:Persona
    {
        //1 Atributos
        private int prioridad;
        private String salud;

        //3 Constructor
        public Paciente(int prioridad, string salud, 
            string sexo, string run, string nombre, string apellido,Double peso, Double estatura)
            :base(sexo,run,nombre,apellido,peso,estatura)
        {
            this.Prioridad = prioridad;
            this.Salud = salud;
            base.Sexo = sexo;
            base.Run = run;
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.Peso = peso;
            base.Estatura = estatura;
        }


        //2 metodos
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public string Salud { get => salud; set => salud = value; }

        public override string ToString()
        {
            return base.ToString() + 
                " - Sistema Salud: " + 
                this.Salud;
        }

    }
}
