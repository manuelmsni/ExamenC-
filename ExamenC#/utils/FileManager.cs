using OnlyZoo.util;

namespace ExamenC_.utils
{
    public class FileManager
    {
        public static int? SaveFile(string path, string text)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(text);
                }
                MessageBox.Show($"Contenido guardado en el archivo: {path}", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return text.GetHashCode();
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
            }
            return null;
        }
        public static string LoadFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
            }
            return null;
        }
        public static void DeleteFile(string path)
        {
            if (!MessageManager.AskForConfirmation($"Se eliminará el archivo: {path} \n¿Deseas borrarlo?  :(")) return;
            File.Delete(path);
            MessageManager.ShowMessaje("Eliminado correctamente", $"Se ha eliminado el archivo {path}");
        }
        /// <summary>
        /// Crea un archivo en la ruta especificada dentro del directorio base si el archivo no existe.
        /// </summary>
        /// <param name="nombre">Nombre del archivo a crear.</param>
        public static bool CreateFile(string ruta)
        {
            if (ruta == null) return false;
            if (ruta == string.Empty || File.Exists(ruta) || Directory.Exists(ruta)) return false;
            DirectoryManager.CreateDirectory(Path.GetDirectoryName(ruta));
            FileStream fs;
            if ((fs = File.Create(ruta)) != null) fs.Close();
            return true;
        }
    }
}
