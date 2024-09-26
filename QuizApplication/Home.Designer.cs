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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(315, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 110);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create New Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnViewExistingQuizzes_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}