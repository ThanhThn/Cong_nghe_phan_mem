using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_1.asset
{
    public class RoundImage:PictureBox
    {

        private int borderRadius = 29;
        public RoundImage()
        {
            this.DoubleBuffered = true;
        }

        [Category("Behavior")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            g.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
            g.AddArc(rect.Right - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
            g.AddArc(rect.Right - BorderRadius, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            g.AddArc(rect.X, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            this.Region = new System.Drawing.Region(g);

            base.OnPaint(e);
        }
    }
}
