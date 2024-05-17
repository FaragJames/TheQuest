using System;

namespace TheQuest
{
    abstract class BatState
    {
        protected Bat _bat;
        public abstract void Move(Random random, Game game);
    }
}
