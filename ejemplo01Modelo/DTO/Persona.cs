using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01Modelo
{
    public struct Estado
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }

   
    public class Persona
    {
        //1 atributos
        //visibilidad tipo nombre valor
        private String sexo;
        private String run;
        private string nombre;
        private String apellido;
        private Double peso;
        private Double estatura;

        //3 constructores
        public Persona(string sexo, string run, string nombre, string apellido)
        {
            this.sexo = sexo;
            this.run = run;
            this.nombre = nombre;
            this.apellido = apellido;
            this.peso = 50;
            this.estatura = 1.5;
        }

        public Persona(string sexo, string run, string nombre, string apellido, double peso, double estatura)
        {
            this.sexo = sexo;
            this.run = run;
            this.nombre = nombre;
            this.apellido = apellido;
            this.peso = peso;
            this.estatura = estatura;
        }

		//2 metodos
		public string Sexo { get => sexo; set => sexo = value; }
        public string Run { get => run; set => run = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        // Creamos una property para el Estado (struct)

        public Estado Estado { get; set; }

        // Creamos una property para el IMC
        public Double IMC
        {
            get
            {
                return this.peso / (this.estatura * this.estatura);
            }
        }
        public override string ToString()
        {
            String saludo;
            if (sexo.Equals("masculino"))
            {
                saludo = "Don ";
            }
            else
            {
                saludo = "Doña ";
            }

            return saludo + this.nombre + " " + this.apellido;
        }
    }
}
