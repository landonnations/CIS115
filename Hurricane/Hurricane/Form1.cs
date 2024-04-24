namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(WindSpeed.Text, out int windSpeed))
            {
                string category;
                if (windSpeed >= 157)
                    category = "a Category 5 Hurricane";
                else if (windSpeed >= 130)
                    category = "a Category 4 Hurricane";
                else if (windSpeed >= 111)
                    category = "a Category 3 Hurricane";
                else if (windSpeed >= 96)
                    category = "a Category 2 Hurricane";
                else if (windSpeed >= 74)
                    category = "a Category 1 Hurricane";
                else
                    category = "not a Hurricane";

                MessageBox.Show($"That wind speed makes this {category}.", "Category");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for wind speed", "Error");
            }
        }
    }
}
