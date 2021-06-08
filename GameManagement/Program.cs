using GameManagement.Concrete;
using GameManagement.Entities;
using System;

namespace GameManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.id = 1;
            gamer.nationalityId = "56784859124";
            gamer.firstName = "Serkan";
            gamer.lastName = "ŞAHİN";

            Gamer gamer2 = new Gamer();
            gamer2.id = 2;
            gamer2.firstName = "Serhat";
            gamer2.lastName = "GENÇER";
            gamer2.nationalityId = "56897845125";

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.add(gamer);
            gamerManager.add(gamer2);

            Console.WriteLine("---------------------------");

            Game game = new Game();
            game.id = 1;
            game.gameCategory = "MMORPG";
            game.gamePrice = 250;
            game.gameName = "Black Desert";

            Game game2 = new Game();
            game2.id = 2;
            game2.gameCategory = "FPS";
            game2.gamePrice = 100;
            game2.gameName = "Cs GO";

            GameManager gameManager = new GameManager();
            gameManager.add(game);
            gameManager.add(game2);

            Console.WriteLine("---------------------------");

            Campaing campaing = new Campaing();
            campaing.campaingName = "Muhteşem Pazar";
            campaing.campaingDiscount = 25;

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.add(campaing);

            Console.WriteLine("---------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.sale(game,gamer,campaing);


        }
    }
}
