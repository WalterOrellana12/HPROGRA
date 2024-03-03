using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using clase4.Models;

namespace clase4.Controllers;

public class VideoGameController : Controller
{
    private readonly ILogger<VideoGameController> _logger;
    public VideoGameController(ILogger<VideoGameController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
       var gamelist = new List<Game>();
        var game1 = new Game();

            game1.Name = "FC 24";
            game1.IsMultiplayer = true;

            gamelist.Add(game1);

            var game2 = new Game();
            game2.Name = "MK 11";
            
            game2.IsMultiplayer = true;

            gamelist.Add(game2);

            var game3 = new Game();
            game3.Name = "Minecraft";
            
            game3.IsMultiplayer = true;

            gamelist.Add(game3);
            return view(gamelist);
    }

    public IActionResult NewGame()
    {
        return view();
    }

}
