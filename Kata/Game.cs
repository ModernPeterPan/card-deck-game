namespace Game;

using Player;
using Deck;

private List<Player> _players = new();
private Deck _gameDeck = new();
private int _turn = 0;

public class Game
{

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
    var p1 = new Player("Marcos");
    var p2 = new Player("Tania");
    var p3 = new Player("Sandra");

    _gameDeck.CreateDeck();
    _gameDeck.CreateShuffleGameDeck();
    DealIntialCards();
  }

  private void DealIntialCards()
  {
    foreach (var player in _players)
    {
      player.Hand.Add(DealOneCard());
      player.Hand.Add(DealOneCard());
    }
  }

  public void DealOneCard()
  {
    player.Hand.Add(_gameDeck.Draw());
  }

  public List<Card> GetPlayerHand(string name)
{
    return _players
        .FirstOrDefault(p => p.Name == name)
        ?.Hand;
}

}