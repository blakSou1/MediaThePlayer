using System.Media;

namespace mp3_pleer
{
    public partial class Form1 : Form
    {
        private SoundPlayer? player;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Œ¯Ë·Í‡!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                OpenMedia();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void ÓÚÍ˚Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMedia();
        }

        private void OpenMedia()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "All Supported Audio | *.mp3; *.wav; *.aac; *.wma | MP3 files (*.mp3) | *.mp3 | Wave files (*.wav) | *.wav | AAC files (*.aac) | +.aac | Windows Media Audio files (*.wma) | *.wma;",
                Multiselect = false,
                ValidateNames = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = textBox1.Text = ofd.FileName;
            }

        }

    }
}