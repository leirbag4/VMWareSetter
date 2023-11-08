namespace VMWareSetter
{
    public partial class App : Form
    {
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
                        machines.Add(Machine.CreateFromPath(validName, path));
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


        private void Alert(string str)
        {
            MessageBox.Show(str);
        }

        private void Println(string str)
        { 
            outp.Text += str + "\n";
        }
    }
}