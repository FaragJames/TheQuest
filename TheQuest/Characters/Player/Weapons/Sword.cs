using System;
using System.Drawing;

namespace TheQuest
{
    class Sword : Weapon, IAbility
    {
        public override string Name { get { return "Sword"; } }
        public int Damage { get { return 3; } }
        public int Radius { get { return 100; } }

        public Sword(Game game, Point location)
            : base(game, location)
        { }
        public override void Attack(Direction direction, Random random)
        {
            int d = (int)direction;
            if (!DamageEnemy((Direction)d, Radius, Damage, random))
            {
                if (++d > 3)
                    d = 0;
                if (!DamageEnemy((Direction)d, Radius, Damage, random))
                {
                    d -= 2;
                    if (d < 0)
                        d = 3;
                    DamageEnemy((Direction)d, Radius, Damage, random);
                }
            }
        }
    }
}