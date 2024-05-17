namespace TheQuest.Decorator
{
    public class StartupMusicDecorator : StartupDecorator
    {
        private readonly string musicPath;


        public StartupMusicDecorator(IStartup startup, string musicPath) : base(startup)
        {
            this.musicPath = musicPath;
        }
        public override void Start()
        {
            playMusic();
            base.Start();
        }

        private void playMusic()
        {
            using (var player = new System.Media.SoundPlayer(musicPath))
                player.PlayLooping();
        }
    }
}