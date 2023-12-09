using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExamenC_.views
{
    public partial class StringForm : Form
    {
        // Instancia de la clase StringForm (Singleton).
        private static StringForm thisInstance;
        
        private StringForm()
        {
            InitializeComponent();
        }

        public static string GetString(string title, string message)
        {
            if (thisInstance == null || thisInstance.IsDisposed)
                thisInstance = new StringForm();
            ResetWindow(title, message);
            DialogResult result = thisInstance.ShowDialog();
            if (result != DialogResult.OK) return null;
            else if (string.IsNullOrEmpty(thisInstance.texto.Text))
            {
                MessageBox.Show($"No has introducido nada.", "Acción cancelada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return thisInstance.texto.Text;
        }

        private static void ResetWindow(string title, string message)
        {
            thisInstance.Text = title;
            thisInstance.mensaje.Text = message;
            thisInstance.texto.Text = string.Empty;
            thisInstance.TopMost = true;
        }

        /* * * * * *
         * Eventos * ----------------------------------------------------------------------------
         * * * * * */

        /// <summary>
        /// Maneja el evento de clic en el botón de aceptar.
        /// Establece el texto del input como resultado del task.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            thisInstance.Close();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de cancelar.
        /// Establece una cadena vacía como resultado del task.
        /// Esto será gestionado posteriormente para no crear un archivo / directorio si la cadena está vacía.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            thisInstance.Close();
        }
    }
}
