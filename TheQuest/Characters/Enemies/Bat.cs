using System;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        public new bool IsPlayerNearby { get { return base.IsPlayerNearby(); } }
        protected override int Damage { get { return 2; } }
        BatState _state;

        public Bat(Game game, Point location) : 
            base(game, location, 6)
        {
            _state = new AttackState(this);
        }
        public void ChangeState(BatState state) => _state = state;
        public void SetLocation(Point location) => this.location = location;
        public int GetDamage() => this.Damage;
        public Direction FindPlayerDirection() => base.FindPlayerDirection(playerService.PlayerLocation);
        public override void Move(Random random) => _state.Move(random, game);
    }
}
