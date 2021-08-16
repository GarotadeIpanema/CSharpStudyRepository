using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CSharpBasic
{
    public partial class NaverNewsBrowser : Form
    {
        ChromiumWebBrowser chrome = null;

        public NaverNewsBrowser(string url)
        {
            InitializeComponent();
            InitializeChromeBrowser(url);

        }

        private void InitializeChromeBrowser(string url)
        {
            if (!Cef.IsInitialized) // 만약 초기화를 안해줬다면 생성
            {
                CefSettings cefSettings = new CefSettings();
                Cef.Initialize(cefSettings);
            }

            chrome = new ChromiumWebBrowser(url);
            chrome.Dock = DockStyle.Fill;
            this.Controls.Add(chrome);
        }
    }
}