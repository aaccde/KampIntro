﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    //MikroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
          
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
         
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }
    }
}
