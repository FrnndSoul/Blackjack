namespace Blackjack
{
    public partial class Blackjack : Form
    {
        int Balance = 10000;
        private string[] deckOfCards; // Create an array to represent the deck of cards
        private Random random = new Random();
        public Blackjack()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            BetBox.KeyPress += NumericTextBox_KeyPress;
            BalanceBox.ReadOnly = true;
            BalanceBox.Text = Balance.ToString();
            Hit.Enabled = false;
            Pass.Enabled = false;
            InitializeDeck();
        }
        private void InitializeDeck()
        {
            deckOfCards = new string[]
            {
                "2_of_hearts.png",
                "3_of_hearts.png",
                "4_of_hearts.png",
                "5_of_hearts.png",
                "6_of_hearts.png",
                "7_of_hearts.png",
                "8_of_hearts.png",
                "9_of_hearts.png",
                "10_of_hearts.png",
                "jack_of_hearts.png",
                "queen_of_hearts.png",
                "king_of_hearts.png",
                "ace_of_hearts.png",
                "2_of_diamonds.png",
                "3_of_diamonds.png",
                "4_of_diamonds.png",
                "5_of_diamonds.png",
                "6_of_diamonds.png",
                "7_of_diamonds.png",
                "8_of_diamonds.png",
                "9_of_diamonds.png",
                "10_of_diamonds.png",
                "jack_of_diamonds.png",
                "queen_of_diamonds.png",
                "king_of_diamonds.png",
                "ace_of_diamonds.png",
                "2_of_clubs.png",
                "3_of_clubs.png",
                "4_of_clubs.png",
                "5_of_clubs.png",
                "6_of_clubs.png",
                "7_of_clubs.png",
                "8_of_clubs.png",
                "9_of_clubs.png",
                "10_of_clubs.png",
                "jack_of_clubs.png",
                "queen_of_clubs.png",
                "king_of_clubs.png",
                "ace_of_clubs.png",
                "2_of_spades.png",
                "3_of_spades.png",
                "4_of_spades.png",
                "5_of_spades.png",
                "6_of_spades.png",
                "7_of_spades.png",
                "8_of_spades.png",
                "9_of_spades.png",
                "10_of_spades.png",
                "jack_of_spades.png",
                "queen_of_spades.png",
                "king_of_spades.png",
                "ace_of_spades.png",
                "black_joker.png"
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != 13 && e.KeyChar != 3)
            {
                e.Handled = true;
            }
        }
        private void Deal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BetBox.Text))
            {
                MessageBox.Show($"Enter a bet to start the game");
                return;
            }

            if (int.TryParse(BetBox.Text, out int bet))
            {
                if (bet <= Balance)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to bet {bet}?", "BET CONFIRMATION", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Deal.Enabled = false;
                        Hit.Enabled = true;
                        Pass.Enabled = true;
                        BetBox.ReadOnly = true;
                        int NewBalance = Balance - bet;
                        BalanceBox.Text = NewBalance.ToString();

                        PlayerDrawTwoCards();

                    }
                }
                else
                {
                    MessageBox.Show("Bet exceeds your balance. Please enter a lower bet.");
                    BetBox.Text = "";
                }
            }
        }
        private void PlayerDrawTwoCards()
        {
            if (deckOfCards.Length > 1)
            {
                int randomIndex_1 = random.Next(deckOfCards.Length);
                int randomIndex_2 = random.Next(deckOfCards.Length);

                string chosenCard_1 = deckOfCards[randomIndex_1];
                string chosenCard_2 = deckOfCards[randomIndex_2];

                deckOfCards = RemoveCardFromDeck(deckOfCards, randomIndex_1);
                deckOfCards = RemoveCardFromDeck(deckOfCards, randomIndex_2);

                string imagePath_1 = @"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\" + chosenCard_1;
                string imagePath_2 = @"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\" + chosenCard_2;

                if (System.IO.File.Exists(imagePath_1) && System.IO.File.Exists(imagePath_2))
                {
                    Image cardImage_1 = Image.FromFile(imagePath_1);
                    Image cardImage_2 = Image.FromFile(imagePath_2);
                    PlayerHand_1.Image = cardImage_1;
                    PlayerHand_2.Image = cardImage_2;
                }
                else
                {
                    MessageBox.Show("No card found");
                }
            }
            else
            {
                MessageBox.Show("The deck is empty. Cannot draw more cards.");
            }
        }
        
        private void DealerDrawTwoCards()
        {
            if (deckOfCards.Length > 1) // Ensure there are at least two cards left in the deck
            {
                int randomIndex_1 = random.Next(deckOfCards.Length);
                int randomIndex_2;

                do
                {
                    randomIndex_2 = random.Next(deckOfCards.Length);
                }
                while (randomIndex_2 == randomIndex_1); // Ensure that the second card is different from the first

                string chosenCard_1 = deckOfCards[randomIndex_1];
                string chosenCard_2 = deckOfCards[randomIndex_2];

                deckOfCards = RemoveCardFromDeck(deckOfCards, randomIndex_1);
                deckOfCards = RemoveCardFromDeck(deckOfCards, randomIndex_2);

                string imagePath_1 = @"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\" + chosenCard_1;
                string imagePath_2 = @"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\" + chosenCard_2;

                if (System.IO.File.Exists(imagePath_1) && System.IO.File.Exists(imagePath_2))
                {
                    Image cardImage_1 = Image.FromFile(imagePath_1);
                    Image cardImage_2 = Image.FromFile(imagePath_2);

                    // Set the dealer's first card (face down) as "black_joker.png"
                    DealerHand_1.Image = Image.FromFile(@"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\black_joker.png");
                    DealerHand_2.Image = cardImage_2; // The second card is face up
                }
                else
                {
                    MessageBox.Show("No card found");
                }
            }
            else
            {
                MessageBox.Show("The deck is empty. Cannot draw more cards.");
            }
        }
        // Modify the RemoveCardFromDeck method to return the updated deck
        private string[] RemoveCardFromDeck(string[] deck, int indexToRemove)
        {
            // Create a new array without the chosen card
            string[] newDeck = new string[deck.Length - 1];
            int newIndex = 0;

            for (int i = 0; i < deck.Length; i++)
            {
                if (i != indexToRemove)
                {
                    newDeck[newIndex] = deck[i];
                    newIndex++;
                }
            }
            return newDeck; // Return the updated deck
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Hit_Click(object sender, EventArgs e)
        {
            // Check if there are still cards in the deck
            if (deckOfCards.Length > 0)
            {
                int randomIndex = random.Next(deckOfCards.Length);
                string chosenCard = deckOfCards[randomIndex];

                deckOfCards = RemoveCardFromDeck(deckOfCards, randomIndex);

                string imagePath = @"C:\Users\saulf\source\repos\Blackjack\Blackjack\Resources\" + chosenCard;

                if (System.IO.File.Exists(imagePath))
                {
                    Image cardImage = Image.FromFile(imagePath);

                    if (PlayerHand_2.Image == null)
                    {
                        PlayerHand_2.Image = cardImage;
                    }
                    else if (PlayerHand_3.Image == null)
                    {
                        PlayerHand_3.Image = cardImage;
                    }
                }
                else
                {
                    MessageBox.Show("No card found");
                }
            }
            else
            {
                MessageBox.Show("The deck is empty. Cannot draw more cards.");
            }
        }

        private void Pass_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand_1_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand_2_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand_3_Click(object sender, EventArgs e)
        {

        }
    }
}