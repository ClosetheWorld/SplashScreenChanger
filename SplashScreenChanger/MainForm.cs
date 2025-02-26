using LazZiya.ImageResize;
using System.Drawing.Imaging;

namespace SplashScreenChanger
{
    public partial class MainForm : Form
    {
        private static string SplashScreenFilePath = 
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Steam\steamapps\common\VRChat\EasyAntiCheat\SplashScreen.png";
        private string _selectedImageFilePath;
        private Image _selectedImage;
        private Image _scaledImage;

        public MainForm()
        {
            InitializeComponent();
            applyButton.Enabled = false;
        }

        #region EventHandlers
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _selectedImageFilePath = ofd.FileName;                
                _selectedImage = Image.FromFile(_selectedImageFilePath);
                _scaledImage = _selectedImage.ScaleAndCrop(800, 450, TargetSpot.Center);
                selectedImage.Image = _scaledImage;
                applyButton.Enabled = true;
            }
        }

        private async void applyButton_Click(object sender, EventArgs e)
        {
            await SaveImageAsync();

            MessageBox.Show("äÆóπÇµÇ‹ÇµÇΩÅI", "äÆóπ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Methods
        private async Task SaveImageAsync()
        {
            using var fs = new FileStream(@"SplashScreen.png", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _scaledImage.Save(fs, ImageFormat.Png);

            var splashScreenFileNameWithoutExtension = Path.GetFileNameWithoutExtension(SplashScreenFilePath);
            var backupFilePath = Path.Combine(Path.GetDirectoryName(SplashScreenFilePath), splashScreenFileNameWithoutExtension + " - backup.png");
            File.Copy(SplashScreenFilePath, backupFilePath, true);
            using var wfs = new FileStream(SplashScreenFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _scaledImage.Save(wfs, ImageFormat.Png);
        }
        #endregion
    }
}
