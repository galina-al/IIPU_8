using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Lab8
{
    public class Settings
    {
        public bool IsLog { get; set; }
        public string Email { get; set; }
        public long FileSize { get; set; }
        public bool HideCheck { get; set; }
        public bool IsHotKey { get; set; }
    }
}