using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void sale(Game game, Gamer gamer, Campaing campaing)
        {
            double price = game.gamePrice - (game.gamePrice * (campaing.campaingDiscount / 100));
            Console.WriteLine("İndirim yapılan oyuncu: " + gamer.firstName);
            Console.WriteLine("İndirim yapılan oyun: " + game.gameName);
            Console.WriteLine("İndirim fiyatı: " + campaing.campaingDiscount);
            Console.WriteLine("Oyunun Fiyatı: " + game.gamePrice);
            Console.WriteLine("Oyunun indirimli fiyatı: " + price);
        }
    }
}
