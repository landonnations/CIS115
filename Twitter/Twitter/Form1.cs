namespace Twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            textBox1.Multiline = true;

            int characterCount = textBox1.Text.Length;
            label1.Text = $"Character Count: {characterCount}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int characterCount = textBox1.Text.Length;
            if (characterCount > 140)
            {
                MessageBox.Show("Twitter only allows posts up to 140 characters, please check your post and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Posted!", "Successful");
            }
        }
    }
}
