using System;
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
    public partial class LINQGroupBy : Form
    {
        List<string> names = null;
        public LINQGroupBy()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            names = new List<string>(); 

            names.Add(textBox1.Text);
            names.Add(textBox2.Text);
            names.Add(textBox3.Text);
            names.Add(textBox4.Text);
            names.Add(textBox5.Text);

            List<GropByObj> objs = new List<GropByObj>();
            // Group By Logic
            for(int i = 0; i < names.Count; i++)
            {
                if(objs.Count == 0 )
                {
                    objs.Add(new GropByObj { name = names[i], count = 1 });
                    continue;
                }
                for(int j = 0; j < objs.Count; j++)
                {
                    if (names[i] == objs[j].name)
                    {
                        objs[j].count++;
                        break;
                    }else if(j == (objs.Count-1))
                    {
                        objs.Add(new GropByObj { name = names[i], count = 1 });
                        break;
                    }
                }
            }
            // Orderby Logic
            for(int i = 0; i < objs.Count; i++)
            {
                for(int j = i + 1; j < objs.Count; j++)
                {
                    if(string.Compare(objs[i].name, objs[j].name) == 1)
                    {
                        GropByObj obj = objs[i];
                        objs[i] = objs[j];
                        objs[j] = obj;
                    }
                }
            }

            string str = "";
            for(int i = 0; i < objs.Count; i++)
            {
                str += $"{objs[i].ToString()} \r\n";
            }
            textBox6.Text = str;

            str = "";
            List<GropByObj> objs2 = new List<GropByObj>();
            objs2 = names.GroupBy(name => name).Select(gr => new GropByObj { name = gr.Key, count = gr.Count() }).OrderBy(item => item.name).ToList();
            for (int i = 0; i < objs.Count; i++)
            {
                str += $"{objs[i].ToString()} \r\n";
            }
            textBox7.Text = str;
        }

        class GropByObj
        {
            public string name { get; set; }
            public int count { get; set; }
            public override string ToString()
            {
                return $"{name} : {count}";
            }
        }
    }
}
