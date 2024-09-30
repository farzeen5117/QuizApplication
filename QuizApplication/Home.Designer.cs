namespace QuizApplication
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTeacherActions = new System.Windows.Forms.Label();
            this.btnCreateNewQuiz = new System.Windows.Forms.Button();
            this.btnViewExistingQuizzes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeacherActions
            // 
            this.lblTeacherActions.AutoSize = true;
            this.lblTeacherActions.Location = new System.Drawing.Point(49, 48);
            this.lblTeacherActions.Name = "lblTeacherActions";
            this.lblTeacherActions.Size = new System.Drawing.Size(88, 13);
            this.lblTeacherActions.TabIndex = 0;
            this.lblTeacherActions.Text = "Teacher Actions:";
            this.lblTeacherActions.Click += new System.EventHandler(this.lblTeacherActions_Click);
            // 
            // btnCreateNewQuiz
            // 
            this.btnCreateNewQuiz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateNewQuiz.Location = new System.Drawing.Point(52, 85);
            this.btnCreateNewQuiz.Name = "btnCreateNewQuiz";
            this.btnCreateNewQuiz.Size = new System.Drawing.Size(228, 110);
            this.btnCreateNewQuiz.TabIndex = 1;
            this.btnCreateNewQuiz.Text = "Create New Quiz";
            this.btnCreateNewQuiz.UseVisualStyleBackColor = true;
            this.btnCreateNewQuiz.Click += new System.EventHandler(this.btnCreateNewQuiz_Click);
            // 
            // btnViewExistingQuizzes
            // 
            this.btnViewExistingQuizzes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewExistingQuizzes.Location = new System.Drawing.Point(306, 85);
            this.btnViewExistingQuizzes.Name = "btnViewExistingQuizzes";
            this.btnViewExistingQuizzes.Size = new System.Drawing.Size(228, 110);
            this.btnViewExistingQuizzes.TabIndex = 2;
            this.btnViewExistingQuizzes.Text = "View Existing Quizzes";
            this.btnViewExistingQuizzes.UseVisualStyleBackColor = true;
            this.btnViewExistingQuizzes.Click += new System.EventHandler(this.btnViewExistingQuizzes_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(560, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 110);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Existing Quizzes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(306, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 110);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select Quiz To Take";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnViewExistingQuizzes);
            this.Controls.Add(this.btnCreateNewQuiz);
            this.Controls.Add(this.lblTeacherActions);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherActions;
        private System.Windows.Forms.Button btnCreateNewQuiz;
        private System.Windows.Forms.Button btnViewExistingQuizzes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}