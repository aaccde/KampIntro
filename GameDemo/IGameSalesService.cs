using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGameSalesService
    {
        public void Sale(Game game, Gamer gamer,Campaign campaign);
    }
    
}
