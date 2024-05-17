using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    class Game : IPlayerService
    {
        private Player player;
        private Rectangle boundaries;
        private int level = 0;

        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }
        public int Level { get { return level; } }
        public Rectangle Boundaries { get { return boundaries; } }


        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                //Application.DoEvents();
                enemy.Move(random);
            }
        }
        public void Equip(string weaponName) => player.Equip(weaponName);
        public bool CheckPlayerInventory(string weaponName) => player.Weapons.Contains(weaponName);
        public void HitPlayer(int maxDamage, Random random) => player.HitPlayer(maxDamage, random);
        public void IncreasePlayerHealth(int health, Random random) => player.IncreaseHealth(health, random);
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                //Application.DoEvents();
                enemy.Move(random);
            }
        }
        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>
                    {
                        new Bat(this, GetRandomLocation(random))
                    };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;

                case 2:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;

                case 3:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 4:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (WeaponInRoom.PickedUp)
                    {
                        if (PlayerWeapons.Contains("Blue Potion"))
                            break;
                        else
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    break;

                case 5:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random), new WeakMagic());
                    break;

                case 6:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;

                case 7:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    if (WeaponInRoom.PickedUp)
                    {
                        if (PlayerWeapons.Contains("Red Potion"))
                            break;
                        else
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random), new StrongMagic());
                    }
                    break;

                default:
                    MessageBox.Show("Congratulations, You won the game !!");
                    Environment.Exit(0);
                    break;
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left +
                random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
            boundaries.Top +
                random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }
    }
}
