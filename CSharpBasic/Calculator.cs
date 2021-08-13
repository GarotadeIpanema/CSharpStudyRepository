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
    public partial class Calculator : Form
    // 계산기 참고
    // https://m.blog.naver.com/PostView.naver?blogId=pko603&logNo=221586473785&targetKeyword=&targetRecommendationCode=1
    {
        public Calculator()
        {
            InitializeComponent();

            Resetbtn.Click += ResetTextBox;

            result.Click += ExpressionCalc;

            bracket.Click += WriteTextButtonEvent;
            squared.Click += WriteTextButtonEvent;
            remain.Click += WriteTextButtonEvent;
            multiple.Click += WriteTextButtonEvent;
            one.Click += WriteTextButtonEvent;
            two.Click += WriteTextButtonEvent;
            three.Click += WriteTextButtonEvent;
            divide.Click += WriteTextButtonEvent;
            four.Click += WriteTextButtonEvent;
            five.Click += WriteTextButtonEvent;
            six.Click += WriteTextButtonEvent;
            plus.Click += WriteTextButtonEvent;
            seven.Click += WriteTextButtonEvent;
            eight.Click += WriteTextButtonEvent;
            nine.Click += WriteTextButtonEvent;
            minus.Click += WriteTextButtonEvent;
            dot.Click += WriteTextButtonEvent;
            zero.Click += WriteTextButtonEvent;
            tensquared.Click += WriteTextButtonEvent;
        }

        private void WriteTextButtonEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void ResetTextBox(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ExpressionCalc(object sender, EventArgs e)
        {
            // full code

            // 괄호 추가
            string equation = textBox1.Text;

            // 괄호의 위치
            int indexBracketLeft = 0;
            int indexBracketRight = 0;
            // 괄호의 갯수
            int countBracketLeft = equation.Split('(').Length - 1;
            int countBracketRight = equation.Split(')').Length - 1;
            
            if(countBracketLeft != countBracketRight)
            {
                MessageBox.Show("식이 잘못되었습니다. 괄호를 확인해주세요.");
                return;
            }
            /*
                        // 단일 괄호(1+2) + (1-2)
                        string subEquation = "";
                        // 괄호가 하나면 반복문을 굳이 활용하지 않아도 되지만 그렇지 않다면 괄호의 갯수만큼 반복문을 돌려준다
                        // left와 right의 갯수는 동일하기에 원하는 갯수를 넣어주면 된다
                        for (int i = 0; i < countBracketLeft; i++)
                        {
                            // 괄호의 위치를 저장하는 변수
                            // IndexOf method는 string에서 특정 string의 위치를 찾아준다
                            indexBracketLeft = equation.IndexOf("(");
                            indexBracketRight = equation.IndexOf(")");

                            // equation에서 특정 부분을 추출한 내용을 저장하는 변수
                            // .Substring(startIndex, length) 몇번째 인덱스에서 몇 자리까지 잘라올지 지정, 괄호를 제외한 식만 갖고 온다
                            subEquation = equation.Substring(indexBracketLeft + 1, indexBracketRight - indexBracketLeft - 1);

                            // 추출한 문자열을 괄호안의 연산에 대한 결과를 갖고 온다
                            double subResult = CalculatorMethod(subEquation);
                            // 괄호안의 연산식을 연산 결과로 바꿔준다
                            equation = equation.Replace($"({subEquation})", Convert.ToString(subResult));
                        }

                        textBox1.Text = Convert.ToString(CalculatorMethod(equation));
            */

            // 복합괄호(1 + (2 + 3) + 4)
            string subEquation = "";
            int indexBracketLeftPlus = 0;
            // 괄호가 하나면 반복문을 굳이 활용하지 않아도 되지만 그렇지 않다면 괄호의 갯수만큼 반복문을 돌려준다
            for (int i = 0; i < countBracketLeft; i++)
            {
                // IndexOf method는 string에서 특정 string의 위치를 찾아준다
                indexBracketLeft = equation.IndexOf("(");
                indexBracketRight = equation.IndexOf(")");
                indexBracketLeftPlus = equation.IndexOf("(", indexBracketLeft + 1);

                // .Substring(startIndex, length) 몇번째 인덱스에서 몇 자리까지 잘라올지 지정, 괄호를 제외한 식만 갖고 온다
                if (indexBracketRight > indexBracketLeftPlus && indexBracketLeftPlus != -1)
                    subEquation = equation.Substring(indexBracketLeftPlus + 1, indexBracketRight - indexBracketLeftPlus - 1);
                else
                    subEquation = equation.Substring(indexBracketLeft + 1, indexBracketRight - indexBracketLeft - 1);

                // 추출한 문자열을 괄호안의 연산에 대한 결과를 갖고 온다
                double subResult = CalculatorMethod(subEquation);
                // 괄호안의 연산식을 연산 결과로 바꿔준다
                equation = equation.Replace($"({subEquation})", Convert.ToString(subResult));
            }

            textBox1.Text = Convert.ToString(CalculatorMethod(equation));

            // 계산
            // textBox1.Text = Convert.ToString(CalculatorMethod(textBox1.Text));


            // 함수 사용
            /*
            char[] delimiter = { '+', '-', '/', '*' };

            string[] strsplit = EquationSpliter(textBox1.Text, delimiter, 0);
            double result = 0;

            result = ArrayCalc(strsplit, '+');

            textBox1.Text = Convert.ToString(result);
            */
        }

        // 계산기 계산 함수
        double CalculatorMethod(string eqn)
        {
            // +를 기준으로 나눈다
            string[] plusSplit = eqn.Split('+');
            // 계산기 총 결과
            double result = 0;

            for (int i = 0; i < plusSplit.Length; i++)
            {
                // 빼기 연산 추가
                string[] minusSplit = plusSplit[i].Split('-');
                // 빼기 연산 결과
                double minusSplitResult = 0;

                for (int j = 0; j < minusSplit.Length; j++)
                {
                    // /를 기준으로 나눈다
                    string[] divSplit = minusSplit[j].Split('/');
                    // 나누기 연산 결과
                    double divSplitResult = 0;

                    for (int k = 0; k < divSplit.Length; k++)
                    {
                        string[] multiSplit = divSplit[k].Split('*');
                        double multiSplitResult = 0;

                        for (int l = 0; l < multiSplit.Length; l++)
                        {
                            if (l == 0)
                                multiSplitResult += Convert.ToDouble(multiSplit[l]);
                            else
                                multiSplitResult *= Convert.ToDouble(multiSplit[l]);
                        }

                        divSplit[k] = Convert.ToString(multiSplitResult);

                        if (k == 0)
                            divSplitResult += Convert.ToDouble(divSplit[k]);
                        else
                            divSplitResult /= Convert.ToDouble(divSplit[k]);
                    }

                    minusSplit[j] = Convert.ToString(divSplitResult);

                    if (j == 0) // 첫 번째 값은 0과 빼는 것이 아닌 더해주고 다음 수와 빼준다
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    else
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);
                }
                // -로 나눈 + 배열 인덱스에 빼기 연산한 결과로 치환
                plusSplit[i] = Convert.ToString(minusSplitResult);

                // 총 결과
                result += Convert.ToDouble(plusSplit[i]);
            }

            //textBox1.Text = result.ToString();
            return result;
        }

        // 배열을 받아 계산하는 식
        double ArrayCalc(string[] strArr, char delimiter)
        {
            //double result = 0;
            double result = Convert.ToDouble(strArr[0]);

            for (int i = 1; i < strArr.Length; i++)
            {
                //if (i == 0)
                //    result += Convert.ToDouble(strArr[i]);

                switch (delimiter)
                {
                    case '+':
                        result += Convert.ToDouble(strArr[i]);
                        break;
                    case '-':
                        result -= Convert.ToDouble(strArr[i]);
                        break;
                    case '/':
                        result /= Convert.ToDouble(strArr[i]);
                        break;
                    case '*':
                        result *= Convert.ToDouble(strArr[i]);
                        break;
                }
            }
            return result;
        }

        // 식을 배열로 만들어주는 함수
        // 식을 받아야 하기 때문에 equation이라는 string 타입을 받는다
        // delimiter라는 char 배열을 받은 이유는 나중에 추가적으로 삼각함수 또는 제곱 연산 등을 추가해야 하므로 배열로 받는다
        string[] EquationSpliter(string equation, char[] delimiter, int delimiterCount)
        {
            int delimiterCountTemp = delimiterCount;
            int delimiterLength = delimiter.Length;
            string[] strSplit = equation.Split(delimiter[delimiterCount]);
            string[] strSubSplit;
            bool splitIsNum = false;

            for (int i = 0; i < strSplit.Length; i++)
            {
                double splitNum = 0;

                splitIsNum = double.TryParse(strSplit[i], out splitNum);

                if(!splitIsNum)
                {
                    if (delimiterCountTemp < delimiterLength)
                        delimiterCountTemp++;

                    strSubSplit = EquationSpliter(strSplit[i], delimiter, delimiterCountTemp);

                    splitNum = ArrayCalc(strSubSplit, delimiter[delimiterCountTemp]);
                }

                delimiterCountTemp = delimiterCount;
                strSplit[i] = Convert.ToString(splitNum);
            }

            return strSplit;
        }

    }
}
