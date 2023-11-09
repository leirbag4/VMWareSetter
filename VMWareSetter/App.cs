using System;

namespace VMWareSetter
{
    public partial class App : Form
    {

        private Machine SelectedMachine { get  { if (machinesList.Items.Count > 0) { if (machinesList.SelectedItem != null) { Machine machine = ((MachineItem)machinesList.SelectedItem).machine; if (machine != null) return machine; } } return null; } }

        private struct PropAndValue
        { 
            public string Property;
            public string Value;
        }

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SaveData.Load();

            // ----------------------------
            // fill controls from savedata
            machinesPath.Text = SaveData.VirtualMachinesPath;
            FillVMList();
            SelectMachine(0);
            // ----------------------------

            base.OnLoad(e);
        }

        private void OnFindPressed(object sender, EventArgs e)
        {
            string path = machinesPath.Text;

            if (string.IsNullOrEmpty(path))
            {
                Alert("Virtual Machines path is empty");
            }
            else
            {

                SaveData.VirtualMachinesPath= path;

                string [] dirs = Directory.GetDirectories(path);
                List<Machine> machines = new List<Machine>();

                foreach (string dir in dirs) 
                {
                    string validName = IsValidVMDir(dir);

                    if (validName != "") 
                        machines.Add(Machine.CreateFromPath(validName, dir));
                }

                SaveData.Machines = machines.ToArray();

                /*foreach (var machine in machines) 
                {
                    Println(machine.ToString());
                }*/

            }

            SaveData.Save();

            FillVMList();
            SelectMachine(0);
        }

        private void SelectMachine(int index)
        {
            if((machinesList.Items.Count > 0) && (index != -1))
                machinesList.SelectedIndex = index;

            Machine machine = SelectedMachine;

            if (machine != null)
            {
                ReadMachineProps(machine);
            }
        }



        private void ReadMachineProps(Machine machine)
        {
            string filename = machine.GetVMXFile();
            
            if (File.Exists(filename))
            {
                string data = File.ReadAllText(filename);
                string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                Clear();
                propertiesList.Items.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');

                    string prop = parts[0].Trim();
                    string value =  parts[1].Trim();
                    InsertPropertyAndValue(prop, value);
                    
                }
            }
        }

        private void InsertPropertyAndValue(string property, string value)
        {
            ListViewItem item = new ListViewItem(property);
            item.SubItems.Add(value);
            propertiesList.Items.Add(item);
        }

        private void FillVMList()
        {
            machinesList.Items.Clear();

            var machines = SaveData.Machines;

            foreach (var machine in machines)
            {

                machinesList.Items.Add(new MachineItem(machine));

            }
        }


        private string IsValidVMDir(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                string filename =   Path.GetFileNameWithoutExtension(file);
                string extension =  Path.GetExtension(file);
                
                if (extension == ".vmx")
                    return filename;
            }

            return "";
        }

        private void Clear()
        {
            outp.Text = "";
        }

        private void Alert(string str)
        {
            MessageBox.Show(str);
        }

        private void Println(string str)
        { 
            outp.Text += str + "\n";
        }

        private void OnMachineIndexChanged(object sender, EventArgs e)
        {
            int index = machinesList.SelectedIndex;
            SelectMachine(index);
        }

        private void OnPropertySelectedChanged(object sender, EventArgs e)
        {
            if (propertiesList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = propertiesList.SelectedItems[0];


                PropAndValue propAndVal = new PropAndValue() { Property = selectedItem.SubItems[0].Text, Value = selectedItem.SubItems[1].Text };
                propValueInp.Tag = propAndVal;


                if (selectedItem.SubItems.Count > 1)
                {
                    string valorSegundaColumna = selectedItem.SubItems[1].Text;
                    propValueInp.Text = valorSegundaColumna;
                }
            }
        }

        private void OnPropValueChanged(object sender, EventArgs e)
        {
            PropAndValue propAndVal = (PropAndValue)propValueInp.Tag;

            Println("prop: " + propAndVal.Property + " val: " + propAndVal.Value);
        }
    }
}