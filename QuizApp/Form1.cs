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
using System.IO;
using System.Diagnostics;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        List<string> questionList;          //問題文のリスト
        List<string> answerList;            //解答のリスト
        int questionNumber;                 //問題番号
        string answer;
        string subT;
        string mode;
        int accept;                         //正解数（ノーマル、シャッフルモードで使用）
        int miss = 0;                       //ミスカウント（ヒントモードで使用）
        Stopwatch sw;                       //タイマー（ストイックモードで使用）
        bool shuffle;
        bool hint;

        public Form1()
        {
            InitializeComponent();
        }


        private void StartQuiz()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text Files(.txt)|*.txt",
                Title = mode
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                stream = ofd.OpenFile();
                using (StreamReader file = new StreamReader(stream))
                {
                    int cnt = 0;
                    questionList = new List<string>();
                    answerList = new List<string>();
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        if (cnt == 0)
                        {
                            cnt = 1;
                            sub.Text = line;
                            subT = line;
                            continue;
                        }
                        string[] data = line.Split(',');
                        questionList.Add(data[0]);
                        answerList.Add(data[1]);
                    }

                    if (shuffle == true)
                    {
                        int seed = Environment.TickCount;
                        Random rnd = new Random(seed++);
                        int change = rnd.Next(0, questionList.Count);
                        for (int i = 0; i < change; i++) 
                        {
                            //シャッフルする
                            for (int j = 0; j < questionList.Count; j++)
                            {
                                rnd = new Random(seed++);
                                change = rnd.Next(0, questionList.Count);

                                string Temp = questionList[change];
                                questionList[change] = questionList[i];
                                questionList[i] = Temp;

                                Temp = answerList[change];
                                answerList[change] = answerList[i];
                                answerList[i] = Temp;
                            }
                        }
                    }

                    question.ForeColor = Color.Black;
                    sub.ForeColor = Color.Black;
                    answerBox.Enabled = true;
                    answerButton.Enabled = true;
                    answerBox.Text = "";
                    label1.Text = "解答";
                    questionNumber = 1;
                    label2.Text = "第" + questionNumber + "問/全" + questionList.Count + "問";
                    question.Font = new Font(question.Font.FontFamily, 30);
                    sub.Font = new Font(sub.Font.FontFamily, 20);
                    question.Text = questionList[0];
                    if (mode == "Normal")
                    {
                        accept = answerList.Count;
                        modeLabel.Text = "ノーマルモード：";
                    }
                    if (mode == "Survival") modeLabel.Text = "サバイバルモード：";
                    if (mode == "Stoic") modeLabel.Text = "ストイックモード：";

                    modeLabel.Text += Path.GetFileNameWithoutExtension(ofd.FileName);
                    modeLabel.Text+= "　シャッフル：";
                    if (shuffle == true) modeLabel.Text += "ON";
                    else modeLabel.Text += "OFF";
                    modeLabel.Text += "　ヒント：";
                    if (hint == true) modeLabel.Text += "ON";
                    else modeLabel.Text += "OFF";
                }
            }
        }


        private async void Answered(object sender, EventArgs e)
        {
            await Task.Delay(30);
            answer = answerBox.Text;
            if (answer == "")
            {
                return;
            }
            while (answer[answer.Length - 1] == ' '|| answer[answer.Length - 1] == '　')
            {
                answer = answer.Remove(answer.Length - 1, 1);
                if (answer == "")
                {
                    return;
                }
            }           //無回答
            AcceptButton = null;
            if (answer != answerList[questionNumber - 1]) 
            {
                if (mode == "Survival")
                {
                    question.Font = new Font(question.Font.FontFamily, 45);
                    question.Text = "不正解";
                    question.ForeColor = Color.DarkBlue;
                    sub.Text = "正解は  " + answerList[questionNumber - 1] + "  でした。もう一回チャレンジ!";
                    sub.ForeColor = Color.DarkBlue;
                    questionNumber--;
                    answerButton.Enabled = false;
                    answerBox.Enabled = false;
                }

                else if (mode == "Stoic")
                {
                    questionNumber--;
                    answerBox.Text = "";
                    if (hint == true)
                    {
                        miss++;
                        answerBox.Text = "";
                        if (miss > 0)
                        {
                            if (miss > answerList[questionNumber].Length)
                            {
                                miss = answerList[questionNumber].Length;
                            }

                            answerBox.Text = answerList[questionNumber].Substring(0, miss);
                        }
                    }
                }

                else if (mode == "Normal") 
                {
                    question.Font = new Font(question.Font.FontFamily, 45);
                    question.Text = "不正解";
                    question.ForeColor = Color.DarkBlue;
                    sub.Text = "正解は  " + answerList[questionNumber - 1] + "  でした";
                    sub.ForeColor = Color.DarkBlue;
                    label1.Text = "";
                    answerButton.Enabled = false;
                    answerBox.Enabled = false;
                    accept--;

                    await Task.Delay(2750);

                    if (questionNumber != questionList.Count)
                    {
                        question.Font = new Font(question.Font.FontFamily, 30);
                        question.Text = questionList[questionNumber];
                        answerBox.Text = "";
                        label1.Text = "解答";
                        sub.Text = subT;
                        question.ForeColor = Color.Black;
                        sub.ForeColor = Color.Black;
                        answerButton.Enabled = true;
                        answerBox.Enabled = true;
                    }

                    else
                    {
                        question.Font = new Font(question.Font.FontFamily, 70);
                        question.Text = "終了";
                        question.ForeColor = Color.OrangeRed;
                        decimal percent = Convert.ToDecimal(accept) / Convert.ToDecimal(answerList.Count) * 100m;
                        string per = percent.ToString("F2");
                        sub.Text = answerList.Count + "問中" + accept + "問正解（" + per + "％）";
                        sub.ForeColor = Color.OrangeRed;
                        answerBox.Text = "";
                        label1.Text = " ";
                        questionNumber--;
                    }
                }
            }                                               //不正解

            else if (answer == answerList[questionNumber - 1])
            {
                sub.Text = "〇";
                sub.ForeColor = Color.OrangeRed;
                sub.Font = new Font(question.Font.FontFamily, 40);

                await Task.Delay(500);

                sub.Font = new Font(question.Font.FontFamily, 20);
                answerBox.Text = "";
                if (hint == true) miss = 0;

                if (questionNumber == questionList.Count)
                {
                    if (mode == "Normal") 
                    {
                        question.Font = new Font(question.Font.FontFamily, 70);
                        question.Text = "終了";
                        question.ForeColor = Color.OrangeRed;
                        decimal percent = Convert.ToDecimal(accept) / Convert.ToDecimal(answerList.Count) * 100m;
                        string per = percent.ToString("F2");
                        sub.Text = answerList.Count + "問中" + accept + "問正解（" + per + "％）";
                        label1.Text = " ";
                        questionNumber--;
                        answerBox.Enabled = false;
                        answerButton.Enabled = false;
                    }

                    else
                    {
                        question.Font = new Font(question.Font.FontFamily, 70);
                        question.Text = "優勝";
                        question.ForeColor = Color.OrangeRed;
                        sub.Text = "お前がナンバーワンだ";
                        if (mode == "Stoic")
                        {
                            sw.Stop();
                            TimeSpan ts = sw.Elapsed;
                            if (ts.Hours == 0)
                            {
                                sub.Text = "記録：" + ts.Minutes + "分" + ts.Seconds + "秒" + ts.Milliseconds;
                            }
                            else
                            {
                                sub.Text = "記録：" + ts.Hours + "時間" + ts.Minutes + "分" + ts.Seconds + "秒" + ts.Milliseconds;
                            }
                            
                        }
                        label1.Text = " ";
                        questionNumber--;
                        answerBox.Enabled = false;
                        answerButton.Enabled = false;
                    }
                }

                else
                {
                    sub.Text = subT;
                    sub.ForeColor = Color.Black;
                    question.Text = questionList[questionNumber];
                }
            }                                                        //正解

            questionNumber++;
            answer = "";
            label2.Text = "第" + questionNumber + "問/全" + questionList.Count + "問";
            AcceptButton = answerButton;
        }

        private void StartSurvival(object sender, EventArgs e)
        {
            mode = "Survival";
            if (shuffleComboBox1.SelectedIndex == 0) shuffle = true;
            else if (shuffleComboBox1.SelectedIndex == 1) shuffle = false;
            hint = false;
            StartQuiz();
            
        }

        private void StartStoic(object sender, EventArgs e)
        {
            mode = "Stoic";
            if (shuffleComboBox1.SelectedIndex == 0) shuffle = true;
            else if (shuffleComboBox1.SelectedIndex == 1) shuffle = false;

            if (hintComboBox1.SelectedIndex == 0)
            {
                hint = true;
                survivalToolStripMenuItem.Enabled = false;
                normalToolStripMenuItem.Enabled = false;
            }
            else if (hintComboBox1.SelectedIndex == 1)
            {
                hint = false;
                survivalToolStripMenuItem.Enabled = true;
                normalToolStripMenuItem.Enabled = true;
            }
            StartQuiz();
            sw = new Stopwatch();
            sw.Start();
        }

        private void StartNormal(object sender, EventArgs e)
        {
            mode = "Normal";
            if (shuffleComboBox1.SelectedIndex == 0) shuffle = true;
            else if (shuffleComboBox1.SelectedIndex == 1) shuffle = false;
            hint = false;
            StartQuiz();
        }

        private void ExitMenuClicked(object sender, EventArgs e) => Close();          //終了

        private void HowToMake(object sender, EventArgs e)
        {
            modeLabel.Text = "問題の作り方";
            question.Font = new Font(question.Font.FontFamily, 25);
            answerBox.Enabled = false;
            answerButton.Enabled = false;
            sub.Text = "副題";
            question.Text = "パソコンのメモ帳アプリを開く①\n1行目に副題を書く②\n問題と答えを「,」で区切って一行づつ書く③\n例) 日本で一番高い山は何か,富士山\n🎉できあがり④";
        }

        private void HintComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hintComboBox1.SelectedIndex == 0)
            {
                survivalToolStripMenuItem.Enabled = false;
                normalToolStripMenuItem.Enabled = false;
            }
            else if (hintComboBox1.SelectedIndex == 1)
            {
                survivalToolStripMenuItem.Enabled = true;
                normalToolStripMenuItem.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hintComboBox1.SelectedIndex = 1;
            shuffleComboBox1.SelectedIndex = 1;
        }
    }
}