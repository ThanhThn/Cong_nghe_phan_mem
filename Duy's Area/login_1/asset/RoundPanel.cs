using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_1.asset
{
    public class RoundPanel : Panel
    {
        private int borderRadius = 29;
        public RoundPanel()
        {
            this.DoubleBuffered = true;
            this.Resize += new EventHandler(Button_Resize);
        }

        [Category("Behavior")]
        public int BorderRadius { get { return borderRadius; }
            set {
                if (value <= this.Height)
                {
                    borderRadius = value;
                }
                else borderRadius = this.Height;
                this.Invalidate();
            } }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
            {
                BorderRadius = this.Height;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {

                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(rect.Right - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(rect.Right - BorderRadius, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
                using (Pen pen = new Pen(this.BackColor, 1))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}

