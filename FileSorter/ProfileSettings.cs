
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
            fullPathTo = setPathToUserChoice(textBoxPathTo);
            
        }

        private void buttonPathFrom_Click(object sender, EventArgs e)
        {
            fullPathFrom = setPathToUserChoice(textBoxPathFrom);
        }

        private String setPathToUserChoice(TextBox textbox)
        {
            dialogFolderPath.ShowDialog();
            String selectedPath = dialogFolderPath.SelectedPath;

            if (!String.IsNullOrEmpty(selectedPath))
            {
                textbox.Text = new DirectoryInfo(dialogFolderPath.SelectedPath).Name;
            }
            
            return dialogFolderPath.SelectedPath;
        }


        private void getCheckedExtetions()
        {
            
            foreach (String exte in extectionBoxList.SelectedItems) {

                MessageBox.Show(exte);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getCheckedExtetions();
        }
    }
}
