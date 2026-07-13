using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController : ControllerBase
{
    private static Game _game = new Game();

    [HttpPost("create")]
    public IActionResult CreateGame()
    {
        _game = new Game();
        _game.CreateGame();
        return Ok("Game created");
    }

    [HttpDelete("delete")]
    public IActionResult DeleteGame()
    {
        _game = null;
        return Ok("Game deleted");
    }

    [HttpPost("player/add")]
    public IActionResult AddPlayer(string name)
    {
        _game.AddPlayer(name);
        return Ok($"Player {name} added");
    }

    [HttpDelete("player/remove")]
    public IActionResult RemovePlayer(string name)
    {
        _game.RemovePlayer(name);
        return Ok($"Player {name} removed");
    }

    [HttpPost("start")]
    public IActionResult StartGame()
    {
        _game.StartGame();
        return Ok("Game started");
    }

    [HttpGet("player/hand")]
    public IActionResult GetHand(string name)
    {
        var hand = _game.GetPlayerHand(name);
        return Ok(hand);
    }
}