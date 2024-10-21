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
    public partial class StudentQuizView : Form
    {
        public StudentQuizView()
        {
            InitializeComponent();
        }

        private void StudentQuizView_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Sp1 = new Home();
            Sp1.Show();

        }
    }
}
