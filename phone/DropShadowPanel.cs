using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone
{
    public partial class DropShadowPanel : Panel
    {
        public DropShadowPanel()
        {
            InitializeComponent();
            this.Paint += dropShadow;
        }
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
                        e.Graphics.DrawLine(pen, pt.X, pt.Y - p.Height, pt.X + p.Width - 1, pt.Y - p.Height);
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y - p.Height, pt.X + p.Width - 1 + sp, pt.Y - p.Height);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y - p.Height, pt.X + p.Width - 1 + sp, pt.Y - p.Height);
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);

                        //e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        //e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y);
                        //e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);
                        pt.Y++;
                    }
                }
            }
        }

        /*
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        */
    }
}
