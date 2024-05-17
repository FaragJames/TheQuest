using System.Windows.Forms;

namespace TheQuest.Decorator
{
    public class Startup : IStartup
    {
        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
