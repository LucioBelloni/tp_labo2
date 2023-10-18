using System.Security.Cryptography.X509Certificates;

namespace Entidades
{
    public class Funcionalidades
    {
        public static Usuario Login(string correo, string clave)
        {
            List<Usuario> lista = Archivos.DeserealizarUsuarios();
            Usuario aux = null;

            foreach (Usuario user in lista)
            {
                if (user.Correo == correo && user.Clave == clave)
                {
                    aux = user;
                }
            }
            
            return aux;
        }


    }
}