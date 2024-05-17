using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    class Player : Mover, IPlayerService
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        private List<Weapon> inventory = new List<Weapon>();

        public Point PlayerLocation => location;
        public int HitPoints { get { return hitPoints; } }
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location) : 
            base(game, location)
        {
            hitPoints = 10;
        }
        public void HitPlayer(int maxDamage, Random random) => hitPoints -= random.Next(1, maxDamage);
        public void IncreaseHealth(int health, Random random) => hitPoints += random.Next(1, health);
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                //Application.DoEvents();
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        //Move and add nearby weapons using IsNearby() from the Mover class.
        public void Move(Direction direction)
        {
            base.location = base.Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (base.IsNearby(game.WeaponInRoom.Location, 20))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                    if (inventory.Count() == 1)
                        equippedWeapon = game.WeaponInRoom;
                }
            }
        }
        public void Attack(Direction direction, Random random)
        {
            if(equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    equippedWeapon = null;
                }
            }
            else
                MessageBox.Show("Attention : equip a weapon", "Warning", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
        }
    }
}
