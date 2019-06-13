using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessShield.Theme
{
    class ThemeContainer : ContainerControl
    {
        //fix refresh rate every second
        public ThemeContainer()
        {
            BackColor = Color.FromArgb(220, 220, 220);
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            Dock = DockStyle.Fill;
            if (Parent is Form)
            {
                Form parentForm = Parent as Form;

                parentForm.FormBorderStyle = FormBorderStyle.None;

                base.OnHandleCreated(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics gfx = e.Graphics;
            var brush = new SolidBrush(Color.FromArgb(255, 128,128,128)); // 3,169,245
            Pen penColor = new Pen(brush, 1);
            gfx.DrawRectangle(penColor, DisplayRectangle.Left, DisplayRectangle.Top, DisplayRectangle.Width - 1, DisplayRectangle.Height - 1);
            penColor.Dispose();
            brush.Dispose();
        }
    }
}
