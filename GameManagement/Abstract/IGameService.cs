using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IGameService
    {
        void add(Game game);
        void update(Game game);
        void delete(Game game);

    }
}
