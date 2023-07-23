// Author: hoshi
// Year: 2023

using System.Speech.Synthesis;

namespace cina {
    public partial class Main : Form {
        public List<string> text {
            get; set;
        }
        public int i;
        public Main() {
            InitializeComponent();
            Thread.Sleep(1000);
            text = new List<string>();
            this.ActiveControl = cinaWords;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (i == text.Capacity - 1) {
                i = -1;
                MessageBox.Show("Done");
                return;
            }
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer()) {
                synthesizer.SelectVoice("Microsoft Huihui Desktop");
                i++;
                synthesizer.Speak(text[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {
            i = -1;
            string lines = cinaWords.Text;
            text = new List<string>(lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
            Thread.Sleep(100);
            label1.Text = "Imported " + text.Capacity + " word(s) successfully";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void hide_Click(object sender, EventArgs e) {
        }
        private void repeat_Click(object sender, EventArgs e) {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer()) {
                if (i >= text.Capacity) {
                    i = 0;
                }
                synthesizer.SelectVoice("Microsoft Huihui Desktop");
                synthesizer.Speak(text[i]);

            }
        }
        private void RandomizeList<T>(List<T> list) {
            Random random = new Random();
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            RandomizeList(text);
            string randomtext = string.Join(Environment.NewLine, text);
            cinaWords.Text = randomtext;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cinaWords.Visible == true) {
                cinaWords.Hide();
                hideToolStripMenuItem.Text = "Show";
            } else {
                cinaWords.Show();
                hideToolStripMenuItem.Text = "Hide";
            }
        }

    }
}
