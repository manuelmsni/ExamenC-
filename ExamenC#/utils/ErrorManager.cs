using ExamenC_.utils;
namespace OnlyZoo.util
{
    public class ErrorManager
    {
        public static void Register(Exception ex)
        {
            ShowToUser(ex);
            Save(ex);
        }
        public static void ShowToUser(Exception ex)
        {
            MessageManager.ShowAlert("Error", $"Se produjo un error:\n\n{ex.Message}");
        }
        public static void Save(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(Constants.ErrorLogFile, true))
            {
                writer.WriteLine($"Fecha y hora: {DateTime.Now}");
                // Escribir la información de la excepción
                writer.WriteLine($"Mensaje de error: {ex.Message}");
                writer.WriteLine($"Tipo de excepción: {ex.GetType().FullName}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}");
                writer.WriteLine(new string('-', 50));
            }
        }
    }
}
