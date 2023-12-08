using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ExamenC_
{
    public partial class MainView : Form
    {
        private static MainView Instance { get; set; }
        private ToolStripStatusLabel _statusLabel { get; set; }
        private MainView()
        {
            InitializeComponent();
            InnitCustom();
        }
        public static MainView GetInstance()
        {
            if (Instance == null) Instance = new MainView();
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