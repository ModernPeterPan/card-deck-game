namespace Game;

using Player;
using Deck;
using Card;

public class Game
{
  private List<Player> _players = new();
  private Deck _gameDeck = new();
  private int _turn = 0;

  public void AddPlayer(string name)
  {
    _players.Add(new Player(name));
  }

  // Revérifie ici.
  public void RemovePlayer(string name)
  {
    var player = _players.FirstOrDefault(p => p.Name == name);
    if (player != null)
    {
      _players.Remove(player);
    }
  }

  public void CreateGame()
  {
    _gameDeck.CreateDeck();
    _gameDeck.CreateShuffleGameDeck();
  }

  public void StartGame()
  {
    DealIntialCards();
  }

  private void DealIntialCards()
  {
    foreach (var player in _players)
    {
      DealOneCard(player);
      DealOneCard(player);
    }
  }

  public void DealOneCard(Player player)
  {
    player.Hand.Add(_gameDeck.Draw());
  }

  public List<Card>? GetPlayerHand(string name)
  {
    return _players
        .FirstOrDefault(p => p.Name == name)
        ?.Hand;
  }

}