using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Demo1.HeartsGame;

namespace Demo1
{
    public partial class HeartsGame : Form
    {
        private Game game;
        private Button btnStartGame;
        private TextBox txtGameStatus;
        private Label lblScoreboard;
        private Label lblPlayerNorth;
        private Label lblPlayerEast;
        private Label lblPlayerSouth;
        private Label lblPlayerWest;

        private List<Card> deck = new List<Card>();
        private static readonly string basePath = "C:\\Users\\kavan\\source\\repos\\Demo1\\Resources\\CardImages\\";

        public MainForm()
        {
            InitializeComponent();
            InitializeDeck();
            ShuffleDeck();
            DisplayCards();
        }

        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    deck.Add(new Card(suit, rank));
                }
            }
        }

        private void ShuffleDeck()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
       


        public HeartsGame()
        {
            InitializeComponent();
            InitializeGameUI();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Code that needs to run when the form loads
        }

        private void InitializeGameUI()
        {
            btnStartGame = new Button
            {
                Text = "Start Game",
                Location = new Point(10, 10),
                Size = new Size(100, 30)
            };
            btnStartGame.Click += BtnStartGame_Click;
            Controls.Add(btnStartGame);

            txtGameStatus = new TextBox
            {
                Multiline = true,
                Location = new Point(10, 310),
                Size = new Size(760, 60),
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };
            Controls.Add(txtGameStatus);

            lblScoreboard = new Label
            {
                Text = "Scoreboard",
                Location = new Point(10, 50),
                Size = new Size(200, 20)
            };
            Controls.Add(lblScoreboard);

            lblPlayerNorth = new Label
            {
                Text = "Player 1 (North)",
                Location = new Point(300, 20),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lblPlayerNorth);

            lblPlayerEast = new Label
            {
                Text = "Player 2 (East)",
                Location = new Point(520, 150),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lblPlayerEast);

            lblPlayerSouth = new Label
            {
                Text = "Player 3 (South)",
                Location = new Point(300, 280),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lblPlayerSouth);

            lblPlayerWest = new Label
            {
                Text = "Player 4 (West)",
                Location = new Point(80, 150),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lblPlayerWest);

            Text = "Hearts Card Game";
            Size = new Size(800, 400);
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.Play();
            DisplayResults();
        }

        private void DisplayResults()
        {
            txtGameStatus.Clear();
            txtGameStatus.AppendText("Game over!\n");
            foreach (var player in game.Players)
            {
                txtGameStatus.AppendText($"Player score: {player.CalculateScore()}\n");
            }
        }
    }

    // All other classes come after Form2 class
    public enum Suit { Clubs, Diamonds, Hearts, Spades }
    public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

    public class Card
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public class Player
    {
        private List<Card> hand;
        public List<Card> PointsPile { get; private set; }

        public Player()
        {
            hand = new List<Card>();
            PointsPile = new List<Card>();
        }

        public void ReceiveCard(Card card)
        {
            hand.Add(card);
        }

        public void SetHand(List<Card> newHand)
        {
            hand = newHand;
        }

        public Card PlayCard(Suit? leadSuit)
        {
            Card cardToPlay = hand.FirstOrDefault(c => c.Suit == leadSuit);
            if (cardToPlay == null)
            {
                cardToPlay = hand.First();
            }
            hand.Remove(cardToPlay);
            return cardToPlay;
        }

        public void CollectTrick(IEnumerable<Card> trickCards)
        {
            PointsPile.AddRange(trickCards);
        }

        public int CalculateScore()
        {
            return PointsPile.Count(c => c.Suit == Suit.Hearts) +
                   (PointsPile.Any(c => c.Suit == Suit.Spades && c.Rank == Rank.Queen) ? 13 : 0);
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random rng = new Random();

        public Deck()
        {
            cards = Enumerable.Range(0, 4).SelectMany(s => Enumerable.Range(2, 13)
                .Select(r => new Card((Suit)s, (Rank)r))).ToList();
            Shuffle();
        }

        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public IEnumerable<Card> Deal(int count)
        {
            List<Card> dealtCards = cards.Take(count).ToList();
            cards = cards.Skip(count).ToList();
            return dealtCards;
        }
    }

    public class Game
    {
        public List<Player> Players { get; private set; }
        public Deck Deck { get; private set; }

        public Game()
        {
            Deck = new Deck();
            Players = new List<Player> { new Player(), new Player(), new Player(), new Player() };
            DealCards();
        }

        private void DealCards()
        {
            var allCards = Deck.Deal(52).ToList();
            int cardsPerPlayer = allCards.Count / Players.Count;
            for (int i = 0; i < Players.Count; i++)
            {
                Players[i].SetHand(allCards.Skip(i * cardsPerPlayer).Take(cardsPerPlayer).ToList());
            }
        }

        public void Play()
        {
            int currentPlayerIndex = 0;

            for (int i = 0; i < 13; i++)
            {
                var trick = new List<Card>();
                Suit? leadSuit = null;

                for (int playerTurn = 0; playerTurn < Players.Count; playerTurn++)
                {
                    int index = (currentPlayerIndex + playerTurn) % Players.Count;
                    Card playedCard = Players[index].PlayCard(leadSuit);
                    trick.Add(playedCard);
                    if (playerTurn == 0)
                    {
                        leadSuit = playedCard.Suit;
                    }
                }

                var highestCard = trick.Where(c => c.Suit == leadSuit).OrderByDescending(c => c.Rank).First();
                int winnerIndex = (currentPlayerIndex + trick.IndexOf(highestCard)) % Players.Count;
                Players[winnerIndex].CollectTrick(trick);
                currentPlayerIndex = winnerIndex;
            }
        }
    }
}
