using System;

namespace TheQuest
{
    class StrongMagic : IExtraMagic
    {
        public void UseExtraMagic(Game game, Random random)
        {
            foreach (var enemy in game.Enemies)
            {
                enemy.TakeHit(3, random);
            }
        }
    }
}
