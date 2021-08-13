using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomBorderTextBox : TextBox
    {
        private Color _bottomBorderColor = Color.White;
        private Color _onFocusColor = Color.Red;

        public CustomBorderTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            // Add a label to the control(textbox)
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _bottomBorderColor
            });
            InitializeComponent();
        }

        // Hides the BorderStyle from Control Property,
        // so to avoid people changing BorderStyle of the TextBox
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BottomBorderColor
        {
            get { return _bottomBorderColor; }
            set { 
                _bottomBorderColor = value;
                Controls[0].BackColor = _bottomBorderColor;
            }
        }

        public Color BottomBorderOnFocusColor
        {
            get { return _onFocusColor; }
            set { _onFocusColor = value; }
        }

        private void CustomBorderTextBox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _onFocusColor;
        }

        private void CustomBorderTextBox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomBorderColor;
        }
    }
}
