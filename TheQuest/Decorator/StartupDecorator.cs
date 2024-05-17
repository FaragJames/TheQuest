namespace TheQuest.Decorator
{
    public class StartupDecorator : IStartup
    {
        protected IStartup _startup;

        public StartupDecorator(IStartup startup)
        {
            _startup = startup;
        }
        public virtual void Start()
        {
            _startup.Start();
        }
    }
}
