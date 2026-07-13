namespace Deck;

using System.Collections.Generic;
using Card;

public class Deck
{
  private List<Card> _cards = new();
  private List<Card> _gameDeck = new();
  public const int maxDeckCards = 52;
  public static readonly string[] Colours =
  {
    "Hearts",
    "Spades",
    "Clubs",
    "Diamonds"
  };
  public static readonly string[] Values =
  {
    "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
  };


  public int CardNumber { get; }

  public Deck()
  {
    
  }

  public void CreateDeck()
  {
    foreach (var colour in Colours)
    {
      foreach (var value in Values)
      {
        _cards.Add(new Card(colour, value));
      }
    }
    _gameDeck = new List<Card>(_cards);
  }

// À étudier, j'ai mal compris.
  public void CreateShuffleGameDeck()
  {
    var rng = new Random();

    for (int i = _gameDeck.Count - 1; i > 0; i--)
    {
      int j = rng.Next(0, i + 1);

      var temp = _gameDeck[i];
      _gameDeck[i] = _gameDeck[j];
      _gameDeck[j] = temp;
    }
  }

  public Card Draw()
  {
    var cardTaken = _gameDeck[0];
    _gameDeck.RemoveAt(0);
    return cardTaken;
  }
}