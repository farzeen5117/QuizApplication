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
            txtMCQQuestion.ReadOnly = false;
            txtMCQOpA.ReadOnly = false;
            txtMQOpB.ReadOnly = false;
            txtMCQOpC.ReadOnly = false;
            txtMCQOpD.ReadOnly = false;

            txtFRQQuestion.ReadOnly = true;
            txtFRQOpA.ReadOnly = true;
            txtFRQOpB.ReadOnly = true;
            txtFRQOpC.ReadOnly = true;
            txtFRQOpD.ReadOnly = true;
        }

        private void btnCNQBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void rdbtnFRQ_CheckedChanged(object sender, EventArgs e)
        {
            txtFRQQuestion.ReadOnly = false;
            txtFRQOpA.ReadOnly = false;
            txtFRQOpB.ReadOnly = false;
            txtFRQOpC.ReadOnly = false;
            txtFRQOpD.ReadOnly = false;

            txtMCQQuestion.ReadOnly = true;
            txtMCQOpA.ReadOnly = true;
            txtMQOpB.ReadOnly = true;
            txtMCQOpC.ReadOnly = true;
            txtMCQOpD.ReadOnly = true;
        }

        private void btnCNQSave_Click(object sender, EventArgs e)
        {

        }

        private void txtMCQOpA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
