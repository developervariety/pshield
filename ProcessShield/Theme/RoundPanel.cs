using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessShield.Theme
{
    class RoundPanel: Panel
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 2);
            this.Region = new Region(GraphPath);

        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius * 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);

            GraphPath.AddArc(Rect.X + Rect.Width - 8,
                             Rect.Y + Rect.Height - 8, 8, 8, 0, 90);

            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 3, 3, 3, 90, 90);

            GraphPath.CloseFigure();
            return GraphPath;

        }
    }
}
