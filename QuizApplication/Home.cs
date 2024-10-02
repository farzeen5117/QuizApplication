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
            CreateNewQuiz cnq = new CreateNewQuiz();
            cnq.Show();
        }

        private void btnViewExistingQuizzes_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentQuizView_Click(object sender, EventArgs e)
        {
            SelectQuiz sq = new SelectQuiz();   
            sq.Show();
        }

        private void btnViewStudentResultsOverTime_Click(object sender, EventArgs e)
        {

        }
    }
}
