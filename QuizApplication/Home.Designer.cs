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
            this.btnStudentQuizView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewStudentResultsOverTime = new System.Windows.Forms.Button();
            this.btnViewExistingQuizzes = new System.Windows.Forms.Button();
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
            this.btnCreateNewQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(232)))));
            this.btnCreateNewQuiz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateNewQuiz.Location = new System.Drawing.Point(52, 85);
            this.btnCreateNewQuiz.Name = "btnCreateNewQuiz";
            this.btnCreateNewQuiz.Size = new System.Drawing.Size(228, 110);
            this.btnCreateNewQuiz.TabIndex = 1;
            this.btnCreateNewQuiz.Text = "Create New Quiz";
            this.btnCreateNewQuiz.UseVisualStyleBackColor = false;
            this.btnCreateNewQuiz.Click += new System.EventHandler(this.btnCreateNewQuiz_Click);
            // 
            // btnStudentQuizView
            // 
            this.btnStudentQuizView.BackColor = System.Drawing.Color.LightCoral;
            this.btnStudentQuizView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStudentQuizView.Location = new System.Drawing.Point(306, 292);
            this.btnStudentQuizView.Name = "btnStudentQuizView";
            this.btnStudentQuizView.Size = new System.Drawing.Size(228, 110);
            this.btnStudentQuizView.TabIndex = 4;
            this.btnStudentQuizView.Text = "Select Quiz To Take";
            this.btnStudentQuizView.UseVisualStyleBackColor = false;
            this.btnStudentQuizView.Click += new System.EventHandler(this.btnStudentQuizView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Actions:";
            // 
            // btnViewStudentResultsOverTime
            // 
            this.btnViewStudentResultsOverTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(232)))));
            this.btnViewStudentResultsOverTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewStudentResultsOverTime.Location = new System.Drawing.Point(560, 85);
            this.btnViewStudentResultsOverTime.Name = "btnViewStudentResultsOverTime";
            this.btnViewStudentResultsOverTime.Size = new System.Drawing.Size(228, 110);
            this.btnViewStudentResultsOverTime.TabIndex = 3;
            this.btnViewStudentResultsOverTime.Text = "View Student Results Over Time";
            this.btnViewStudentResultsOverTime.UseVisualStyleBackColor = false;
            this.btnViewStudentResultsOverTime.Click += new System.EventHandler(this.btnViewStudentResultsOverTime_Click);
            // 
            // btnViewExistingQuizzes
            // 
            this.btnViewExistingQuizzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(232)))));
            this.btnViewExistingQuizzes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewExistingQuizzes.Location = new System.Drawing.Point(306, 85);
            this.btnViewExistingQuizzes.Name = "btnViewExistingQuizzes";
            this.btnViewExistingQuizzes.Size = new System.Drawing.Size(228, 110);
            this.btnViewExistingQuizzes.TabIndex = 2;
            this.btnViewExistingQuizzes.Text = "View Existing Quizzes";
            this.btnViewExistingQuizzes.UseVisualStyleBackColor = false;
            this.btnViewExistingQuizzes.Click += new System.EventHandler(this.btnViewExistingQuizzes_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudentQuizView);
            this.Controls.Add(this.btnViewStudentResultsOverTime);
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
        private System.Windows.Forms.Button btnStudentQuizView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewStudentResultsOverTime;
        private System.Windows.Forms.Button btnViewExistingQuizzes;
    }
}