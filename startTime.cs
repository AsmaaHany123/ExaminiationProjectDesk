using ExaminationSytem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class startTime : Form
    {
        public startTime()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();
            this.Close();   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
