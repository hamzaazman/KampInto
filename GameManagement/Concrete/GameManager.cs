using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GameManager : IGameService
    {
        public void add(Game game)
        {
            Console.WriteLine("Oyun eklendi: " + game.gameName);
        }

        public void delete(Game game)
        {
            Console.WriteLine("Oyun silindi: " + game.gameName);
        }

        public void update(Game game)
        {
            Console.WriteLine("Oyun güncellend: " + game.gameName);
        }
    }
}
