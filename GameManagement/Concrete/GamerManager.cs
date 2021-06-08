using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GamerManager : IGamerService
    {
        private IVerificationService verificationService;

        public GamerManager()
        {
        }

        public GamerManager (IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public void add(Gamer gamer)
        {
            if (verificationService.checkIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi: " + gamer.firstName + " "+ gamer.lastName);
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz.");
            }

        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.firstName + " " + gamer.lastName);
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncelle: " + gamer.firstName + " " + gamer.lastName);
        }
    }
}
