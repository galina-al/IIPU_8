using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    static class SettingSaver
    {
        private const string FileName = "./sys.txt";
        static public Settings UpdateProgram()
        {
            try
            {
                using (var streamReader = new StreamReader(FileName))
                {
                    return JsonConvert.DeserializeObject<Settings>(Decode(streamReader.ReadToEnd()));
                }
            }
            catch (Exception)
            {
                return new Settings();
            }
        }

        static public void SaveConfig(Settings config)
        {
            using (var streamWriter = new StreamWriter(FileName, false))
            {
                streamWriter.Write(Encode(JsonConvert.SerializeObject(config)));
            }
        }

        static private string Encode(string content)
        {
            var tempList = content.ToList();
            for (int i = 0; i < tempList.Count; i++)
            {
                tempList[i] = (char)(tempList[i] ^ 1);
            }
            return string.Join("", tempList);
        }

        static private string Decode(string content)
        {
            var tempList = content.ToList();
            for (int i = 0; i < tempList.Count; i++)
            {
                tempList[i] = (char)(tempList[i] ^ 1);
            }
            return string.Join("", tempList);
        }
    }
}
