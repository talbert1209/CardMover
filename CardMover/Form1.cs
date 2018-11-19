using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMover
{
    public partial class Form1 : Form
    {
        private Deck deck1;
        private Deck deck2;
        readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        public void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                var cardsInDeck = random.Next(1, 11);
                var cards = new Card[cardsInDeck];
                for (int card = 0; card < cards.Length; card++)
                {
                    cards[card] = new Card((Suit)random.Next(4), (Value)random.Next(1,14));
                }
                deck1 = new Deck(cards);
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
                deck2.Sort();
            }
        }

        public void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                Deck1.Items.Clear();
                foreach (var card in deck1.GetCardNames())
                {
                    Deck1.Items.Add(card);
                }

                Deck1Label.Text = $@"Deck #1 ({deck1.Count} cards)";
            }
            else
            {
                Deck2.Items.Clear();
                foreach (var card in deck2.GetCardNames())
                {
                    Deck2.Items.Add(card);
                }
                Deck2Label.Text = $@"Deck #2 ({deck2.Count} cards)";
            }
        }

        private void MoveToDeck2_Click(object sender, EventArgs e)
        {
            deck2.Add(deck1.Deal(Deck1.SelectedIndex));
            deck2.Sort();
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void MoveToDeck1_Click(object sender, EventArgs e)
        {
            deck1.Add(deck2.Deal(Deck2.SelectedIndex));
            deck1.Sort();
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void ResetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void ShuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void ShuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}
