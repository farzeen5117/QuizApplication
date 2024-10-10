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
    public partial class CreateNewQuiz : Form
    {
        public CreateNewQuiz()
        {
            InitializeComponent();
        }

        private void rdbtnMCQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCNQBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
