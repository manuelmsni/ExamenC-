using ExamenC_.clients;
using ExamenC_.components;
using ExamenC_.models;
using ExamenC_.utils;
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
            GetData();
        }
        private void InitStatusLabel()
        {
            _statusLabel = new ToolStripStatusLabel("Iniciando...");
            _statusStrip.Items.Add(_statusLabel);
        }
        private bool GetData()
        {
            var data = HttpJsonClient<CustomObject>.RequestDataAsync(Constants.BASE_URL_API, "pokemon");
            return false;
        }

        /* * * * * * * * * *
         * Funcionalidades *
         * * * * * * * * * */

        public static void SetStatus(string text)
        {
            Instance._statusLabel.Text = text;
        }
        public async void UpdateData()
        {
            await DataBuffer.GetInstance().UpdateCustomObjects();
            DataBuffer.GetInstance().CustomObjects.ForEach(o => {
                MainContainer.Controls.Add(new CustomButton(o));
            });
        }
        private void AddDataComponent(CustomButton cb)
        {

        }
        private void Reset()
        {
            MainContainer.Controls.Clear();
        }

        /* * * * * *
         * Eventos *
         * * * * * */

        private void OnLoad(object sender, EventArgs e)
        {
            SetStatus("Iniciado");
        }

        private void MenuCustomObjects_Click(object sender, EventArgs e)
        {
            Reset();
            UpdateData();
        }
    }
}