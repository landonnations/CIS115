using System;
using System.Windows.Forms;

namespace FineForOverdueBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse input values
            if (!int.TryParse(txtNumBooks.Text, out int numBooks) || !int.TryParse(txtNumDays.Text, out int numDays))
            {
                MessageBox.Show("Please enter valid numbers for books checked out and days overdue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate fine
            double fine = CalculateFine(numBooks, numDays);

            // Display result
            lblResult.Text = $"Fine for {numBooks} books overdue for {numDays} days: ${fine.ToString("0.00")}";
        }

        private double CalculateFine(int numBooks, int numDays)
        {
            const double firstWeekFineRate = 0.10; // 10 cents per book per day for the first seven days
            const double additionalFineRate = 0.20; // 20 cents per book per day for each additional day
            const int firstWeekThreshold = 7;

            double fine = 0;

            // Calculate fine for the first seven days
            int daysInFirstWeek = Math.Min(numDays, firstWeekThreshold);
            fine += numBooks * daysInFirstWeek * firstWeekFineRate;

            // Calculate fine for additional days
            if (numDays > firstWeekThreshold)
            {
                int additionalDays = numDays - firstWeekThreshold;
                fine += numBooks * additionalDays * additionalFineRate;
            }

            return fine;
        }
    }
}
