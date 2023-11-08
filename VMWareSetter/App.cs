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
                
            }
        }


        private void Alert(string str)
        {
            MessageBox.Show(str);
        }
    }
}