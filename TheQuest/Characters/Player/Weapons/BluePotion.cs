using System;
using System.Drawing;

namespace TheQuest
{
    class BluePotion : Weapon, IPotion
    {
        private bool used = false;
        private int heal = 5;

        public int Heal
        {
            get { return heal; }
            private set { heal = value; }
        }
        public bool Used {
            get { return used; }
            private set { used = value; }
        }
        public override string Name { get { return "Blue Potion"; } }


        public BluePotion(Game game, Point location)
            : base(game, location) { }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(Heal, random);
            Used = true;
        }
    }
}
