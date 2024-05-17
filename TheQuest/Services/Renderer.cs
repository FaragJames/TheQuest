using System.Collections.Generic;
using System.Drawing;
using System;

namespace TheQuest
{
    class Renderer
    {
        Dictionary<string, Bitmap> pictures = new Dictionary<string, Bitmap>();
        static Renderer renderer;
        readonly Form1 form1;
        private Renderer(Form1 form1) => this.form1 = form1;

        public static Renderer GetRenderer(Form1 form1 = null)
        {
            if (renderer == null)
            {
                if(form1 == null)
                    throw new NullReferenceException("Form1 must not be null when instantiating Renderer for the first time.");
                renderer = new Renderer(form1);
                renderer.initializePictures();
            }
            return renderer;
        }
        public void Draw(Point location, string imageName)
        {
            using(Graphics g = form1.CreateGraphics())
                g.DrawImage(pictures[imageName], location);
        }

        private void initializePictures()
        {
            pictures["bat"] = resizeImage(Properties.Resources.bat, 30, 30);
            pictures["bow"] = resizeImage(Properties.Resources.bow, 30, 30);
            pictures["dungeon"] = Properties.Resources.dungeon600x400;
            pictures["ghost"] = resizeImage(Properties.Resources.ghost, 30, 30);
            pictures["ghoul"] = resizeImage(Properties.Resources.ghoul, 30, 30);
            pictures["mace"] = resizeImage(Properties.Resources.mace, 30, 30);
            pictures["player"] = resizeImage(Properties.Resources.player, 30, 30);
            pictures["potion_blue"] = resizeImage(Properties.Resources.potion_blue, 30, 30);
            pictures["potion_red"] = resizeImage(Properties.Resources.potion_red, 30, 30);
            pictures["sword"] = resizeImage(Properties.Resources.sword, 30, 30);
        }
        private Bitmap resizeImage(Image ImageToResize, int Width, int Height)
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(ImageToResize, 0, 0, Width, Height);
            }
            return bitmap;
        }
    }
}
