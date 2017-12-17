using System;
using System.Windows.Forms;

namespace Lab8
{
    public partial class MainWindow : Form
    {
        private readonly EventManager _eventManager;
        private Settings _settings;

        public MainWindow()
        {
            InitializeComponent();
            SettingsInit();
            _eventManager = new EventManager(_settings, MainWindowShow);
        }

        private void SettingsInit()
        {
            _settings = SettingSaver.UpdateProgram();
            logMod.Checked = _settings.IsLog;
            email.Text = _settings.Email;
            fileSize.Value = _settings.FileSize == 0 ? 5000 : _settings.FileSize;
            hideMode.Checked = _settings.HideCheck;
            hotKeyMode.Checked = _settings.IsHotKey;
        }

        private void SaveSettingsButtonClick(object sender, EventArgs e)
        {
            _settings.Email = email.Text;
            _settings.IsLog = logMod.Checked;
            _settings.FileSize = (long) fileSize.Value;
            _settings.HideCheck = hideMode.Checked;
            _settings.IsHotKey = hotKeyMode.Checked;
            if (hideMode.Checked) Hide();
            SettingSaver.SaveConfig(_settings);
        }

        private void MainWindowShown(object sender, EventArgs e)
        {
            if (_settings.HideCheck)
            {
                Hide();
            }
        }

        private void MainWindowShow()
        {
            Show();
        }
    }
}