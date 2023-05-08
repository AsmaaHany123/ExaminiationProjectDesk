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

namespace ExaminationSytem.InstructorUC
{
    public partial class MakeExam : UserControl
    {
        DataContext dataContext=new DataContext();
        public MakeExam()
        {
            InitializeComponent();
            int courseid = dataContext.Courses.Where(c => c.Instructor.Username == LoginForm.CurrentUserName).Select(i => i.Id).FirstOrDefault();
            dataGridView1.DataSource = dataContext.QuestionPool.Where(i => i.CourseId == courseid).ToList();
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {

            //bool x = (bool)dataGridView1.Rows[0].Cells[0].Value;
            //textBox1.Text = x.ToString();
            //int courseid = dataContext.Courses.Where(c => c.Instructor.Username == LoginForm.CurrentUserName).Select(i => i.Id).FirstOrDefault();
            //int insID = dataContext.Courses.Where(c => c.Instructor.Username == LoginForm.CurrentUserName).Select(i => i.InstructorId).FirstOrDefault();
            //textBox1.Text=insID.ToString();
            //Course course = dataContext.Courses.Where(c=>c.Id==courseid).FirstOrDefault();
            //Instructor ins = dataContext.Instructors.Where(c => c.Username == LoginForm.CurrentUserName).FirstOrDefault();
            //Exam exam =new Exam() {TotalTime= numericUpDown1.Value.ToString(),CourseId=course,InstructorId=ins};
            //dataContext.Exams.Add(exam);
            //dataContext.SaveChanges();
            //for (int i = 1;i<= dataGridView1.Rows.Count; i++)
            //{
            //    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
            //    {
            //        int QId= (int)dataGridView1.Rows[i].Cells[1].Value;
            //        QuestionPool q=dataContext.QuestionPool.FirstOrDefault(c=>c.Id== QId);
            //        dataContext.Exams.Include("questionsId").FirstOrDefault(x => x.Id == exam.Id).questionsId.Add(q);
            //        dataContext.SaveChanges();
            //    }
            //}
            //var Qid = dataGridView1.SelectedRows[0].Cells[0].Value;
            //textBox1.Text = Qid.ToString();
            //  int Stid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

        }

        private void btn_RandomExam_Click(object sender, EventArgs e)
        {
            int courseid = dataContext.Courses.Where(c => c.Instructor.Username == LoginForm.CurrentUserName).Select(x => x.Id).FirstOrDefault();
            List<int>QIds= dataContext.QuestionPool.Where(x => x.CourseId == courseid).Select(x=>x.Id).ToList();
            Random random= new Random();

            if (numericUpDown2.Value <= QIds.Count)
            {
                Course course = dataContext.Courses.Where(c=>c.Id==courseid).FirstOrDefault();
                Instructor ins = dataContext.Instructors.Where(c => c.Username == LoginForm.CurrentUserName).FirstOrDefault();
                Exam exam =new Exam() {TotalTime= numericUpDown1.Value.ToString(),CourseId=course,InstructorId=ins};
                dataContext.Exams.Add(exam);
                dataContext.SaveChanges();

                List<int> l = new List<int>();
                for (int i = 1; i <= numericUpDown2.Value; i++)
                { 
                    int QId;
                    do
                    {
                        QId = random.Next(QIds.Count);
                    } while (l.Contains(QId));
                    l.Add(QId);
                    QuestionPool q = dataContext.QuestionPool.FirstOrDefault(c => c.Id == QId);
                    dataContext.Exams.Include("questionsId").FirstOrDefault(x => x.Id == exam.Id).questionsId.Add(q);
                    dataContext.SaveChanges();
                }
                textBox1.Text=exam.Id.ToString();
            }
        }
    }
}
