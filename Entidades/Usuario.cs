
using System.Text;

namespace Entidades
{
    public class Usuario : Persona
    {
        private string clave;
        private string correo;
        private string perfil;
        private double saldo;



        public Usuario(string clave, string correo , string nombre, string apellido): base (nombre, apellido)
        {
            this.clave = clave;
            this.correo = correo;
            this.saldo = 0;
            this.perfil = "usuario";
       
        }
        



        public string Clave { get => clave; set => clave = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Saldo: {this.saldo}");
            sb.AppendLine($"Clave: {this.clave}");
            sb.AppendLine($"Correo: {this.correo}");
            sb.AppendLine($"Perfil: {this.perfil}");
           
            return sb.ToString();
        }


    }
}
