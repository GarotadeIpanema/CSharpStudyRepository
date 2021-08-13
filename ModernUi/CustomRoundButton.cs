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

namespace WindowsFormsApp1
{
    public partial class CustomRoundButton : Button
    {
        // private int _cornerRadius = 40; // 원형에서 사용

        private int _cornerRadius1 = 40;
        private int _cornerRadius2 = 40;
        private int _cornerRadius3 = 40;
        private int _cornerRadius4 = 40;

        public CustomRoundButton()
        {
            InitializeComponent();
            // RoundBorderForm(this);
            BorderRadius(40);
        }

        /*
        // 원형
        private void RoundBorderForm(Button button)
        {
            Rectangle Bounds = new Rectangle(0, 0, button.Width, button.Height);

            float r2 = _cornerRadius / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            // graphicsPath.AddArc(Bounds.X, Bounds.Y, 1, 1, 180, 90); // 직각
            graphicsPath.AddArc(Bounds.X, Bounds.Y, _cornerRadius, _cornerRadius, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            // graphicsPath.AddArc(Bounds.X + Bounds.Width, Bounds.Y, 1, 1, 270, 90); // 직각
            graphicsPath.AddArc(Bounds.X + Bounds.Width - _cornerRadius, Bounds.Y, _cornerRadius, _cornerRadius, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + r2, Bounds.Width, Bounds.Height - r2);

            // graphicsPath.AddArc(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height, 1, 1, 0, 90); // 직각
            graphicsPath.AddArc(Bounds.X + Bounds.Width - _cornerRadius,
                      Bounds.Y + Bounds.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);

            // graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height, 1, 1, 90, 90);  // 직각
            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - r2, Bounds.X, Bounds.Y + r2);

            graphicsPath.CloseFigure();

            button.Region = new Region(graphicsPath);
            button.Show();
        }
        */

        // 매개변수에 따른 다른 효과
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
