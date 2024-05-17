using System;
using System.Drawing;

namespace TheQuest
{
    class Ghoul : Enemy
    {
        protected override int Damage { get { return 4; } }

        public Ghoul(Game game, Point location) :
            base(game, location, 10)
        { }
        public override void Move(Random random)
        {
            if (!Dead)
            {
                int towardOrNot = random.Next(3);
                if (towardOrNot == 0)
                {
                    if (IsPlayerNearby())
                        playerService.HitPlayer(Damage, random);
                }
                else
                {
                    Direction whichDirection = base.FindPlayerDirection(playerService.PlayerLocation);
                    location = base.Move(whichDirection, game.Boundaries);
                    if (IsPlayerNearby())
                        playerService.HitPlayer(Damage, random);
                }
            }
        }
    }
}