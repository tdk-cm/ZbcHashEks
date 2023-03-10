using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.ClientServerKeys.Forms
{
    public class BorderPanel : Panel
    {
        public bool BorderShowing { get; set; }
        public Color BorderColor { get; set; }
        public BorderPanel()
        {
            this.BorderColor = Color.Black;
            this.BorderShowing = false;
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);

            if (BorderShowing)
            {
                using (SolidBrush borderBrush = new SolidBrush(BorderColor))
                    e.Graphics.DrawRectangle(new Pen(borderBrush, 5), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }          
        }

    }
}
