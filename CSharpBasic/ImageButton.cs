﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ImageButton : Panel
    {
        private Image image01 = System.Drawing.SystemIcons.Hand.ToBitmap();
        private Image image02 = System.Drawing.SystemIcons.Hand.ToBitmap();

        [Browsable(true)]
        public Image Image_01
        {
            get { return this.image01; }
            set
            {
                this.image01 = value;
                this.BackgroundImage = image01;
            }
        }

        [Browsable(true)]
        public Image Image_02
        {
            get { return this.image02; }
            set
            {
                this.image02 = value;
            }
        }
        public ImageButton()
        {
            InitializeComponent();

            this.MouseDown += ImageButton_MouseDown;
            this.MouseUp += ImageButton_MouseUp;

            this.BackgroundImage = this.image01;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = this.image02;
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = this.image01;
        }
    }
}
