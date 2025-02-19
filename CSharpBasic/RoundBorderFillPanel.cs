﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class RoundBorderFillPanel : Panel
    {
        public int padding = 5;
        public int radius = 10;
        public bool isBorder = true;
        public Color borderColor = Color.FromArgb(128, 51, 94, 129);
        public int borderWidth = 5;
        public bool isFill = false;
        public Color fillColor = Color.FromArgb(128, 243, 246, 251);

        // https://srctree.tistory.com/50?category=917283
        public RoundBorderFillPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if(isFill)
            {
                g.FillRoundedRectangle(new SolidBrush(fillColor), padding, padding, this.Width - padding * 2, this.Height - padding * 2, radius);
            }
            if(isBorder)
            {
                g.DrawRoundedRectangle(new Pen(borderColor, borderWidth), padding, padding, this.Width - padding * 2, this.Height - padding * 2, radius);
            }
        }

        // 패널 윈도우에 투명 속성 추가
        const int WS_EX_TRANSPARENT = 0x20;
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }
    }

    static class GraphicsExtenstion
    {
        private static GraphicsPath GenerateRoundedRectangle(
            this Graphics graphics
            , RectangleF rectangle
            , float radius)
        {
            float diameter;
            GraphicsPath path = new GraphicsPath();
            if(radius <= 0.0F)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();
                return path;
            }
            else
            {
                if(radius >= (Math.Min(rectangle.Width, rectangle.Height)) / 2.0)
                {
                    return graphics.GenerateCapsule(rectangle);
                }
                diameter = radius * 2.0F;
                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(rectangle.Location, sizeF);
                path.AddArc(arc, 180, 90);
                arc.X = rectangle.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = rectangle.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = rectangle.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();
            }
            return path;
        }

        private static GraphicsPath GenerateCapsule(
            this Graphics graphics,
            RectangleF baseRect)
        {
            float diameter;
            RectangleF arc;
            GraphicsPath path = new GraphicsPath();
            try
            {
                if(baseRect.Width > baseRect.Height)
                {
                    diameter = baseRect.Height;
                    SizeF sizef = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizef);
                    path.AddArc(arc, 90, 180);
                    arc.X = baseRect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if(baseRect.Width < baseRect.Height)
                {
                    diameter = baseRect.Width;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = baseRect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else
                {
                    path.AddEllipse(baseRect);
                }
            }
            catch
            {
                path.AddEllipse(baseRect);
            }
            finally
            {
                path.CloseFigure();
            }
            return path;
        }

        public static void DrawRoundedRectangle(
            this Graphics graphics
            , Pen pen
            , float x
            , float y
            , float width
            , float height
            , float radius)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
            SmoothingMode old = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawPath(pen, path);
            graphics.SmoothingMode = old;
        }
        
        public static void DrawRoundedRectangle(
            this Graphics graphics
            ,Pen pen
            ,int x
            ,int y
            ,int width
            ,int height
            ,int radius)
        {
            // 지정된 값을 단정밀도 부동 소수점 숫자로 변환
            graphics.DrawRoundedRectangle(
                pen
                , Convert.ToSingle(x)
                , Convert.ToSingle(y)
                , Convert.ToSingle(width)
                , Convert.ToSingle(height)
                , Convert.ToSingle(radius));
        }

        public static void FillRoundedRectangle(
            this Graphics graphics
            ,Brush brush
            ,float x
            ,float y
            ,float width
            ,float height
            ,float radius)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
            SmoothingMode old = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillPath(brush, path);
            graphics.SmoothingMode = old;
        }

        public static void FillRoundedRectangle(
            this Graphics graphics
            , Brush brush
            , int x
            , int y
            , int width
            , int height
            , int radius)
        {
            graphics.FillRoundedRectangle(
                brush
                , Convert.ToSingle(x)
                , Convert.ToSingle(y)
                , Convert.ToSingle(width)
                , Convert.ToSingle(height)
                , Convert.ToSingle(radius));
        }
    }
}
