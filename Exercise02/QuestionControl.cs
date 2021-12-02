using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02._2
{
    public partial class QuestionControl : UserControl
    {
        private string correctAns = "";
        private string urAns = "";
        private int quesScore = 0;
        private List<RadioButton> answer = new List<RadioButton>();

        //Question property
        public string Question
        {
            get { return lbQuestion.Text; }
            set { lbQuestion.Text = value; }
        }

        //Answers properties
        public string Answer1
        {
            get { return rbtnAns1.Text; }
            set { rbtnAns1.Text = value; }
        }

        public string Answer2
        {
            get { return rbtnAns2.Text; }
            set { rbtnAns2.Text = value; }
        }

        public string Answer3
        {
            get { return rbtnAns3.Text; }
            set { rbtnAns3.Text = value; }
        }

        public string Answer4
        {
            get { return rbtnAns4.Text; }
            set { rbtnAns4.Text = value; }
        }


        public string CorrectAnswer
        {
            get { return correctAns; }
            set { correctAns = value; }
        }

        public string YourAnswer
        {
            get { return urAns; }
            set { urAns = value; }
        }

        public int QuestionScore
        {
            get { return quesScore; }
            set { quesScore = value; }
        }

        public QuestionControl()
        {
            InitializeComponent();
            answer.Add(rbtnAns1);
            answer.Add(rbtnAns2);
            answer.Add(rbtnAns3);
            answer.Add(rbtnAns4);
        }


        public bool CheckCorrectAnswer()
        {
            //if (rbtnAns1.Checked)
            //{
            //    return CheckAnswer(rbtnAns1.Text);
            //}
            //if (rbtnAns2.Checked)
            //{
            //    return CheckAnswer(rbtnAns2.Text);
            //}
            //if (rbtnAns3.Checked)
            //{
            //    return CheckAnswer(rbtnAns3.Text);
            //}
            //if (rbtnAns4.Checked)
            //{
            //    return CheckAnswer(rbtnAns4.Text);
            //}

            //return false;

            return CheckAnswer(urAns);
        }

        public bool CheckAnswer(string ans)
        {
            if (ans == CorrectAnswer)
                return true;
            return false;
        }

        public bool CheckAllButton()
        {
            if (!rbtnAns1.Checked && !rbtnAns2.Checked && !rbtnAns3.Checked && !rbtnAns4.Checked)
                return false;
            return true;
        }

        public void ShuffleAnswer()
        {
            var rand = new Random();

            for (int i = 0; i < answer.Count; ++i)
            {
                int randIndex = rand.Next(0, answer.Count);

                //Swap process
                string tmp = answer[i].Text;
                answer[i].Text = answer[randIndex].Text;
                answer[randIndex].Text = tmp;
            }

        }

        public RadioButton CheckedButton()
        {
            return answer.FirstOrDefault(r => r.Checked);
        }
    }
}
