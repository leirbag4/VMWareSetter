using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection.PortableExecutable;

namespace VMWareSetter
{
    public class SaveData
    {

        public string virtualMachinesPath { get; set; } = "";
        public Machine[] machines { get; set; } = new Machine[0];
        
        
        private static SaveData data = new SaveData();
        private static string filename = "data.cfg";

        public static string VirtualMachinesPath { get { return data.virtualMachinesPath; } set { data.virtualMachinesPath = value; } }
        public static Machine[] Machines { get { return data.machines; } set { data.machines = value; } }
        public static Machine[] GetMachines() { return data.machines; }

        public static void Load()
        {
            string fileData = "";
            
            if(File.Exists(filename))
                fileData = File.ReadAllText(filename);

            if (fileData.Trim() == "")
                fileData = Save();

            data = JsonSerializer.Deserialize<SaveData>(fileData);
        }

        public static string Save() 
        {
            string json = JsonSerializer.Serialize(data);

            File.WriteAllText(filename, json);

            return json;
        }   

    }
}
