
namespace FileSorter
{
    public partial class ProfileSettings : Form
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }


        private string fullPathFrom;
        private string fullPathTo;

        private void buttonPathTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fromPath = getFolderPath();
            textBoxPathFrom.Text = fromPath.RootFolder.ToString();

            fullPathFrom = fromPath.SelectedPath;

        }

        private void buttonPathFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fromPath = getFolderPath();
            textBoxPathTo.Text = fromPath.RootFolder.ToString();

            fullPathTo = fromPath.SelectedPath;
        }

        private FolderBrowserDialog getFolderPath()
        {
            dialogFolderPath.ShowDialog();
            return dialogFolderPath;
        }

        private void buttonTestGetUserData_Click(object sender, EventArgs e)
        {
           
        }

        private void getCheckedExtetions()
        {
           string checked = extectionBoxList.CheckedItems;
        }
    }
}
