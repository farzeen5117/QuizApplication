namespace QuizApplication
{
    partial class CreateNewQuiz
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
            this.btnCNQBackHome = new System.Windows.Forms.Button();
            this.lblCNQ = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCNQBackHome
            // 
            this.btnCNQBackHome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCNQBackHome.Location = new System.Drawing.Point(22, 16);
            this.btnCNQBackHome.Name = "btnCNQBackHome";
            this.btnCNQBackHome.Size = new System.Drawing.Size(131, 32);
            this.btnCNQBackHome.TabIndex = 0;
            this.btnCNQBackHome.Text = "Back to Home";
            this.btnCNQBackHome.UseVisualStyleBackColor = false;
            // 
            // lblCNQ
            // 
            this.lblCNQ.AutoSize = true;
            this.lblCNQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblCNQ.Location = new System.Drawing.Point(267, 16);
            this.lblCNQ.Name = "lblCNQ";
            this.lblCNQ.Size = new System.Drawing.Size(260, 37);
            this.lblCNQ.TabIndex = 1;
            this.lblCNQ.Text = "Create New Quiz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter Quiz Title Here";
            // 
            // CreateNewQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCNQ);
            this.Controls.Add(this.btnCNQBackHome);
            this.Name = "CreateNewQuiz";
            this.Text = "CreateNewQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCNQBackHome;
        private System.Windows.Forms.Label lblCNQ;
        private System.Windows.Forms.TextBox textBox1;
    }
}