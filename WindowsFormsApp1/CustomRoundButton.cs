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
        private int _cornerRadius = 40;

        public CustomRoundButton()
        {
            InitializeComponent();
            RoundBorderForm(this);
        }

        public void RoundBorderForm(Button button)
        {
            Rectangle Bounds = new Rectangle(0, 0, button.Width, button.Height);

            float r2 = _cornerRadius / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(Bounds.X, Bounds.Y, 1, 1, 180, 90); // 직각
            // graphicsPath.AddArc(Bounds.X, Bounds.Y, _cornerRadius, _cornerRadius, 180, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);

            // graphicsPath.AddArc(Bounds.X + Bounds.Width, Bounds.Y, 1, 1, 270, 90); // 직각
            graphicsPath.AddArc(Bounds.X + Bounds.Width - _cornerRadius, Bounds.Y, _cornerRadius, _cornerRadius, 270, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + r2, Bounds.Width, Bounds.Height - r2);

            //graphicsPath.AddArc(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height, 1, 1, 0, 90); // 직각
            graphicsPath.AddArc(Bounds.X + Bounds.Width - _cornerRadius,
               Bounds.Y + Bounds.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90); // 둥글게
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);
            
            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height, 1, 1, 90, 90);  // 직각
            // graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // 둥글게
            graphicsPath.AddLine(Bounds.X, Bounds.Height - r2, Bounds.X, Bounds.Y + r2);

            graphicsPath.CloseFigure();

            button.Region = new Region(graphicsPath);
            button.Show();
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

        // 둥근 모서리 버튼 원본
        /*
        public void RoundBorderForm(Button frm)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 40;
            
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            // path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();
            
            float r2 = CornerRadius / 2f;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(Bounds.X, Bounds.Y, 1, 1, 180, 90);
            graphicsPath.AddLine(Bounds.X + r2, Bounds.Y, Bounds.Width - r2, Bounds.Y);
            graphicsPath.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            graphicsPath.AddLine(Bounds.Width, Bounds.Y + r2, Bounds.Width, Bounds.Height - r2);
            graphicsPath.AddArc(Bounds.X + Bounds.Width - CornerRadius,
                             Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            graphicsPath.AddLine(Bounds.Width - r2, Bounds.Height, Bounds.X + r2, Bounds.Height);
            //graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height, 1, 1, 90, 90);
            graphicsPath.AddLine(Bounds.X, Bounds.Height - r2, Bounds.X, Bounds.Y + r2);
            graphicsPath.CloseFigure();

            frm.Region = new Region(graphicsPath);
            frm.Show();
        }
        */
    }
}
