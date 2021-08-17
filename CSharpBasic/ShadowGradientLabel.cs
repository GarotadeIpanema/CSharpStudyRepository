using System;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CSharpBasic
{
    [ToolboxItem(true)]
    public partial class ShadowGradientLabel : Label
    {
        private bool _drawGradient = true;
        private Color _startColor = Color.White;
        private Color _endColor = Color.Black;
        private float _angle = 0;

        private bool _drawShadow = true;
        private float _yOffset = 1;
        private float _xOffset = 1;
        private Color _shadowColor = Color.Black;

        private void InitializeComponent()
        {
            this.ForeColor = Color.Black;
        }

        // https://srctree.tistory.com/87?category=917283
        public ShadowGradientLabel()
        {
            this.InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);

            Rectangle rectText = this.ClientRectangle;
            Rectangle rectShadow = new Rectangle(rectText.Left + (int)_xOffset, rectText.Top + (int)_yOffset, rectText.Width, rectText.Height);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_drawGradient)
            {
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), _startColor, _endColor, _angle, true);
                e.Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
            }

            // 정렬값
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            if(this.TextAlign == ContentAlignment.BottomCenter)
            {
                flags = TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
            }
            else if(this.TextAlign == ContentAlignment.BottomLeft)
            {
                flags = TextFormatFlags.Bottom | TextFormatFlags.Left;
            }
            else if(this.TextAlign == ContentAlignment.BottomRight)
            {
                flags = TextFormatFlags.Bottom | TextFormatFlags.Right;
            }
            else if(this.TextAlign == ContentAlignment.MiddleCenter)
            {
                flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            }
            else if(this.TextAlign == ContentAlignment.MiddleLeft)
            {
                flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
            }
            else if(this.TextAlign == ContentAlignment.MiddleRight)
            {
                flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
            }
            else if(this.TextAlign == ContentAlignment.TopCenter)
            {
                flags = TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
            }
            else if(this.TextAlign == ContentAlignment.TopLeft)
            {
                flags = TextFormatFlags.Top | TextFormatFlags.Left;
            }
            else if(this.TextAlign == ContentAlignment.TopRight)
            {
                flags = TextFormatFlags.Top | TextFormatFlags.Right;
            }

            // 그림자 그리기
            if(_drawShadow)
            {
                TextRenderer.DrawText(e.Graphics, Text, this.Font, rectShadow, this._shadowColor, flags);
            }

            // 텍스트 그리기
            TextRenderer.DrawText(e.Graphics, Text, this.Font, rectText, this.ForeColor, flags);
        }

        [Category("Gradient"), Description("그라디언트 사용여부"), DefaultValue(true)]
        public bool DrawGradient
        {
            get { return this._drawGradient; }
            // Invalidate,  해당 컨트롤 영역을 무효화 해서 Paint 이벤트가 일어날 때 처리하도록 해서 바로 동기화 되지는 않는다.
            // 강제로 WM_PAINT 메시지를 발생시키고, WM_PAINT 메시지는 OnDraw() 함수를 호출해서 화면을 다시 그리는 역할을 한다.
            //그래서 프로그램의 함수가 데이터를 변경하는 경우에는 CView 클래스의 Invalidate() 함수를 호출하여 OnDraw() 함수를 호출해야 한다
            // Invalidate(TRUE)는 윈도우의 background를 전부 지운 후 BeginPaint() 함수를 이용하여 다시 그리고, 
            //  Invalidate(FALSE) 함수는 background는 그대로 남겨두고 바뀐 부분만 그린다. 디폴트 인수는 TRUE이다.
            set { this._drawGradient = value; this.Invalidate(); }
        }

        [Category("Gradient"), Description("그라디언트 시작 색상"), DefaultValue(typeof(Color), "Color.White")]
        public Color StartColor
        {
            get { return this._startColor; }
            set { this._startColor = value; this.Invalidate(); }
        }

        [Category("Gradient"), Description("그라디언트 끝 색상"), DefaultValue(typeof(Color), "Color.Black")]
        public Color EndColor
        {
            get { return this._endColor; }
            set { this._endColor = value; this.Invalidate(); }
        }

        [Category("Gradient"), Description("그라디언트 방향"), DefaultValue(0)]
        public float Angle
        {
            get { return this._angle; }
            set { this._angle = value; this.Invalidate(); }
        }

        [Category("Drop Shadow"), Description("그림자 사용여부"), DefaultValue(true)]
        public bool DrawShadow 
        { 
            get { return this._drawShadow; }
            set { this._drawShadow = value; this.Invalidate(); }
        }

        [Category("Drop Shadow"), Description("그림자 X 너비"), DefaultValue(1)]
        public float XOffset
        {
            get { return this._xOffset; }
            set { this._xOffset = value; this.Invalidate(); }
        }

        [Category("Drop Shadow"), Description("그림자 Y 너비"), DefaultValue(1)]
        public float YOffset
        {
            get { return this._yOffset; }
            set { this._yOffset = value; this.Invalidate(); }
        }

        [Category("Drop Shadow"), Description("그림자 색상"), DefaultValue(typeof(Color), "Color.DarkGray")]
        public Color ShadowColor
        {
            get { return this._shadowColor; }
            set { this._shadowColor = value; this.Invalidate(); }
        }
    }
}
