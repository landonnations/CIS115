namespace TestScoreList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] testScores = new int[8];

            // Loop through each TextBox and parse its value to an integer
            for (int i = 0; i < 8; i++)
            {
                // Validate if the input is a valid integer
                if (!int.TryParse(Controls["textBox" + (i + 1)].Text, out testScores[i]))
                {
                    MessageBox.Show("Please enter valid integer values for all test scores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Calculate the average score
            double averageScore = testScores.Average();

            // Display the average score
            MessageBox.Show($"Average Score: {averageScore:F2}", "Average Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Display each test score along with the difference from the average
            string resultMessage = "";
            for (int i = 0; i < 8; i++)
            {
                int difference = testScores[i] - (int)averageScore;
                resultMessage += $"Test score {i + 1}: {testScores[i]}, difference from average: {difference}\n";
            }

            MessageBox.Show(resultMessage, "Test Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
