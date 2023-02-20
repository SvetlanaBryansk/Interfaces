using System;

namespace Interfaces
{
    class Archer : Unit
    {
        public Archer(IWeapon weapon) : base(weapon)
        {
            _hp = 50;
            _damage = 15;
        }
        public override void Attack(IDamageable damageable)
        {
            Console.WriteLine("Персонаж лучник выполняет атаку");
            base.Attack(damageable);
        }

        protected override void Die()
        {
            Console.WriteLine("Персонаж лучник убит");
        }
    }
}
