using System;
using System.Drawing;

namespace TheQuest
{
    class RedPotion : Weapon, IPotion
    {
        private bool used = false;
        private int heal = 10;
        private readonly IExtraMagic magic;

        public int Heal
        {
            get { return heal; }
            private set { heal = value; }
        }
        public bool Used
        {
            get { return used; }
            private set { used = value; }
        }
        public override string Name { get { return "Red Potion"; } }

        public RedPotion(Game game, Point location, IExtraMagic magic = null)
            : base(game, location)
        {
            this.magic = magic;
        }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(Heal, random);
            magic?.UseExtraMagic(game, random);
            Used = true;
        }
    }
}
