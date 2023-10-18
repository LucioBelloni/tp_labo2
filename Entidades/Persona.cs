

namespace Entidades
{
     public abstract class Persona
     {
        protected string nombre;
        protected string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
          
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public abstract string Mostrar();
        
     }
}
