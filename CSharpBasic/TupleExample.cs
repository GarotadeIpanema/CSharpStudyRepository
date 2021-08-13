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
    public partial class TupleExample : Form
    {
        // Tuple
        // 튜플을 사용하면 여러 개의 개별 값을 이용하여 단일의 복합(composition) 값을 만들 수 있다.
        // 각각의 값이 서로 연관되어 있음에도 새로운 타입을 작성하고 싶지 않다면, 추가적인 캡슐화 작업 없이 간단히 복합 구성을 사용할 수 있다.

        public TupleExample()
        {
            InitializeComponent();
        }

        // EX1
        // 예를 들어 일련의 정수 시퀀스가 있고, 한 번 순회하는 동안 최솟값과 최댓값을 모두 찾고 싶다고 가정해 보자.
        // 1. 이러한 작업을 수행하도록 메서드 하나를 만든다면 이 메서드의 반환값을 어떻게 지정해야 할까? 최솟값을 반환값을 통해 받고 최댓값은 out 매개변수를 통해 받거나, 두 값 모두를 out 매개변수를 통해 받을 수도 있다. 
        // 그리 활용도가 높지 않은 타입을 새로 생성하는 것도 부담이다.
        public void OutMinMaxEX(int number1, int number2, out int min, out int max)
        {
            min = (number1 > number2) ? number2 : number1;
            max = (number1 > number2) ? number1 : number2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min, max;
            OutMinMaxEX(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),out min, out max);
            label3.Text = $"min = {min}, max = {max}";
        }
        // 2. .NET 4에서 처음으로 소개된 Tuple<,> 클래스를 사용하여 Tuple<int, int> 타입을 반환하도록 할 수 있다. 다만, 이 경우에도 어떤 값이 최솟값이고 어떤 값이 최댓값인지를 쉽게 설명할 방법이 없다
        public Tuple<int, int> TupleClassEX(int number1, int number2)
        {
            return new Tuple<int, int>(
                (number1 > number2) ? number2 : number1,
                (number1 > number2) ? number1 : number2
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tuple<int, int> minMax = TupleClassEX(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            label5.Text = $"min = {minMax.Item1}, max = {minMax.Item2}";
        }

        // 3. # 7의 튜플을 이용하는 방법이 있다. 
        public (int min, int max) Tuple7EX(int number1, int number2)
        {
            return (
                    (number1 > number2) ? number2 : number1,
                    (number1 > number2) ? number1 : number2
                );
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var result = Tuple7EX(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            label7.Text = $"min = {result.min}, max = {result.max}";
        }

        // 4. 다 수의 데이터 중 min, max 데이터 추출
        public (int min, int max) Tuple7MinMaxEx(IEnumerable<int> source)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext()) // 시퀀스(데이터)가 있는지 확인
                {
                    // 없으면 예외처리 발생
                    throw new InvalidOperationException("Cannot find min/max of an empty sequence");
                }

                // 만약에 값이 있다면, 첫 번째 값으로 min, max 변수를 초기화 시켜 준다
                int min = iterator.Current;
                int max = iterator.Current;

                while (iterator.MoveNext()) // 시퀀스가 있을 때까지 반복
                {
                    min = Math.Min(min, iterator.Current);
                    max = Math.Max(max, iterator.Current);
                }

                return (min, max);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[] data =
            {
                Convert.ToInt32(textBox7.Text),
                Convert.ToInt32(textBox8.Text),
                Convert.ToInt32(textBox9.Text),
                Convert.ToInt32(textBox10.Text),
                Convert.ToInt32(textBox11.Text),
                Convert.ToInt32(textBox12.Text),
                Convert.ToInt32(textBox13.Text),
                Convert.ToInt32(textBox14.Text),
                Convert.ToInt32(textBox15.Text),
                Convert.ToInt32(textBox16.Text),
            };
            var r = Tuple7MinMaxEx(data);

            label9.Text = $"min = {r.min}, max = {r.max}";
        }
    }
}
