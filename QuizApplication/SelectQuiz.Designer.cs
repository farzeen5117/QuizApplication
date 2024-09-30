namespace QuizApplication
{
    partial class SelectQuiz
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
            this.btnQuiz1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuiz2 = new System.Windows.Forms.Button();
            this.btnQuiz3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuiz1
            // 
            this.btnQuiz1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuiz1.Location = new System.Drawing.Point(275, 114);
            this.btnQuiz1.Name = "btnQuiz1";
            this.btnQuiz1.Size = new System.Drawing.Size(188, 90);
            this.btnQuiz1.TabIndex = 0;
            this.btnQuiz1.Text = "Quiz 1: Review of Number Bases and Boolean Logic";
            this.btnQuiz1.UseVisualStyleBackColor = false;
            this.btnQuiz1.Click += new System.EventHandler(this.btnQuiz1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(195, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which quiz would you like to take?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnQuiz2
            // 
            this.btnQuiz2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuiz2.Location = new System.Drawing.Point(275, 210);
            this.btnQuiz2.Name = "btnQuiz2";
            this.btnQuiz2.Size = new System.Drawing.Size(188, 90);
            this.btnQuiz2.TabIndex = 2;
            this.btnQuiz2.Text = "Quiz 2: Basics of CS";
            this.btnQuiz2.UseVisualStyleBackColor = false;
            this.btnQuiz2.Click += new System.EventHandler(this.btnQuiz2_Click);
            // 
            // btnQuiz3
            // 
            this.btnQuiz3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuiz3.Location = new System.Drawing.Point(275, 306);
            this.btnQuiz3.Name = "btnQuiz3";
            this.btnQuiz3.Size = new System.Drawing.Size(188, 90);
            this.btnQuiz3.TabIndex = 3;
            this.btnQuiz3.Text = "Quiz 3: UML Diagrams";
            this.btnQuiz3.UseVisualStyleBackColor = false;
            this.btnQuiz3.Click += new System.EventHandler(this.btnQuiz3_Click);
            // 
            // SelectQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuiz3);
            this.Controls.Add(this.btnQuiz2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuiz1);
            this.Name = "SelectQuiz";
            this.Text = "SelectQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuiz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuiz2;
        private System.Windows.Forms.Button btnQuiz3;
    }
}