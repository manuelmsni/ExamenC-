using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ExamenC_
{
    public partial class MainForm : Form
    {
        private static MainForm Instance { get; set; }
        private ToolStripStatusLabel _statusLabel { get; set; }
        private MainForm()
        {
            InitializeComponent();
            InnitCustom();
        }
        public static MainForm GetInstance()
        {
            if (Instance == null) Instance = new MainForm();
            return Instance;
        }

        /* * * * * * * * * * * * *
         *  Inicio Personalizado *
         * * * * * * * * * * * * */

        private void InnitCustom()
        {
            InitStatusLabel();
            this.Load += OnLoad;
        }
        private void InitStatusLabel()
        {
            _statusLabel = new ToolStripStatusLabel("Iniciando...");
            _statusStrip.Items.Add(_statusLabel);
        }

        /* * * * * * * * * *
         * Funcionalidades *
         * * * * * * * * * */

        public static void SetStatus(string text)
        {
            Instance._statusLabel.Text = text;
        }

        /* * * * * *
         * Eventos *
         * * * * * */

        private void OnLoad(object sender, EventArgs e)
        {
            SetStatus("Iniciado");
        }
    }
}