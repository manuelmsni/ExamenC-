
namespace ExamenC_.utils
{
    public class MessageManager
    {
        public static bool AskForConfirmation(string messaje)
        {
            if (MessageBox.Show(messaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) return true;
            return false;
        }
        public static void ShowMessaje(string title, string messaje)
        {
            MessageBox.Show(messaje, title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ShowAlert(string title, string messaje)
        {
            MessageBox.Show(messaje, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
