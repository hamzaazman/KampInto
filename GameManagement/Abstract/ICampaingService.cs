using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface ICampaingService
    {
        void add(Campaing campaing);
        void update(Campaing campaing);
        void delete(Campaing campaing);

    }
}
