using System.Numerics;

namespace RavensStartingLineup2024
{
    public partial class Form1 : Form
    {
      
        private Dictionary<string, Player> players = new Dictionary<string, Player>()
        {
            //populate players dictionary
            {"QB", new Player("Lamar Jackson", 8, "6'2\"", 212, "Louisville", "Pompano Beach, FL", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\LamarPic.png")},
            {"RB", new Player("Derrick Henry", 22, "6'3\"", 247, "Alabama", "Yulee, FL", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Derrick Henry.png")},
            {"WR1", new Player("Zay Flowers", 4, "5'11\"", 174, "Boston College", "Fort Lauderdale, FL", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Zay Flowers.png")},
            {"WR2", new Player("Rashod Bateman", 0, "6'2\"", 210, "Minnesota", "Tifton, GA", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Rashod Bateman.png")},
            {"WR3", new Player("Devontez Walker", 81, "6'2\"", 201, "UNC", "Charlotte, North Carolina", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Tez Walker.png")},
            {"TE1", new Player("Mark Andrews", 89, "6'5\"", 256, "Oklahoma", "Scottsdale, AZ", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Mark Andrews.png")},
            {"TE2", new Player("Isaiah Likely", 80, "6'4\"", 240, "Coastal Carolina", "Fort Lauderdale, FL", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Isaiah Likely.png")},
            {"RT", new Player("Roger Rosengarten", 79, "6'7\"", 320, "Washington", "Littleton, CO", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Roger Rosengarten.png")},
            {"RG", new Player("Ben Cleveland", 66, "6'6\"", 343, "Georgia", "Toccoa, GA", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Ben Cleveland.png")},
            {"C", new Player("Tyler Linderbaum", 65, "6'3\"", 289, "Iowa", "Solon, IA", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Tyler Linderbaum.png")},
            {"LG", new Player("Andrew Vorhees", 72, "6'6\"", 330, "USC", "Kingsburg, CA", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Andrew Vorhees.png")},
            {"LT", new Player("Ronnie Stanley", 79, "6'6\"", 315, "Notre Dame", "Las Vegas, NV", "C:\\Users\\landn\\source\\repos\\RavensStartingLineup2024\\RavensStartingLineup2024\\Ronnie Stanley.png")},
        };

        public Form1()
        {
            InitializeComponent();
            PopulatePositions();
            buttonShowInfo.Click += buttonShowInfo_Click;

        }
        private void PopulatePositions()
        {
            // Add positions to ComboBox
            comboBoxPositions.Items.AddRange(new string[] { "QB", "RB", "WR1", "WR2", "WR3", "TE1", "TE2", "RT", "RG", "C", "LG", "LT" });
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            string selectedPosition = comboBoxPositions.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPosition) && players.ContainsKey(selectedPosition))
            {
                Player player = players[selectedPosition];
                ShowPlayerInfo(player);
            }
            else
            {
                MessageBox.Show("No player found for the selected position.");
            }
        }

        private void ShowPlayerInfo(Player player)
        {
            // Display player information on the form
            labelName.Text = "Name: " + player.Name;
            labelNumber.Text = "Number: " + player.Number.ToString();
            labelHeight.Text = "Height: " + player.Height;
            labelWeight.Text = "Weight: " + player.Weight.ToString();
            labelCollege.Text = "College: " + player.College;
            labelHometown.Text = "Hometown: " + player.Hometown;
            pictureBoxPlayers.Image = Image.FromFile(player.ImagePath);
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string College { get; set; }
        public string Hometown { get; set; }
        public string ImagePath { get; set; }

        public Player(string name, int number, string height, int weight, string college, string hometown, string imagePath)
        {
            Name = name;
            Number = number;
            Height = height;
            Weight = weight;
            College = college;
            Hometown = hometown;
            ImagePath = imagePath;
        }
    }
}

