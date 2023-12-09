namespace ExamenC_.utils
{
    public class PathManager
    {
        public const int NOT_EXIST_VALUE = 0;
        public const int FILE_VALUE = 1;
        public const int DIRECTORY_VALUE = 2;
        public static bool CheckPath(string path)
        {
            if (path == null)
            {
                MessageBox.Show("¡No se ha especificado una ruta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static int IsFileOrDirectory(string path)
        {
            if (!CheckPath(path)) return NOT_EXIST_VALUE;
            if (File.Exists(path)) return FILE_VALUE;
            if(Directory.Exists(path)) return DIRECTORY_VALUE;
            MessageBox.Show("¡No hay nada en la ruta especificada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return NOT_EXIST_VALUE;
        }
        public static void DeleteValidating(String path)
        {
            switch (IsFileOrDirectory(path))
            {
                case NOT_EXIST_VALUE:
                    break;
                case FILE_VALUE:
                    FileManager.DeleteFile(path);
                    break;
                case DIRECTORY_VALUE:
                    DirectoryManager.DeleteDirectory(path);
                    break;
            }
        }
    }
}
