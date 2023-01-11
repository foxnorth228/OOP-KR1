using System;
using System.Drawing;
using System.Windows.Forms;

namespace KR1
{
    public class CellSample : PictureBox
    {
        public bool isModificator;
        public Modificator mod;
        public Modificator[] allowedMods;
        public CellSample(int x, int y, int size, Image texture, Action<object, EventArgs> method, Action<object, EventArgs> method2, 
            Action<object, EventArgs> mouseClickEvent, bool isMod = false, Modificator mod = null, Modificator[] all = null)
        {
            Size = new Size(size, size);
            Location = new Point(x, y);
            Padding = new Padding(2, 2, 2, 2);
            BackColor = Color.Black;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = texture;
            MouseEnter += new EventHandler(method);
            MouseLeave += new EventHandler(method2);
            MouseClick += new MouseEventHandler(mouseClickEvent);
            isModificator = isMod;
            allowedMods = all;
            this.mod = mod;
        }
    }

    public class CellSampleGenerator
    {
        private readonly int cellSize;
        private readonly Action<object, EventArgs> mouseEnterEvent;
        private readonly Action<object, EventArgs> mouseLeaveEvent;
        private readonly Action<object, EventArgs> mouseClickEvent;
        public CellSampleGenerator(int size, Action<object, EventArgs> mouseEnter, Action<object, EventArgs> mouseLeave, Action<object, EventArgs> mouseClick)
        {
            mouseEnterEvent = mouseEnter;
            mouseLeaveEvent = mouseLeave;
            mouseClickEvent = mouseClick;
            cellSize = size;
        }

        public CellSample GetCellSample(int x, int y, Image image, bool isMod, Modificator mod = null, Modificator[] all = null)
        {
            return new CellSample(x, y, cellSize, image, mouseEnterEvent, mouseLeaveEvent, mouseClickEvent, isMod, mod, all);
        }
    }
}
