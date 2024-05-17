using System;
using System.Windows.Forms;
using TheQuest.Decorator;

namespace TheQuest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var result = MessageBox.Show("Do you want to play some music?", "Intro", MessageBoxButtons.YesNo);
            IStartup startup = new Startup();
            if (DialogResult.Yes == result)
                startup = new StartupMusicDecorator(startup,
                    @"C:\Users\ASUS\Downloads\Telegram Desktop\5th\Projects\Software Engineering\TheQuest\Resources\Quest Intro.wav");
            startup.Start();
        }
    }
}
