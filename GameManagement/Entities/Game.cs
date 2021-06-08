using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities
{
    public class Game
    {
        public int id { get; set; }
        public string gameName { get; set; }
        public string gameCategory { get; set; }
        public int gamePrice { get; set; }

    }
}
