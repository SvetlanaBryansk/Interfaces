﻿using System;


namespace Interfaces
{
    class Bow : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Был использован лук");
        }
    }
}
