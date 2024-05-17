using System;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 15;
        private int hitPoints;
        protected abstract int Damage { get; }
        protected IPlayerService playerService;

        public int HitPoints { get { return hitPoints; } }
        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }


        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location) 
        {
            this.hitPoints = hitPoints;
            playerService = game;
        }

        //Move an enemy and hit the player if nearby using IsPlayerNearby().
        public abstract void Move(Random random);
        public void TakeHit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
            if (Dead)
                game.Enemies.Remove(this);
        }
        protected bool IsPlayerNearby() => IsNearby(playerService.PlayerLocation, NearPlayerDistance);
        //Used by Move() to move enemies towards the player.
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }
}
