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

namespace ModernUi
{
    public partial class GradientRoundBorderButton : Button
    {
        private Brush _gradient_Brush;
        private EventHandler handlerGradientChanged;

        private int _cornerRadius1 = 40;
        private int _cornerRadius2 = 40;
        private int _cornerRadius3 = 40;
        private int _cornerRadius4 = 40;

        public GradientRoundBorderButton()
        {
            InitializeComponent();
            BorderRadius(40);
            handlerGradientChanged = new EventHandler(GradientChanged);
            ResizeRedraw = true;
        }

        // 그라데이션

        // encapsulated data
        private List<Color> m_clrColors = new List<Color>();
        private int m_nTransparency = 64;
        private float m_fAngle = 0.0f;

        // The properties
        // transparency value for the button gradiants
        public int Transparency
        {
            get { return m_nTransparency; }
            set
            {
                m_nTransparency = value;
                Invalidate();
            }
        }

        // angle for the gradiant from the x-axis
        public float Angle
        {
            get { return m_fAngle; }
            set
            {
                m_fAngle = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
            EditorAttribute("typeof(CollectionEditor)", "typeof(System.Driwubg.Design.UITyoeEditor)")]
        public List<Color> Colors
        {
            get { return m_clrColors; }
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (m_clrColors.Count > 1)
            {
                float percentage = Convert.ToSingle(ClientRectangle.Width - 2) * (1.0f / Convert.ToSingle(m_clrColors.Count - 1));
                Brush b;
                RectangleF rectF;
                Color c1;
                Color c2;

                rectF = new RectangleF(new PointF(0.0f, 1.0f), new SizeF(percentage, ClientRectangle.Height - 2));
                for (int i = 0; i < m_clrColors.Count - 1; i++)
                {
                    c1 = Color.FromArgb(m_nTransparency, m_clrColors[i]);
                    c2 = Color.FromArgb(m_nTransparency, m_clrColors[i + 1]);

                    b = new System.Drawing.Drawing2D.LinearGradientBrush(rectF, c1, c2, m_fAngle);
                    pevent.Graphics.FillRectangle(b, rectF);
                    rectF.Offset(percentage, 0);
                    b.Dispose();
                }
            }
        }

        private void GradientChanged(object sender, EventArgs e)
        {
            if (_gradient_Brush != null) _gradient_Brush.Dispose();
            _gradient_Brush = null;
            Invalidate();
        }

        // round

        private void BorderRadius(int first)
        {
            Rectangle Bounds = new Rectangle(0, 0, this.Width, this.Height);

            float r2 = first / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(Bounds.X, Bounds.Y, first, first, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - first, Bounds.Y, first, first, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + r2, Bounds.Width, Bounds.Height - r2);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - first,
                      Bounds.Y + Bounds.Height - first, first, first, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);

            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - first, first, first, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - r2, Bounds.X, Bounds.Y + r2);

            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);
            this.Show();
        }
        private void BorderRadius(int first, int second)
        {
            Rectangle Bounds = new Rectangle(0, 0, this.Width, this.Height);

            float r2 = first / 2f;
            float ra2 = second / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(Bounds.X, Bounds.Y, first, first, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - second, Bounds.Y, second, second, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + ra2, Bounds.Width, Bounds.Height - ra2);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - first,
                      Bounds.Y + Bounds.Height - first, first, first, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);

            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - second, second, second, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - ra2, Bounds.X, Bounds.Y + ra2);

            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);
            this.Show();
        }

        private void BorderRadius(int first, int second, int thirdth)
        {
            Rectangle Bounds = new Rectangle(0, 0, this.Width, this.Height);

            float r2 = first / 2f;
            float ra2 = second / 2f;
            float rad2 = thirdth / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(Bounds.X, Bounds.Y, first, first, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - second, Bounds.Y, second, second, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + ra2, Bounds.Width, Bounds.Height - ra2);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - thirdth,
                      Bounds.Y + Bounds.Height - thirdth, thirdth, thirdth, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - rad2, Bounds.Height, Bounds.X + rad2, Bounds.Height);

            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - second, second, second, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - ra2, Bounds.X, Bounds.Y + ra2);

            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);
            this.Show();
        }

        private void BorderRadius(int first, int second, int thirdth, int fourth)
        {
            Rectangle Bounds = new Rectangle(0, 0, this.Width, this.Height);

            float r2 = first / 2f;
            float ra2 = second / 2f;
            float rad2 = thirdth / 2f;
            float radi2 = fourth / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(Bounds.X, Bounds.Y, first, first, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - second, Bounds.Y, second, second, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + ra2, Bounds.Width, Bounds.Height - ra2);

            graphicsPath.AddArc(Bounds.X + Bounds.Width - thirdth,
                      Bounds.Y + Bounds.Height - thirdth, thirdth, thirdth, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - rad2, Bounds.Height, Bounds.X + rad2, Bounds.Height);

            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - fourth, fourth, fourth, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - radi2, Bounds.X, Bounds.Y + radi2);

            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);
            this.Show();
        }

        public int CornerRadius1
        {
            get { return _cornerRadius1; }
            set
            {
                _cornerRadius1 = value;
                BorderRadius(_cornerRadius1);
            }
        }
        public int CornerRadius2
        {
            get { return _cornerRadius2; }
            set
            {
                _cornerRadius2 = value;
                BorderRadius(_cornerRadius1, _cornerRadius2);
            }
        }
        public int CornerRadius3
        {
            get { return _cornerRadius3; }
            set
            {
                _cornerRadius3 = value;
                BorderRadius(_cornerRadius1, _cornerRadius2, _cornerRadius3);
            }
        }
        public int CornerRadius4
        {
            get { return _cornerRadius4; }
            set
            {
                _cornerRadius4 = value;
                BorderRadius(_cornerRadius1, _cornerRadius2, _cornerRadius3, _cornerRadius4);
            }
        }

        private void CustomRoundButton_Resize(object sender, EventArgs e)
        {
            BorderRadius(_cornerRadius1, _cornerRadius2, _cornerRadius3, _cornerRadius4);
        }
    }
}
