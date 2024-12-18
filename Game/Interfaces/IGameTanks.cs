﻿using Tanki_ASP.NET.Models;

namespace Tanki_ASP.NET.Game.Interfaces
{
    public interface IGameTanks
    {
        GameField GameField { get; }
        void StartGame();
        void EndGame();
    }
}
