using System;

namespace TheQuest
{
    class WeakMagic : IExtraMagic
    {
        public void UseExtraMagic(Game game, Random random)
        {
            game.Enemies[random.Next(game.Enemies.Count)].TakeHit(3, random);
        }
    }
}
