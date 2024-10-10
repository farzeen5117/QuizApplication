using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class SelectQuiz : Form
    {
        public SelectQuiz()
        {
            InitializeComponent();
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            StudentQuizView sqv = new StudentQuizView();
            sqv.Show();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)
        {
            StudentQuizView sqv = new StudentQuizView();
            sqv.Show();
        }

        private void btnQuiz3_Click(object sender, EventArgs e)
        {
            StudentQuizView sqv = new StudentQuizView();
            sqv.Show();
        }
    }
}
