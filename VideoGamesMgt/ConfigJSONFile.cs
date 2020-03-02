using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesMgt
{
    public class ConfigJSONFile
    {
        private string user;
        private string password;
        private string database;
        private string serverIP;

        public ConfigJSONFile() { }

        public ConfigJSONFile(string user, string password, string database, string serverIP)
        {
            this.user = user;
            this.password = password;
            this.database = database;
            this.serverIP = serverIP;
        }

        public string User { get { return this.user; } set { this.user = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Database { get { return this.database; } set { this.database = value; } }
        public string ServerIP { get { return this.serverIP; } set { this.serverIP = value; } }


        public static ConfigJSONFile ReadJSONFile(string fileName)
        {
            string configInJsonFormat = File.ReadAllText(fileName);
            return FromJson(configInJsonFormat);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        private static ConfigJSONFile FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<ConfigJSONFile>(jsonString);
        }



    }
}
