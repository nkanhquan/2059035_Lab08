using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exercise02._2
{
    public partial class Form2 : Form
    {
        List<QuestionControl> question = new List<QuestionControl>();
        private QuestionControl quesCtrl;
        int currentQues = 0;

        public Form2()
        {
            InitializeComponent();
            //testTimer1.uscEClock_Exit += new ExamTimer.uscEClock_ExitHandle(uscClock1_uscEClock_Exit);
            //useSetClock1.uscSetClock_Change += new useSetClock.uscSetClock_ChangeHandle(uscSetClock1_uscSetClock_Change);
        }

        void uscClock1_uscEClock_Exit()
        {
            testTimer1.Stop();
            
            bt_Start.Enabled = true;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnSubmit.Enabled = false;
            quesCtrl.Enabled = false;

            //bt_Pause.Enabled = false;
            //bt_Resume.Enabled = false;
            //bt_Stop.Enabled = false;
            //useSetClock1.Enabled = true;
            //useSetClock1._mm = useSetClock1._ss = 0;
            MessageBox.Show("Time's up\n", "Time's up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TotalScore();
            ResetTest();
        }

        public void ReadQuestionFromXML(string path)
        {
            using (var xml = XmlReader.Create(path))
            {
                xml.ReadToFollowing("QuesAndAns");
                while (xml.ReadToFollowing("Question"))
                {
                    QuestionControl tmpCtrl = new QuestionControl();
                    //Question
                    xml.ReadToFollowing("Content");
                    tmpCtrl.Question = xml.ReadElementContentAsString();

                    //Answer
                    //#1
                    xml.ReadToFollowing("Answer");
                    tmpCtrl.Answer1 = xml.ReadElementContentAsString();
                    //#2
                    xml.ReadToFollowing("Answer");
                    tmpCtrl.Answer2 = xml.ReadElementContentAsString();
                    //#3
                    xml.ReadToFollowing("Answer");
                    tmpCtrl.Answer3 = xml.ReadElementContentAsString();
                    //#4
                    xml.ReadToFollowing("Answer");
                    tmpCtrl.Answer4 = xml.ReadElementContentAsString();

                    //Correct answer
                    xml.ReadToFollowing("Correct");
                    tmpCtrl.CorrectAnswer = xml.ReadElementContentAsString();

                    //Question score
                    tmpCtrl.QuestionScore = 1;

                    tmpCtrl.ShuffleAnswer();
                    question.Add(tmpCtrl);
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnSubmit.Enabled = true;
            quesCtrl.Enabled = true;

            //testTimer1
            testTimer1._mm = 10;
            testTimer1._ss = 0;
            //testTimer1._mm = useSetClock1._mm;
            //testTimer1._ss = useSetClock1._ss;
            testTimer1.Start();
            bt_Start.Enabled = false;
            //bt_Pause.Enabled = true;+		
            //bt_Stop.Enabled = true;
            //useSetClock1.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Save answer
            SaveCurrentAnswer();

            //Next question index
            if (currentQues + 1 == question.Count)
                currentQues = 0;
            else
                currentQues++;
            
            //Update the question
            UpdateQuestion(question[currentQues]);

            //Set the question number
            lbNumQues.Text = $"Question {currentQues + 1}";

            //this.Controls.Remove(quesCtrl);
            //QuestionControl quesCtrl1 = question[currentQues];
            //quesCtrl1.Location = new Point(12, 61);
            //quesCtrl1.Size = new Size(557, 219);
            //this.Controls.Add(quesCtrl1);
        }

        private void UpdateQuestion(QuestionControl tmp)
        {
            //quesCtrl.Question = tmp.Question;
            //quesCtrl.Answer1 = tmp.Answer1;
            //quesCtrl.Answer2 = tmp.Answer2;
            //quesCtrl.Answer3 = tmp.Answer3;
            //quesCtrl.Answer4 = tmp.Answer4;

            //quesCtrl = null;
            //this.Controls.Remove(quesCtrl);
            //quesCtrl = tmp;
            //quesCtrl.Update();

            this.Controls.Remove(quesCtrl);
            quesCtrl = null;
            quesCtrl = tmp;
            this.Controls.Add(quesCtrl);
            quesCtrl.Location = new System.Drawing.Point(12, 60);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Save the answer
            SaveCurrentAnswer();

            //Previous index
            if (currentQues - 1 < 0)
                currentQues = question.Count - 1;
            else
                currentQues--;

            //Update the question
            UpdateQuestion(question[currentQues]);
            
            //Set the question number
            lbNumQues.Text = $"Question {currentQues + 1}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Save the current answer
            SaveCurrentAnswer();

            testTimer1.Pause();

            TotalScore();

            ResetTest();
        }

        public void ShuffleTest()
        {
            var rand = new Random();

            for (int i = 0; i < question.Count; ++i)
            {
                int randIndex = rand.Next(0, question.Count);

                //Swap process
                QuestionControl tmp = question[i];
                question[i] = question[randIndex];
                question[randIndex] = tmp;
            }
        }

        public void ShuffleAllAnswer()
        {
            foreach (var i in question)
                i.ShuffleAnswer();
        }

        public void ResetTest()
        {
            testTimer1.ResetTimer(10, 0);
            ShuffleTest();
            ShuffleAllAnswer();
            UpdateQuestion(question[0]);
            currentQues = 0;
            //Reset the question number
            lbNumQues.Text = $"Question {currentQues + 1}";

            bt_Start.Enabled = true;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnSubmit.Enabled = false;
            quesCtrl.Enabled = false;
        }

        private void SaveCurrentAnswer()
        {
            var rBtn = quesCtrl.CheckedButton();

            if (rBtn != null)
                question[currentQues].YourAnswer = rBtn.Text;
            else
                question[currentQues].YourAnswer = "";
        }

        private void TotalScore()
        {
            int sum = 0;
            int num = 0;
            foreach (var i in question)
            {
                if (i.CheckCorrectAnswer())
                {
                    sum += i.QuestionScore;
                    ++num;
                }
            }

            MessageBox.Show($"Your score: {sum}\nYou got {num} out of {question.Count}", "Result", MessageBoxButtons.OK);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            testTimer1._mm = 10;
            testTimer1._ss = 0;

            ReadQuestionFromXML("XMLQuestion.xml");
            ShuffleTest();
            UpdateQuestion(question[0]);

            //Set the question number
            lbNumQues.Text = $"Question {currentQues + 1}";

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnSubmit.Enabled = false;
            quesCtrl.Enabled = false;
        }
    }
}
