using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Archer archer = new Archer(new Bow());
            Wall wall = new Wall();

            archer.Attack(wall);


        }
    }
}
