using System;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblTeacherActions_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNewQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateNewQuiz cnq = new CreateNewQuiz();
            cnq.Show();
        }

        private void btnViewExistingQuizzes_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentQuizView_Click(object sender, EventArgs e)
        {
            StudentQuizView sqv = new StudentQuizView();   
            sqv.Show();
        }

        private void btnViewStudentResultsOverTime_Click(object sender, EventArgs e)
        {

        }
    }
}
