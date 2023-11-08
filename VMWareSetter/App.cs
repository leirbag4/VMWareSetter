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

                string [] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                List<string> validVMsPath = new List<string>();

                foreach (string dir in dirs) 
                {
                    if (IsValidVMDir(dir))
                    {
                        validVMsPath.Add(dir);
                    }
                }

            }

            SaveData.Save();
        }

        private bool IsValidVMDir(string path)
        {


            string[] files = Directory.GetFiles(path);

            return true;
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