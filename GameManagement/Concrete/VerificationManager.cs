using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool checkIfRealPerson(Gamer gamer)
        {
            if (gamer.nationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
