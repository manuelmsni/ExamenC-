namespace ExamenC_.utils
{
    public class DirectoryManager
    {
        /// <summary>
        /// Crea un directorio en la ruta especificada dentro del directorio base.
        /// </summary>
        /// <param name="nombre">Nombre del directorio a crear.</param>
        public static bool CreateDirectory(string ruta)
        {
            if (ruta == null) return false;
            if (ruta == string.Empty || File.Exists(ruta) || Directory.Exists(ruta)) return false;
            Directory.CreateDirectory(ruta);
            return true;
        }
        public static void DeleteDirectory(string path)
        {
            if (!MessageManager.AskForConfirmation($"Se eliminará la carpeta: {path} \n¿Deseas borrarlo?  :(")) return;
            Directory.Delete(path);
            MessageBox.Show($"Se ha eliminado el directorio {path}", "Eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
