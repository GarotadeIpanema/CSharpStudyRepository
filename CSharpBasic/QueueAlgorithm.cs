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
    public partial class QueueAlgorithm : Form
    {
        public QueueAlgorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue queue = new Queue(5);
            queue.Enque(textBox1.Text);
            queue.Enque(textBox2.Text);
            queue.Enque(textBox3.Text);
            queue.Enque(textBox4.Text);
            queue.Enque(textBox5.Text);

            string str = "";
            for(int i = 0; i < 10; i++)
            {
                str += queue.Dequeue();
            }
            textBox6.Text = str;

        }

    }

    class Queue
    {
        private object[] list = null;
        private int maxLength;
        private int front;
        private int rear;

        public Queue(int max)
        {
            list = new object[max];
            maxLength = max;
            front = -1;
            rear = 0;
        }

        public void Enque(object obj)
        {
            if(front == rear || rear >= maxLength)
            {
                MessageBox.Show("범위 초과");
                return;
            }
            list[rear++] = obj;
        }

        public object Dequeue()
        {
            return (front < rear-1) ? $"{list[++front]}\r\n" : "더 이상 값이 없습니다\r\n";
        }

        // enque deque print
    }
}
