﻿using Microsoft.AspNetCore.Mvc;
using Tanki_ASP.NET.Game.Interfaces;
using Tanki_ASP.NET.Models;

namespace Tanki_ASP.NET.Game
{
    public class GameTanks : IGameTanks
    {

        public GameField GameField { get; private set; }

        public void StartGame()
        {
            GameField = new GameField();
        }

        public void EndGame()
        {
            throw new NotImplementedException();
        }

    }
}
