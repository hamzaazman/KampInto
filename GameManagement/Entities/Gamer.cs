using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entities
{
    public class Gamer
    {
        //TcNo, Ad, Soyad, DoğumYılı
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
