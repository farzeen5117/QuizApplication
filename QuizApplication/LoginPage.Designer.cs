namespace QuizApplication
{
    partial class LoginPage
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
            this.btnQuizView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuizView
            // 
            this.btnQuizView.Location = new System.Drawing.Point(315, 267);
            this.btnQuizView.Name = "btnQuizView";
            this.btnQuizView.Size = new System.Drawing.Size(181, 73);
            this.btnQuizView.TabIndex = 0;
            this.btnQuizView.Text = "Quiz View";
            this.btnQuizView.UseVisualStyleBackColor = true;
            this.btnQuizView.Click += new System.EventHandler(this.btnQuizView_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuizView);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuizView;
    }
}

