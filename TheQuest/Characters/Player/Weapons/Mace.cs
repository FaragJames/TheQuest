using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    class Mace : Weapon, IAbility
    {
        public override string Name { get { return "Mace"; } }
        public int Damage { get { return 6; } }
        public int Radius { get { return 40; } }

        public Mace(Game game, Point location)
            : base(game, location)
        { }
        public override void Attack(Direction direction, Random random)
        {
            int d1 = (int)direction;
            for (int i = 0; i < 4; i++)
            {
                Application.DoEvents();
                if (DamageEnemy((Direction)d1++, Radius, Damage, random))
                    break;
                if (d1 > 3)
                    d1 = 0;
            }
        }
    }
}
