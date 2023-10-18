using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public class Archivos
    {
        private static string pathUsuario = Path.Combine(Archivos.TryGetSolutionDirectoryInfo().Parent.FullName, @"Usuarios.json");
        public static string PathUsuario { get => pathUsuario;}

        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            DirectoryInfo directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("Program.cs").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        public static List<Usuario> DeserealizarUsuarios()
        {
            List<Usuario> usuarios = new();
            if (File.Exists(Archivos.pathUsuario))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Archivos.pathUsuario))
                    {
                        string json_str = sr.ReadToEnd();
                        usuarios = JsonSerializer.Deserialize(json_str, typeof(List<Usuario>)) as List<Usuario> ?? new(); // el operador as es para expresiones que devuelven nulos. ?? me pregunto si es nulo
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error cargando lista usuarios: {ex.Message}\n {ex.StackTrace}"); // StackTrace la pila de llamados. cual fue la jerarquia del error. 
                }
            }
            else
            {
                Console.WriteLine("No se encontró el path");
            }
            return usuarios;
        }

        public static void SerealizarUsuarios(List<Usuario> usuarios)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(Archivos.pathUsuario))
                {
                    writer.Write(JsonSerializer.Serialize(usuarios));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }
    }
}
