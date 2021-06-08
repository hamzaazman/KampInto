using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void add(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi: "+ campaing.campaingName);
            Console.WriteLine("Kampanya fiyatı: " + campaing.campaingDiscount);
        }

        public void delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi: " + campaing.campaingName);
            Console.WriteLine("Kampanya fiyatı: " + campaing.campaingDiscount);
        }

        public void update(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi: " + campaing.campaingName);
            Console.WriteLine("Kampanya fiyatı: " + campaing.campaingDiscount);
        }
    }
}
