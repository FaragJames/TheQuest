using System;
using System.Drawing;

namespace TheQuest
{
    class Bow : Weapon, IAbility
    {
        public override string Name { get { return "Bow"; } }
        public int Damage { get { return 1; } }
        public int Radius { get { return 60; } }

        public Bow(Game game, Point location)
            : base(game, location)
        { }
        public override void Attack(Direction direction, Random random)
            => DamageEnemy(direction, Radius, Damage, random);
    }
}
