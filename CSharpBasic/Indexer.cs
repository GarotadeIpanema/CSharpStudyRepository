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
    // Indexer
    // 인덱서는 인덱스를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티
    // 객체를 마치 배열처럼 사용할 수 있게 해준다
    public partial class Indexer : Form
    {
        private MyList list;
        private int idx;
        public Indexer()
        {
            InitializeComponent();

             list = new MyList();
            idx = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list[idx++] = textBox1.Text;

            string str = "";

            for (int i = 0; i < list.Length; i++)
            {
                str += $"{list[i]}\r\n";
            }

            textBox2.Text = str;
        }
    }

    class MyList
    {
        private object[] array;

        public MyList()
        {
            array = new object[5]; // 인덱스 크기 설정
        }

        // 인덱서 생성
        public object this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<object>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
}
