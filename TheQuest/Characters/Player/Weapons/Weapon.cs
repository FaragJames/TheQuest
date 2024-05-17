using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    abstract class Weapon
    {
        protected Point location;
        protected Game game;
        private bool pickedUp;

        public Point Location { get { return location; } }
        public bool PickedUp { get { return pickedUp; } }
        public abstract string Name { get; }
        

        public Weapon(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        //Uses DamageEnemy().
        public abstract void Attack(Direction direction, Random random);
        public void PickUpWeapon() => pickedUp = true;
        //Used by Attack() to check for an enemy in the specified direction and hit it.
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            foreach (Enemy enemy in game.Enemies)
            {
                //Application.DoEvents();
                if (IsEnemyNearby(direction, enemy.Location, game.PlayerLocation, radius))
                {
                    enemy.TakeHit(damage, random);
                    return true;
                }
            }
            return false;
        }
        
        private bool IsEnemyNearby(Direction direction, Point enemyLocation, Point playerLocation, int radius)
        {
            switch (direction)
            {
                case Direction.Up:
                {
                    if (Math.Abs(playerLocation.X - enemyLocation.X) <= radius && 
                        playerLocation.Y - enemyLocation.Y <= radius &&
                        playerLocation.Y - enemyLocation.Y >= 0)
                        return true;

                    break;
                }

                case Direction.Down:
                {
                    if (Math.Abs(playerLocation.X - enemyLocation.X) <= radius &&
                        enemyLocation.Y - playerLocation.Y <= radius &&
                        enemyLocation.Y - playerLocation.Y >= 0)
                        return true;

                    break;
                }

                case Direction.Left:
                {
                    if (playerLocation.X - enemyLocation.X <= radius &&
                        playerLocation.X - enemyLocation.X >= 0 &&
                        Math.Abs(playerLocation.Y - enemyLocation.Y) <= radius)
                        return true;

                    break;
                }

                case Direction.Right:
                {
                    if (enemyLocation.X - playerLocation.X <= radius &&
                        enemyLocation.X - playerLocation.X >= 0 &&
                        Math.Abs(playerLocation.Y - enemyLocation.Y) <= radius)
                        return true;

                    break;
                }
            }
            return false;
        }
    }
}
