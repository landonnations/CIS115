namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputValue = textBox1.Text;
            int value;

            if (int.TryParse(inputValue, out value))
            {
                string table = "";
                for (int i = 1; i <= 10; i++)
                {
                    int result = i * value;
                    table += $"{i} * {value} = {result}\n";
                }
                MessageBox.Show(table, "Multiplication Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

    }
}
