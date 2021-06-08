using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IVerificationService
    {
        bool checkIfRealPerson(Gamer gamer);
    }
}
