
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

            UserProfile userProfile = new UserProfile();

            userProfile.PathFrom = fullPathFrom;

            userProfile.PathTo = fullPathTo;

            userProfile.Timestamp = (int)DateTimeOffset.Now.ToUnixTimeSeconds();

            userProfile = new UserProfile();


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
            UserProfile userProfile = new UserProfile();
            MessageBox.Show(userProfile.Name);
            MessageBox.Show(userProfile.PathTo);
            MessageBox.Show(userProfile.PathFrom);
        }
    }
}
