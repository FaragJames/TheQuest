using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private readonly List<PictureBox> inventory = new List<PictureBox>();
        private readonly Random random = new Random();
        private Game game;
        //To draw a specific image at a specific point.
        private readonly Renderer renderer;
        //Used for displaying either "Attack" or "Drink".
        private bool isPotion = false;
        public Form1()
        {
            InitializeComponent();

            inventory.Add(inventory_bluePotionPictureBox);
            inventory.Add(inventory_redPotionPictureBox);
            inventory.Add(inventory_bowPictureBox);
            inventory.Add(inventory_swordPictureBox);
            inventory.Add(inventory_macePictureBox);

            renderer = Renderer.GetRenderer(this);
        }

        private void UpdateCharacters()
        {
            bool batAlive = false, ghostAlive = false, ghoulAlive = false;

            renderer.Draw(new Point(0, 0), "dungeon");
            renderer.Draw(game.PlayerLocation, "player");
            playerHPLabel.Text = game.PlayerHitPoints.ToString();
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                //Application.DoEvents();
                if (enemy is Bat)
                {
                    if (enemy.HitPoints > 0)
                    {
                        renderer.Draw(enemy.Location, "bat");
                        batHPLabel.Text = enemy.HitPoints.ToString();
                        batAlive = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    if (enemy.HitPoints > 0)
                    {
                        renderer.Draw(enemy.Location, "ghost");
                        ghostHPLabel.Text = enemy.HitPoints.ToString();
                        ghostAlive = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    if (enemy.HitPoints > 0)
                    {
                        renderer.Draw(enemy.Location, "ghoul");
                        ghoulHPLabel.Text = enemy.HitPoints.ToString();
                        ghoulAlive = true;
                        enemiesShown++;
                    }
                }
            }

            if (!batAlive)
                batHPLabel.Text = 0.ToString();
            if (!ghoulAlive)
                ghoulHPLabel.Text = 0.ToString();
            if (!ghostAlive)
                ghostHPLabel.Text = 0.ToString();

            if (game.CheckPlayerInventory("Sword"))
                inventory_swordPictureBox.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                inventory_bowPictureBox.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                inventory_macePictureBox.Visible = true;

            if (game.CheckPlayerInventory("Red Potion"))
                inventory_redPotionPictureBox.Visible = true;
            else
                inventory_redPotionPictureBox.Visible = false;
            if (game.CheckPlayerInventory("Blue Potion"))
                inventory_bluePotionPictureBox.Visible = true;
            else
                inventory_bluePotionPictureBox.Visible = false;

            if (isPotion)
                attackGroupBox.Text = "Drink";
            else
                attackGroupBox.Text = "Attack";

            string weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = "sword";
                    break;
                case "Mace":
                    weaponControl = "mace";
                    break;
                case "Red Potion":
                    weaponControl = "potion_red";
                    break;
                case "Blue Potion":
                    weaponControl = "potion_blue";
                    break;
                case "Bow":
                    weaponControl = "bow";
                    break;
            }
            if (!game.WeaponInRoom.PickedUp)
            {
                renderer.Draw(game.WeaponInRoom.Location, weaponControl);
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died.");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level.");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
        private void CommonThings()
        {
            label1.Focus();
            KeyPreview = true;
            UpdateCharacters();
        }
        //Set a border around an equipped weapon and remove the border from
        //the previously equipped weapon.
        private void SetBorderStyle(PictureBox fixedPicture)
        {
            foreach(PictureBox picture in inventory)
            {
                Application.DoEvents();
                if (picture == fixedPicture)
                    picture.BorderStyle = BorderStyle.FixedSingle;
                else
                    picture.BorderStyle = BorderStyle.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyPressed = e.KeyCode;
            switch (keyPressed)
            {
                case Keys.W:
                    UpButton_Click(sender, e);
                    break;

                case Keys.S:
                    DownButton_Click(sender, e);
                    break;

                case Keys.A:
                    LeftButton_Click(sender, e);
                    break;

                case Keys.D:
                    RightButton_Click(sender, e);
                    break;

                case Keys.Up:
                    UpAttackButton_Click(sender, e);
                    break;

                case Keys.Down:
                    DownAttackButton_Click(sender, e);
                    break;

                case Keys.Right:
                    RightAttackButton_Click(sender, e);
                    break;

                case Keys.Left:
                    LeftAttackButton_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Attention : wrong key.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            CommonThings();
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            CommonThings();
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            CommonThings();
        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            CommonThings();
        }

        private void UpAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            isPotion = false;
            CommonThings();
        }
        private void LeftAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            isPotion = false;
            CommonThings();
        }
        private void RightAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            isPotion = false;
            CommonThings();
        }
        private void DownAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            isPotion = false;
            CommonThings();
        }

        private void Inventory_swordPictureBox_Click(object sender, EventArgs e)
        {
            isPotion = false;
            game.Equip("Sword");
            SetBorderStyle(inventory_swordPictureBox);
            UpdateCharacters();
        }
        private void Inventory_redPotionPictureBox_Click(object sender, EventArgs e)
        {
            isPotion = true;
            game.Equip("Red Potion");
            SetBorderStyle(inventory_redPotionPictureBox);
            UpdateCharacters();
        }
        private void Inventory_bowPictureBox_Click(object sender, EventArgs e)
        {
            isPotion = false;
            game.Equip("Bow");
            SetBorderStyle(inventory_bowPictureBox);
            UpdateCharacters();
        }
        private void Inventory_bluePotionPictureBox_Click(object sender, EventArgs e)
        {
            isPotion = true;
            game.Equip("Blue Potion");
            SetBorderStyle(inventory_bluePotionPictureBox);
            UpdateCharacters();
        }
        private void Inventory_macePictureBox_Click(object sender, EventArgs e)
        {
            isPotion = false;
            game.Equip("Mace");
            SetBorderStyle(inventory_macePictureBox);
            UpdateCharacters();
        }
    }
}
