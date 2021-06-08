using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IGamerService
    {
        void add(Gamer gamer);
        void delete(Gamer gamer);
        void update(Gamer gamer);
    }
}
