namespace PaintingEstimate4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Parse length and width input
            if (!double.TryParse(lengthTextBox.Text, out double length) || !double.TryParse(widthTextBox.Text, out double width))
            {
                MessageBox.Show("Please enter valid numeric values for length and width.");
                return;
            }

            // Calculate the area of the room (assuming 9-foot ceilings)
            double area = length * width * 4; // 4 walls
            double cost = area * 6; // $6 per square foot

            // Display the estimate
            resultLabel.Text = $"Estimated cost of painting the room: ${cost}";
        }
    }
}
