using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class ParallelProgramming : Form
    {
        // 병렬 프로그래밍 (Parallel Programming)
        // CPU가 하나였던 시대에서 2개, 4개의 CPU를 장착하는 것이 보편화 됨에 따라, 이러한 복수 CPU를 충분히 활용하기 위한 프로그래밍 기법에 대한 요구가 증가
        // .NET 4.0에서는 이러한 요구에 부합하기 위해 Parallel Framework (PFX)라 불리우는 병렬 프로그래밍 프레임워크를 추가
        // 병렬처리는 큰 일거리를 분할하는 단계, 분할된 작업들을 병렬로 실행하는 단계, 그리고 결과를 집계하는 단계로 진행
        // 일거리를 분할하는 방식은 크게 Data Parallelism과 Task Parallelism으로 나누어 진다
        // Data Parallelism은 대량의 데이타를 처리하는데 있어 각 CPU에 일감을 나눠서 주고 동시에 병렬로 처리하는 것
        // 즉, 대량의 데이타를 분할하여 다중 CPU를 사용하여 다중 쓰레드들이 각각 할당된 데이타를 처리하는데 일반적으로 쓰레드 당 처리 내용은 동일
        // Task Parallelism은 큰 작업 Task를 분할하여 각 쓰레드들이 나눠서 다른 작업 Task들을 실행하는 것
        //  Parallel Framework (PFX)은 크게 (1) PLINQ (Parallel LINQ)와 Parallel 클래스 (For/Foreach 메서드)를 중심으로 하는 Data Parallelism 지원 클래스들과
        // (2) Task, TaskFactory 클래스 등 Task Parallelism을 지원하는 클래스들로 구별

        public ParallelProgramming()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Thread";
            dataGridView1.Columns[1].HeaderText = "number";
            
        }

        // 1. 순차적 실행
        // 동일 쓰레드가 0 ~ 999 출력
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 1000; i++)
            {
                dataGridView1.Rows.Add(Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        // 2. 병렬처리
        // 다중쓰레드가 병렬로 출력
        private void button2_Click(object sender, EventArgs e)
        {
            Parallel.For(0, 1000, (i) =>
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            });
        }

        // 순차처리 vs Parallel 병렬처리
        // 대량의 데이타를 여러 쓰레드가 나눠서 처리하는 병렬 처리는 많은 경우 순차적으로 처리하는 것보다 빠를 가능성이 크다
        const int Max = 10000000;
        const int SHIFT = 3;

        // 순차적 암호화
        private void button4_Click(object sender, EventArgs e)
        {
            // 테스트 데이터 셋업
            // 1000만개의 스트림
            string text = "I am a boy. My name is Tom.";
            List<string> textList = new List<string>(Max);
            for(int i = 0; i < Max; i++)
            {
                textList.Add(text);
            }

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < Max; i++)
            {
                char[] chArr = textList[i].ToCharArray();

                // 모든 문자를 시저 암호화
                for(int x = 0; x < chArr.Length; x++)
                {
                    if(chArr[x] >= 'a' && chArr[x] <= 'z')
                    {
                        chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if(chArr[x] >= 'A' && chArr[x] <= 'Z')
                    {
                        chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                    }
                }

                // 변경된 암호로 치환
                textList[i] = new String(chArr);
            };
            stopwatch.Stop();
            textBox1.Text = stopwatch.Elapsed.ToString();

        }

        // 병렬 암호화
        private void button3_Click(object sender, EventArgs e)
        {
            // 테스트 데이터 셋업
            // 1000만개의 스트링
            string text = "I am a boy. My name is Tom.";
            List<string> textList = new List<string>(Max);
            for(int i = 0; i < Max; i++)
            {
                textList.Add(text);
            }

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Parallel.For(0, Max, i =>
            {
                char[] chArr = textList[i].ToCharArray();

                // 모든 문자열 시저 암호화
                for (int x = 0; x < chArr.Length; x++)
                {
                    if (chArr[x] >= 'a' && chArr[x] <= 'z')
                    {
                        chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if (chArr[x] >= 'A' && chArr[x] <= 'Z')
                    {
                        chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                    }
                }
                // 변경된 암호로 치환
                textList[i] = new String(chArr);
            });
            stopwatch.Stop();
            textBox2.Text = stopwatch.Elapsed.ToString();
        }

        // Parallel.Invoke()
        // Parallel.Invoke() 메서드는 여러 작업들을 병렬로 처리하는 기능을 제공
        // 다수의 작업 내용을 Action delegate로 받아 들여 다중 쓰레드들로 동시에 병렬로 Task를 나눠서 실행
        // Task 클래스와 다른 점은, 만약 1000개의 Action 델리게이트가 있을 때, Task 클래스는 보통 1000개의 쓰레드를 생성하여 실행하지만(물론 사용자 다르게 지정할 수 있지만),
        // Parallel.Invoke는 1000개를 일정한 집합으로 나눠 내부적으로 상대적으로 적은(적절한) 수의 쓰레드들에게 자동으로 할당해서 처리
        private void RunTasks()
        {
            Parallel.Invoke(
                () => { Console.WriteLine("method1"); },
                () => { Console.WriteLine("method2"); },
                () => { Console.WriteLine("method3"); },
                () => { Console.WriteLine("method4"); },
                () => { Console.WriteLine("method5"); }
            );

            // ... 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RunTasks();
        }
    }
}
