using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone
{
    public partial class CustomBorderRoundPanel : Panel
    {
        private int _cornerRadius = 40;

        public CustomBorderRoundPanel()
        {
            InitializeComponent();
            RoundBorderForm(this);
            this.Paint += dropShadow;
        }

        // 그림자효과(자기 자신이아닌 자손 콘트롤에 적용된다)
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X - 1, pt.Y - p.Height - 1, pt.X + p.Width - 1, pt.Y - p.Height - 1);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, p.Left - sp + 1, p.Top + sp, p.Left - sp + 1, p.Bottom + sp);

                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);
                        pt.Y++;
                    }
                }
            }
        }

        // border radius
        public void RoundBorderForm(Panel panel)
        {
            Rectangle Bounds = new Rectangle(0, 0, panel.Width, panel.Height);

            float r2 = _cornerRadius / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(Bounds.X, Bounds.Y, _cornerRadius, _cornerRadius, 180, 90);
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);
            graphicsPath.AddArc(Bounds.X + Bounds.Width - _cornerRadius, Bounds.Y, _cornerRadius, _cornerRadius, 270, 90);
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + r2, Bounds.Width, Bounds.Height - r2);
            graphicsPath.AddArc(Bounds.X + Bounds.Width,
                             Bounds.Y + Bounds.Height , 1, 1, 0, 90);
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);
            //graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height, 1, 1, 90, 90);
            graphicsPath.AddLine(Bounds.X, Bounds.Height - r2, Bounds.X, Bounds.Y + r2);
            graphicsPath.CloseFigure();

            panel.Region = new Region(graphicsPath);
            panel.Show();
        }

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; }
        }

        private void CustomRoundButton_Resize(object sender, EventArgs e)
        {
            RoundBorderForm(this);
        }
    }
}
