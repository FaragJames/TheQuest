using System;

namespace TheQuest
{
    class AttackState : BatState
    {
        public AttackState(Bat bat) => _bat = bat;
        public override void Move(Random random, Game game)
        {
            if(_bat.HitPoints <= 2)
            {
                _bat.ChangeState(new DefenseState(_bat));
                _bat.Move(random);
            }
            else if (!_bat.Dead)
            {
                int notTowards = random.Next(4);
                Direction playerDirection = _bat.FindPlayerDirection();
                if (notTowards == 0)
                {
                    Direction away;
                    if ((int)playerDirection - 2 > -1)
                        away = playerDirection - 2;
                    else
                        away = (Direction)(4 + ((int)playerDirection - 2));

                    _bat.SetLocation(_bat.Move(away, game.Boundaries));
                    if (_bat.IsPlayerNearby)
                        game.HitPlayer(_bat.GetDamage(), random);
                }
                else
                {
                    _bat.SetLocation(_bat.Move(playerDirection, game.Boundaries));
                    if (_bat.IsPlayerNearby)
                        game.HitPlayer(_bat.GetDamage(), random);
                }
            }
        }
    }
}
