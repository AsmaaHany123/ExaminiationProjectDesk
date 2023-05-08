using ExaminationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSytem
{
    public partial class ExamForm : Form
    {
        DataContext datacontext=new DataContext();
        questionsForm1 questionsform1= new questionsForm1();
        questionForm2 questionform2= new questionForm2();
        public ExamForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        int minutes = 2;
        int seconds = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            if (minutes == 0 && seconds == 0)
            {
                timer1.Stop();
                timing.Text = "00:00";
                MessageBox.Show("Time is out", "Exam Finish", MessageBoxButtons.OK);
            }

            if (seconds == 0 && minutes != 0)
            {
                seconds = 60;
                minutes -= 1;
            }
            string minutesSrting = minutes.ToString();
            string secondsSrting = seconds.ToString();
            string time = "Time: " + minutesSrting + ":" + secondsSrting;
            timing.Text = time;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            openChildForm(questionsform1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            openChildForm(questionform2);
            btnNext.Enabled = false;
            btnNext.Visible = false;
            btnBack.Visible = true;
            btnSubmit.Visible = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            openChildForm(questionsform1);
            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnBack.Visible = false;
            btnSubmit.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            questionsform1.Score1();
            questionform2.Score2();
            foreach (var item in questionForm2.stans)
            {
                MessageBox.Show(item);
            }
            foreach (var item in questionForm2.qids)
            {
                MessageBox.Show(item.ToString());
            }
            //var stid=datacontext.StExams.Where(i=>i.StId==1).FirstOrDefault();
            //var exid=datacontext.StExams
            for (int i = 0; i < questionsForm1.qids.Count; i++)
            {
                var x = (from st in datacontext.StExams.ToList()
                         where st.StId == 1 & st.ExId == 1 & st.QId == questionsForm1.qids[i]
                         select st).FirstOrDefault();
                x.StAnswer = questionsForm1.stans[i];
                //datacontext.StExams.Add(x);
            datacontext.SaveChanges();
                var t = questionsForm1.qids[i];
                if (x.StAnswer == datacontext.QuestionPool.Where(h => h.Id == t).Select(h => h.CorrectAns).FirstOrDefault())
                {
                    x.StScore = 1;
                }
                else
                {
                    x.StScore = 0;
                }
                datacontext.SaveChanges();
            }

            for (int i = 0; i < questionForm2.qids.Count; i++)
            {
                var x = (from st in datacontext.StExams.ToList()
                         where st.StId == 1 & st.ExId == 1 & st.QId == questionForm2.qids[i]
                         select st).FirstOrDefault();
                x.StAnswer = questionForm2.stans[i];
                //datacontext.StExams.Add(x);
                datacontext.SaveChanges();
                var t = questionForm2.qids[i];
                if (x.StAnswer == datacontext.QuestionPool.Where(h => h.Id == t).Select(h => h.CorrectAns).FirstOrDefault())
                {
                    x.StScore = 1;
                }
                else
                {
                    x.StScore = 0;
                }
                datacontext.SaveChanges();
            }

            var query = datacontext.StExams.Where(s => s.ExId == 1).Where(s => s.StId == 1).Select(s => s.StScore);
            MessageBox.Show(query.Sum().ToString());
            Application.Exit();

        }
    }
}
