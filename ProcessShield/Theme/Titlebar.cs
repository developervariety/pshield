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
    class TitleBar : Panel
    {


        public new string Text
        {
            get { return _titleText; }

            set { _titleText = value; Invalidate(); }
        }
        private readonly string buffer = "       ";
        private string _titleText = "Form1";
        private bool mouseDown;
        private Point lastLocation;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public TitleBar()
        {

            //BackColor = Color.FromArgb(0, 121, 216);
            MouseDown += Title_MouseDown;
            MouseUp += Title_MouseUp;
            MouseMove += Title_MouseMove;
            Font = new Font(new FontFamily("Segoe UI"), 9f);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new PointF(0, 0), new PointF(0, 80), Color.White, Color.Black);
            Pen pen = new Pen(lgb);
            e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(buffer + _titleText, this.Font, new SolidBrush(Color.Black), DisplayRectangle, sf);
       
            base.OnPaint(e);
            sf.Dispose();
            e.Graphics.Dispose();

        }


       
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                var f = Parent;
                f.Parent.Location = new Point(
                    (f.Parent.Location.X - lastLocation.X) + e.X, (f.Parent.Location.Y - lastLocation.Y) + e.Y);


            }

        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Parent.Update();
            mouseDown = false;
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            Dock = DockStyle.Top;
            if (Text != null)
            {
                _titleText = Text;
            }
            base.OnHandleCreated(e);
        }
    }
}
