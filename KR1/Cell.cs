using System;
using System.Drawing;
using System.Windows.Forms;

namespace KR1
{
    public class Cell : PictureBox
    {   
        private readonly Image modImage;
        public Cell(int x, int y, int size, Image texture, Image mod, Action<object, EventArgs> clicked)
        {
            Size = new Size(size, size);
            Location = new Point(x, y);
            Padding = new Padding(2, 2, 2, 2);
            BackColor = Color.Black;
            SizeMode = PictureBoxSizeMode.StretchImage;
            modImage = mod;
            Image = texture;
            MouseClick += new MouseEventHandler(clicked);
            Rewrite(Image, modImage);
        }

        public void Rewrite(Image img, Image mod)
        {
            if (mod == null)
            {
                Image = img;
                return;
            }
            Bitmap bitmap = new Bitmap(img);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.DrawImage(mod, 0, 0, img.Width, img.Height);
            Image = bitmap;
        }
    }
}