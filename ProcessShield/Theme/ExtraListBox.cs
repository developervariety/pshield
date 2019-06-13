using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessShield.Theme
{

    public enum OpacityScale
    {
        Max = 255,
        Half = 128,
        Quarter = 64,
        Minimal = 32
    }
    //F:\Users\ironb\Desktop\Back up from microsd\Projects\CustomControlForm\CustomControlForm
    class ExtraListBox :ListBox
    {
        [Description("Draw border around each item"), Category("Border Properties")]
        public bool DrawBorder { get; set; }
        [Description("Size of the border in pixels"), Category("Border Properties")]
        public int BorderSize { get; set;}
        [Description("Color of the border"), Category("Border Properties")]
        public Color BorderColor { get; set; }
        [Description("Opacity of the border"), Category("Border Properties")]
        public OpacityScale BorderOpacity { get; set; }


        [Description("Color of the title"), Category("Title Properties")]
        public Color TitleColor { get; set; }
        [Description("font of the title"), Category("Title Properties")]
        public Font TitleFont { get; set; }
        [Description("Center title"), Category("Title Properties")]
        public bool CenterTitle { get; set; }

     

        public ExtraListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DoubleBuffered = true;
            this.MeasureItem += ExtList_MeasureItem;
            this.DrawItem += ExtList_DrawItem;
            this.ScrollAlwaysVisible = true;
            BorderOpacity = OpacityScale.Max;
                       
        }
   
        public void AddItemTitle(string Title, object item)
        {
            string compiled = $"{Title}☂ {Environment.NewLine} {Environment.NewLine}{item}";
            this.Items.Add(compiled);
        }


        private void ExtList_DrawItem(object sender, DrawItemEventArgs e)
        {

            //e.DrawBackground();
            string buffer = String.Empty;
            if (this.Items.Count > 0)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e = new DrawItemEventArgs(e.Graphics,
                                              e.Font,
                                              e.Bounds,
                                              e.Index,
                                              e.State ^ DrawItemState.Selected,
                                              e.ForeColor,
                                              Color.LightSlateGray);
                e.DrawBackground();
                if (DrawBorder && this.Items[e.Index].ToString() != Environment.NewLine)
                {
                    Pen pen = new Pen(Color.FromArgb((int)BorderOpacity, BorderColor), BorderSize);                  
                    pen.Alignment = PenAlignment.Center;
                    e.Graphics.DrawRectangle(pen, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height);
                    e.DrawFocusRectangle();
                    pen.Dispose();
                }

                if (this.Items[e.Index].ToString().Contains("☂"))
                {
                    int titleLoc = e.Bounds.X;

                    if (CenterTitle)
                    {
                        titleLoc = e.Bounds.X + (this.Width / 2);
                    }
                    string[] indexSplit = this.Items[e.Index].ToString().Split('☂');

                    if (this.Items[e.Index].ToString().Contains("☂"))
                    {
                        buffer = this.Items[e.Index].ToString().Replace(indexSplit[0] + "☂", "");
                    }


                    e.Graphics.DrawString(indexSplit[0], TitleFont, new SolidBrush(TitleColor), titleLoc, (e.Bounds.Y) + 2);
                }
                else
                {
                    buffer = this.Items[e.Index].ToString();
                }
                
                e.Graphics.DrawString(buffer, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

                Console.WriteLine(buffer);
            }
        }


 

        private void ExtList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if(this.Items.Count > 0)
              e.ItemHeight = (int)e.Graphics.MeasureString(this.Items[e.Index].ToString(), this.Font, this.Width - 15).Height;
        }
    }
}
