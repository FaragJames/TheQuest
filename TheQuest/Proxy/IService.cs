using System;
using System.Drawing;

namespace TheQuest
{
    interface IPlayerService
    {
        Point PlayerLocation { get; }
        void HitPlayer(int maxDamage, Random random);
    }
}
