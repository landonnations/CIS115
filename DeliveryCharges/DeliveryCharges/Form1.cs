namespace DeliveryCharges
{
    public partial class Form1 : Form
    {
        // Arrays to hold zip codes and delivery charges
        private string[] zipCodes = { "28789", "28713", "28719", "28779", "28771", "28901", "28904", "28906", "28734", "28786" };
        private double[] deliveryCharges = { 5.99, 6.99, 7.99, 8.99, 9.99, 10.99, 11.99, 12.99, 13.99, 14.99 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputZipCode = textBox1.Text.Trim();

            // Check if the input zip code exists in the array
            int index = Array.IndexOf(zipCodes, inputZipCode);
            if (index != -1)
            {
                // If found, display the corresponding delivery charge
                MessageBox.Show($"Delivery charge to {inputZipCode}: ${deliveryCharges[index]}");
            }
            else
            {
                // If not found, display a message indicating no delivery
                MessageBox.Show($"Sorry, we do not deliver to {inputZipCode}");
            }
        }
    }
}
