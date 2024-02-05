namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event handler for button clicks (Rock, Paper, Scissors)
        private void button1_Click(object sender, EventArgs e)
        {
            // Array to store the available choices: Rock, Paper, Scissors
            Random rnd = new Random();
            string[] inputs = { "Rock", "Paper", "Scissor" };
            int gameInput = rnd.Next(0, 3);

            // Generate a random choice for the computer
            if (gameInput == 1)
            {
                label3.Text = "You selected: Rock";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYou lost :( Try again.");
                // Display the result of the game
                label3.Text = "";
            }
            else if (gameInput == 2)
            {
                label3.Text = "You selected: Rock";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYaay you won :).");
                label3.Text = "";
            }
            else if (gameInput == 0)
            {
                label3.Text = "You selected: Rock";
                MessageBox.Show("Game chooe: " + inputs[gameInput] + ".\nDraw.");
                label3.Text = "";
            }
        }
        // Event handler for button clicks (Rock, Paper, Scissors)
        private void button3_Click(object sender, EventArgs e)
        {
            // Array to store the available choices: Rock, Paper, Scissors
            Random rnd = new Random();
            string[] inputs = { "Rock", "Paper", "Scissor" };
            int gameInput = rnd.Next(0, 3);

            if (gameInput == 0)
            {
                label3.Text = "You selected: Paper";
                // Determine the winner based on the user's and computer's choices
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYaay You won.");
                label3.Text = "";
            }
            else if (gameInput == 2)
            {
                label3.Text = "You selected: Paper";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYou lost :( Try again.");
                label3.Text = "";
            }
            else if (gameInput == 1)
            {
                label3.Text = "You selected: Paper";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nTie.");
                label3.Text = "";
            }
        }
        // Event handler for button clicks (Rock, Paper, Scissors)
        private void button2_Click(object sender, EventArgs e)
        {
            // Array to store the available choices: Rock, Paper, Scissors
            Random rnd = new Random();
            string[] inputs = { "Rock", "Paper", "Scissor" };
            int gameInput = rnd.Next(0, 3);

            // Get the user's choice from the clicked button
            if (gameInput == 0)
            {
                label3.Text = "You selected: Scissor";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYou lost :( try again.");
                label3.Text = "";
            }
            else if (gameInput == 1)
            {
                label3.Text = "You selected: Scissor";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nYaaY You won :).");
                label3.Text = "";
            }
            else if (gameInput == 2)
            {
                label3.Text = "You selected: Scissor";
                MessageBox.Show("Game chose: " + inputs[gameInput] + ".\nTie.");
                label3.Text = "";
            }
        }
    }
}