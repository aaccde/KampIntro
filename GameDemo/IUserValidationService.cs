using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IUserValidationService
    { 
        bool Validate(Gamer gamer);
    }
}
