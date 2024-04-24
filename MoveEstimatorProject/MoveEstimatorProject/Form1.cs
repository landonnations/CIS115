namespace MoveEstimatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours, miles, total;
            hours = Convert.ToInt32(textBox1.Text);
            miles = Convert.ToInt32(textBox2.Text);
            total = 200 + (hours * 150) + (miles * 2);
            textBox3.Text = "$" + total;

        }
    }
}
