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

namespace CSharpBasic
{
    public partial class GradientButton : Button
    {
        // https://afsdzvcx123.tistory.com/entry/C-%EC%9C%88%ED%8F%BC-C-%EC%9C%88%ED%8F%BC-Custom%EC%9C%BC%EB%A1%9C-%EA%B7%B8%EB%9D%BC%EB%8D%B0%EC%9D%B4%EC%85%98%EB%B2%84%ED%8A%BC-GradientButton-%EC%BB%A8%ED%8A%B8%EB%A1%A4-%EB%A7%8C%EB%93%A4%EA%B8%B0?category=784689
        private Brush gradientBrush;

        public GradientButton()
        {
            InitializeComponent();

            handlerGradientChanged = new EventHandler(GradientChanged);
            ResizeRedraw = true;
        }

        private EventHandler handlerGradientChanged;

        //데이터 캡슐화
        private List<Color> m_clrColors = new List<Color>();
        private int m_nTransparency = 64;
        private float m_fAngle = 0.0f;

        // 버튼 그라디언트의 속성 투명도 값
        public int Transparency
        {
            get { return m_nTransparency; }
            set
            {
                m_nTransparency = value;
                Invalidate();
            }
        }

        // x축에서 기울기에 대한 각도
        public float Angle
        {
            get { return m_fAngle; }
            set
            {
                m_fAngle = value;
                Invalidate();
            }
        }
        // DesignerSerializationVisibility, 속성이 가진 표시 유형을 디자인 타임 serializer에 지정
        // Content, 코드 생성기에서 개체 자체가 아닌 개체의 내용에 대한 코드가 생성
        // EditorAttribute, 속성을 변경하는 데 사용할 편집기를 지정
        // CollectionEditor, 디자인 타임에 대부분의 컬렉션 형식을 편집할 수 있는 사용자 인터페이스를 제공
        // UITypeEditor, 값 편집기를 디자인하는 데 사용할 수 있는 기본 클래스를 제공합니다. 값 편집기는 지원되는 데이터 형식 개체의 값을 나타내고 편집할 수 있는 사용자 인터페이스를 제공
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), EditorAttribute("typeof(CollectionEditor)", "typeof(System.Drawing.Design.UITypeEditor)")]
        public List<Color> Colors
        {
            get { return m_clrColors; }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if(m_clrColors.Count > 1)
            {
                float percentage = Convert.ToSingle(ClientRectangle.Width - 2) * (1.0f / Convert.ToSingle(m_clrColors.Count - 1));
                Brush b;
                RectangleF rectF;
                Color c1;
                Color c2;

                rectF = new RectangleF(new PointF(0.0f, 1.0f), new SizeF(percentage, ClientRectangle.Height - 2));
                for(int i = 0; i < m_clrColors.Count - 1; i++)
                {
                    c1 = Color.FromArgb(m_nTransparency, m_clrColors[i ]);
                    c2 = Color.FromArgb(m_nTransparency, m_clrColors[i + 1]);

                    b = new LinearGradientBrush(rectF, c1, c2, m_fAngle);
                    pevent.Graphics.FillRectangle(b, rectF);
                    rectF.Offset(percentage, 0);
                    b.Dispose();
                }
            }
        }

        private void GradientChanged(object sender, EventArgs e)
        {
            if (gradientBrush != null) gradientBrush.Dispose();
            gradientBrush = null;
            Invalidate();
        }
    }
}
