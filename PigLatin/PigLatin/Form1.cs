namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word, piglatin;
            word = inputWord.Text;
            piglatin = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay";
            outputText.Text = piglatin;
        }
    }
}
