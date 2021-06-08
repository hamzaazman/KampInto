using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IGameSaleService
    {
        void sale(Game game, Gamer gamer, Campaing campaing);
    }
}
