using Aogami.SMTV.SaveData;
using Aogami.WinForms.Imaging;

namespace Aogami.WinForms
{
    public partial class MainForm : Form
    {
        private SMTVGameSaveData? openedGameSaveData;

        public MainForm()
        {
            InitializeComponent();
            BitmapDrawer.DrawResourceOnPictureBox("Logo", LogoPictureBox, true);
            Size = new(333, 119);
        }

        private async void OpenSaveFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Shin Megami Tensei V save file|GameSave00;GameSave01;GameSave02";
            ofd.Title = "Choose your Shin Megami Tensei V save file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openedGameSaveData = await SMTVGameSaveData.Create(ofd.FileName);
                if (openedGameSaveData == null)
                {
                    MessageBox.Show("It looks like this is not a valid save file. Make sure you try to open an encrypted, 388KB Shin Megami Tensei V save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text = "Aogami";
                    SaveChangesButton.Enabled = false;
                    Size = new(333, 119);
                    return;
                }

                Text = "Aogami � Shin Megami Tensei V Save Editor";
                SaveChangesButton.Enabled = true;
                Size = new(600, 420);
            }
        }

        private async void ImportDecryptedDataButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            using OpenFileDialog ofd = new();
            ofd.Filter = "Shin Megami Tensei V decrypted save file|*.*";
            ofd.Title = "Choose your decrypted Shin Megami Tensei V save file";
            ofd.FileName = $"{openedGameSaveData.FileName}_DECRYPTED";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Please note that this will overwrite everything in your current save file. Are you sure?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                bool success = await openedGameSaveData.ImportDecryptedData(ofd.FileName);
                if (!success) MessageBox.Show("Your data could not be imported. Please check it is a decrypted, 388KB Shin Megami Tensei V save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Your data has been imported successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void ExportDecryptedDataButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            using SaveFileDialog sfd = new();
            sfd.Filter = "Shin Megami Tensei V decrypted save file|*.*";
            sfd.Title = "Save your decrypted Shin Megami Tensei V save file";
            sfd.FileName = $"{openedGameSaveData.FileName}_DECRYPTED";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                await openedGameSaveData.ExportDecryptedData(sfd.FileName);
                MessageBox.Show("Your data has been exported successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            bool makeBackUp = MakeBackUpCheckbox.Checked;
            byte outCode = await openedGameSaveData.SaveDataAsync(makeBackUp);

            if (makeBackUp && outCode != 4) MessageBox.Show("Changes saved successfully. However, I could not make a back-up because the original file was deleted somehow.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Changes saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}