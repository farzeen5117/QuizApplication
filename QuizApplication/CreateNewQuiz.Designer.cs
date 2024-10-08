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
            this.txtCNQQuizTitle = new System.Windows.Forms.TextBox();
            this.btnCreateMCQ = new System.Windows.Forms.Button();
            this.txtMCQQuestion = new System.Windows.Forms.TextBox();
            this.txtMCQOpA = new System.Windows.Forms.TextBox();
            this.txtMQOpB = new System.Windows.Forms.TextBox();
            this.txtMCQOpC = new System.Windows.Forms.TextBox();
            this.txtMCQOpD = new System.Windows.Forms.TextBox();
            this.rdbtnMCQ = new System.Windows.Forms.RadioButton();
            this.rdbtnFRQ = new System.Windows.Forms.RadioButton();
            this.txtFRQOpD = new System.Windows.Forms.TextBox();
            this.txtFRQOpC = new System.Windows.Forms.TextBox();
            this.txtFRQOpB = new System.Windows.Forms.TextBox();
            this.txtFRQOpA = new System.Windows.Forms.TextBox();
            this.txtFRQQuestion = new System.Windows.Forms.TextBox();
            this.btnCreateFRQ = new System.Windows.Forms.Button();
            this.chkbxMCQCorrectA = new System.Windows.Forms.CheckBox();
            this.chkbxMCQCorrectB = new System.Windows.Forms.CheckBox();
            this.chkbxMCQCorrectC = new System.Windows.Forms.CheckBox();
            this.chkbxMCQCorrectD = new System.Windows.Forms.CheckBox();
            this.chkbxFRQCorrectD = new System.Windows.Forms.CheckBox();
            this.chkbxFRQCorrectC = new System.Windows.Forms.CheckBox();
            this.chkbxFRQCorrectB = new System.Windows.Forms.CheckBox();
            this.chkbxFRQCorrectA = new System.Windows.Forms.CheckBox();
            this.btnCNQSave = new System.Windows.Forms.Button();
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
            // txtCNQQuizTitle
            // 
            this.txtCNQQuizTitle.Location = new System.Drawing.Point(274, 79);
            this.txtCNQQuizTitle.Name = "txtCNQQuizTitle";
            this.txtCNQQuizTitle.Size = new System.Drawing.Size(253, 20);
            this.txtCNQQuizTitle.TabIndex = 2;
            this.txtCNQQuizTitle.Text = "Enter Quiz Title Here";
            // 
            // btnCreateMCQ
            // 
            this.btnCreateMCQ.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCreateMCQ.Location = new System.Drawing.Point(144, 115);
            this.btnCreateMCQ.Name = "btnCreateMCQ";
            this.btnCreateMCQ.Size = new System.Drawing.Size(155, 51);
            this.btnCreateMCQ.TabIndex = 3;
            this.btnCreateMCQ.Text = "Selected Question Type: Multiple Choice";
            this.btnCreateMCQ.UseVisualStyleBackColor = false;
            // 
            // txtMCQQuestion
            // 
            this.txtMCQQuestion.Location = new System.Drawing.Point(144, 181);
            this.txtMCQQuestion.Name = "txtMCQQuestion";
            this.txtMCQQuestion.ReadOnly = true;
            this.txtMCQQuestion.Size = new System.Drawing.Size(154, 20);
            this.txtMCQQuestion.TabIndex = 4;
            this.txtMCQQuestion.Text = "Type Question Here";
            // 
            // txtMCQOpA
            // 
            this.txtMCQOpA.Location = new System.Drawing.Point(143, 226);
            this.txtMCQOpA.Name = "txtMCQOpA";
            this.txtMCQOpA.ReadOnly = true;
            this.txtMCQOpA.Size = new System.Drawing.Size(154, 20);
            this.txtMCQOpA.TabIndex = 5;
            this.txtMCQOpA.Text = "A) Type Option Here";
            // 
            // txtMQOpB
            // 
            this.txtMQOpB.Location = new System.Drawing.Point(143, 252);
            this.txtMQOpB.Name = "txtMQOpB";
            this.txtMQOpB.ReadOnly = true;
            this.txtMQOpB.Size = new System.Drawing.Size(154, 20);
            this.txtMQOpB.TabIndex = 6;
            this.txtMQOpB.Text = "B) Type Option Here";
            // 
            // txtMCQOpC
            // 
            this.txtMCQOpC.Location = new System.Drawing.Point(144, 278);
            this.txtMCQOpC.Name = "txtMCQOpC";
            this.txtMCQOpC.ReadOnly = true;
            this.txtMCQOpC.Size = new System.Drawing.Size(154, 20);
            this.txtMCQOpC.TabIndex = 7;
            this.txtMCQOpC.Text = "C) Type Option Here";
            // 
            // txtMCQOpD
            // 
            this.txtMCQOpD.Location = new System.Drawing.Point(143, 304);
            this.txtMCQOpD.Name = "txtMCQOpD";
            this.txtMCQOpD.ReadOnly = true;
            this.txtMCQOpD.Size = new System.Drawing.Size(154, 20);
            this.txtMCQOpD.TabIndex = 8;
            this.txtMCQOpD.Text = "D) Type Option Here";
            // 
            // rdbtnMCQ
            // 
            this.rdbtnMCQ.AutoSize = true;
            this.rdbtnMCQ.Location = new System.Drawing.Point(121, 132);
            this.rdbtnMCQ.Name = "rdbtnMCQ";
            this.rdbtnMCQ.Size = new System.Drawing.Size(14, 13);
            this.rdbtnMCQ.TabIndex = 9;
            this.rdbtnMCQ.TabStop = true;
            this.rdbtnMCQ.UseVisualStyleBackColor = true;
            this.rdbtnMCQ.CheckedChanged += new System.EventHandler(this.rdbtnMCQ_CheckedChanged);
            // 
            // rdbtnFRQ
            // 
            this.rdbtnFRQ.AutoSize = true;
            this.rdbtnFRQ.Location = new System.Drawing.Point(445, 132);
            this.rdbtnFRQ.Name = "rdbtnFRQ";
            this.rdbtnFRQ.Size = new System.Drawing.Size(14, 13);
            this.rdbtnFRQ.TabIndex = 16;
            this.rdbtnFRQ.TabStop = true;
            this.rdbtnFRQ.UseVisualStyleBackColor = true;
            // 
            // txtFRQOpD
            // 
            this.txtFRQOpD.Location = new System.Drawing.Point(468, 304);
            this.txtFRQOpD.Name = "txtFRQOpD";
            this.txtFRQOpD.ReadOnly = true;
            this.txtFRQOpD.Size = new System.Drawing.Size(154, 20);
            this.txtFRQOpD.TabIndex = 15;
            this.txtFRQOpD.Text = "D) Type Option Here";
            // 
            // txtFRQOpC
            // 
            this.txtFRQOpC.Location = new System.Drawing.Point(469, 278);
            this.txtFRQOpC.Name = "txtFRQOpC";
            this.txtFRQOpC.ReadOnly = true;
            this.txtFRQOpC.Size = new System.Drawing.Size(154, 20);
            this.txtFRQOpC.TabIndex = 14;
            this.txtFRQOpC.Text = "C) Type Option Here";
            // 
            // txtFRQOpB
            // 
            this.txtFRQOpB.Location = new System.Drawing.Point(468, 252);
            this.txtFRQOpB.Name = "txtFRQOpB";
            this.txtFRQOpB.ReadOnly = true;
            this.txtFRQOpB.Size = new System.Drawing.Size(154, 20);
            this.txtFRQOpB.TabIndex = 13;
            this.txtFRQOpB.Text = "B) Type Option Here";
            // 
            // txtFRQOpA
            // 
            this.txtFRQOpA.Location = new System.Drawing.Point(468, 226);
            this.txtFRQOpA.Name = "txtFRQOpA";
            this.txtFRQOpA.ReadOnly = true;
            this.txtFRQOpA.Size = new System.Drawing.Size(154, 20);
            this.txtFRQOpA.TabIndex = 12;
            this.txtFRQOpA.Text = "A) Type Option Here";
            // 
            // txtFRQQuestion
            // 
            this.txtFRQQuestion.Location = new System.Drawing.Point(469, 181);
            this.txtFRQQuestion.Name = "txtFRQQuestion";
            this.txtFRQQuestion.ReadOnly = true;
            this.txtFRQQuestion.Size = new System.Drawing.Size(154, 20);
            this.txtFRQQuestion.TabIndex = 11;
            this.txtFRQQuestion.Text = "Type Question Here";
            // 
            // btnCreateFRQ
            // 
            this.btnCreateFRQ.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCreateFRQ.Location = new System.Drawing.Point(469, 115);
            this.btnCreateFRQ.Name = "btnCreateFRQ";
            this.btnCreateFRQ.Size = new System.Drawing.Size(155, 51);
            this.btnCreateFRQ.TabIndex = 10;
            this.btnCreateFRQ.Text = "Selected Question Type: Free Response";
            this.btnCreateFRQ.UseVisualStyleBackColor = false;
            // 
            // chkbxMCQCorrectA
            // 
            this.chkbxMCQCorrectA.AutoSize = true;
            this.chkbxMCQCorrectA.Location = new System.Drawing.Point(304, 228);
            this.chkbxMCQCorrectA.Name = "chkbxMCQCorrectA";
            this.chkbxMCQCorrectA.Size = new System.Drawing.Size(104, 17);
            this.chkbxMCQCorrectA.TabIndex = 17;
            this.chkbxMCQCorrectA.Text = "Correct Answer?";
            this.chkbxMCQCorrectA.UseVisualStyleBackColor = true;
            // 
            // chkbxMCQCorrectB
            // 
            this.chkbxMCQCorrectB.AutoSize = true;
            this.chkbxMCQCorrectB.Location = new System.Drawing.Point(304, 254);
            this.chkbxMCQCorrectB.Name = "chkbxMCQCorrectB";
            this.chkbxMCQCorrectB.Size = new System.Drawing.Size(104, 17);
            this.chkbxMCQCorrectB.TabIndex = 18;
            this.chkbxMCQCorrectB.Text = "Correct Answer?";
            this.chkbxMCQCorrectB.UseVisualStyleBackColor = true;
            // 
            // chkbxMCQCorrectC
            // 
            this.chkbxMCQCorrectC.AutoSize = true;
            this.chkbxMCQCorrectC.Location = new System.Drawing.Point(304, 280);
            this.chkbxMCQCorrectC.Name = "chkbxMCQCorrectC";
            this.chkbxMCQCorrectC.Size = new System.Drawing.Size(104, 17);
            this.chkbxMCQCorrectC.TabIndex = 19;
            this.chkbxMCQCorrectC.Text = "Correct Answer?";
            this.chkbxMCQCorrectC.UseVisualStyleBackColor = true;
            // 
            // chkbxMCQCorrectD
            // 
            this.chkbxMCQCorrectD.AutoSize = true;
            this.chkbxMCQCorrectD.Location = new System.Drawing.Point(304, 307);
            this.chkbxMCQCorrectD.Name = "chkbxMCQCorrectD";
            this.chkbxMCQCorrectD.Size = new System.Drawing.Size(104, 17);
            this.chkbxMCQCorrectD.TabIndex = 20;
            this.chkbxMCQCorrectD.Text = "Correct Answer?";
            this.chkbxMCQCorrectD.UseVisualStyleBackColor = true;
            // 
            // chkbxFRQCorrectD
            // 
            this.chkbxFRQCorrectD.AutoSize = true;
            this.chkbxFRQCorrectD.Location = new System.Drawing.Point(628, 307);
            this.chkbxFRQCorrectD.Name = "chkbxFRQCorrectD";
            this.chkbxFRQCorrectD.Size = new System.Drawing.Size(104, 17);
            this.chkbxFRQCorrectD.TabIndex = 24;
            this.chkbxFRQCorrectD.Text = "Correct Answer?";
            this.chkbxFRQCorrectD.UseVisualStyleBackColor = true;
            // 
            // chkbxFRQCorrectC
            // 
            this.chkbxFRQCorrectC.AutoSize = true;
            this.chkbxFRQCorrectC.Location = new System.Drawing.Point(628, 280);
            this.chkbxFRQCorrectC.Name = "chkbxFRQCorrectC";
            this.chkbxFRQCorrectC.Size = new System.Drawing.Size(104, 17);
            this.chkbxFRQCorrectC.TabIndex = 23;
            this.chkbxFRQCorrectC.Text = "Correct Answer?";
            this.chkbxFRQCorrectC.UseVisualStyleBackColor = true;
            // 
            // chkbxFRQCorrectB
            // 
            this.chkbxFRQCorrectB.AutoSize = true;
            this.chkbxFRQCorrectB.Location = new System.Drawing.Point(628, 254);
            this.chkbxFRQCorrectB.Name = "chkbxFRQCorrectB";
            this.chkbxFRQCorrectB.Size = new System.Drawing.Size(104, 17);
            this.chkbxFRQCorrectB.TabIndex = 22;
            this.chkbxFRQCorrectB.Text = "Correct Answer?";
            this.chkbxFRQCorrectB.UseVisualStyleBackColor = true;
            // 
            // chkbxFRQCorrectA
            // 
            this.chkbxFRQCorrectA.AutoSize = true;
            this.chkbxFRQCorrectA.Location = new System.Drawing.Point(628, 228);
            this.chkbxFRQCorrectA.Name = "chkbxFRQCorrectA";
            this.chkbxFRQCorrectA.Size = new System.Drawing.Size(104, 17);
            this.chkbxFRQCorrectA.TabIndex = 21;
            this.chkbxFRQCorrectA.Text = "Correct Answer?";
            this.chkbxFRQCorrectA.UseVisualStyleBackColor = true;
            // 
            // btnCNQSave
            // 
            this.btnCNQSave.BackColor = System.Drawing.Color.Orange;
            this.btnCNQSave.Location = new System.Drawing.Point(651, 390);
            this.btnCNQSave.Name = "btnCNQSave";
            this.btnCNQSave.Size = new System.Drawing.Size(137, 48);
            this.btnCNQSave.TabIndex = 25;
            this.btnCNQSave.Text = "Save";
            this.btnCNQSave.UseVisualStyleBackColor = false;
            // 
            // CreateNewQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCNQSave);
            this.Controls.Add(this.chkbxFRQCorrectD);
            this.Controls.Add(this.chkbxFRQCorrectC);
            this.Controls.Add(this.chkbxFRQCorrectB);
            this.Controls.Add(this.chkbxFRQCorrectA);
            this.Controls.Add(this.chkbxMCQCorrectD);
            this.Controls.Add(this.chkbxMCQCorrectC);
            this.Controls.Add(this.chkbxMCQCorrectB);
            this.Controls.Add(this.chkbxMCQCorrectA);
            this.Controls.Add(this.rdbtnFRQ);
            this.Controls.Add(this.txtFRQOpD);
            this.Controls.Add(this.txtFRQOpC);
            this.Controls.Add(this.txtFRQOpB);
            this.Controls.Add(this.txtFRQOpA);
            this.Controls.Add(this.txtFRQQuestion);
            this.Controls.Add(this.btnCreateFRQ);
            this.Controls.Add(this.rdbtnMCQ);
            this.Controls.Add(this.txtMCQOpD);
            this.Controls.Add(this.txtMCQOpC);
            this.Controls.Add(this.txtMQOpB);
            this.Controls.Add(this.txtMCQOpA);
            this.Controls.Add(this.txtMCQQuestion);
            this.Controls.Add(this.btnCreateMCQ);
            this.Controls.Add(this.txtCNQQuizTitle);
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
        private System.Windows.Forms.TextBox txtCNQQuizTitle;
        private System.Windows.Forms.Button btnCreateMCQ;
        private System.Windows.Forms.TextBox txtMCQQuestion;
        private System.Windows.Forms.TextBox txtMCQOpA;
        private System.Windows.Forms.TextBox txtMQOpB;
        private System.Windows.Forms.TextBox txtMCQOpC;
        private System.Windows.Forms.TextBox txtMCQOpD;
        private System.Windows.Forms.RadioButton rdbtnMCQ;
        private System.Windows.Forms.RadioButton rdbtnFRQ;
        private System.Windows.Forms.TextBox txtFRQOpD;
        private System.Windows.Forms.TextBox txtFRQOpC;
        private System.Windows.Forms.TextBox txtFRQOpB;
        private System.Windows.Forms.TextBox txtFRQOpA;
        private System.Windows.Forms.TextBox txtFRQQuestion;
        private System.Windows.Forms.Button btnCreateFRQ;
        private System.Windows.Forms.CheckBox chkbxMCQCorrectA;
        private System.Windows.Forms.CheckBox chkbxMCQCorrectB;
        private System.Windows.Forms.CheckBox chkbxMCQCorrectC;
        private System.Windows.Forms.CheckBox chkbxMCQCorrectD;
        private System.Windows.Forms.CheckBox chkbxFRQCorrectD;
        private System.Windows.Forms.CheckBox chkbxFRQCorrectC;
        private System.Windows.Forms.CheckBox chkbxFRQCorrectB;
        private System.Windows.Forms.CheckBox chkbxFRQCorrectA;
        private System.Windows.Forms.Button btnCNQSave;
    }
}