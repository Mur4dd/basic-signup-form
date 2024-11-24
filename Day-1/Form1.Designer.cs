namespace Day_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mailBox = new TextBox();
            passBox = new TextBox();
            signInButton = new Button();
            panel1 = new Panel();
            result = new Label();
            gender = new Label();
            anyCheck = new RadioButton();
            manCheck = new RadioButton();
            womanCheck = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(228, 134);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "E-mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(228, 197);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // mailBox
            // 
            mailBox.Location = new Point(341, 139);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(184, 23);
            mailBox.TabIndex = 3;
            // 
            // passBox
            // 
            passBox.Location = new Point(341, 202);
            passBox.Name = "passBox";
            passBox.Size = new Size(184, 23);
            passBox.TabIndex = 4;
            // 
            // signInButton
            // 
            signInButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            signInButton.ForeColor = Color.DarkBlue;
            signInButton.Location = new Point(228, 308);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(297, 39);
            signInButton.TabIndex = 5;
            signInButton.Text = "Sign Up";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(result);
            panel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.DarkBlue;
            panel1.Location = new Point(12, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 167);
            panel1.TabIndex = 6;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(293, 52);
            result.Name = "result";
            result.Size = new Size(0, 25);
            result.TabIndex = 0;
            result.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.ForeColor = Color.White;
            gender.Location = new Point(228, 248);
            gender.Name = "gender";
            gender.Size = new Size(88, 25);
            gender.TabIndex = 7;
            gender.Text = "Gender :";
            // 
            // anyCheck
            // 
            anyCheck.AutoSize = true;
            anyCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            anyCheck.ForeColor = Color.White;
            anyCheck.Location = new Point(479, 254);
            anyCheck.Name = "anyCheck";
            anyCheck.Size = new Size(46, 19);
            anyCheck.TabIndex = 10;
            anyCheck.TabStop = true;
            anyCheck.Text = "Any";
            anyCheck.UseVisualStyleBackColor = true;
            // 
            // manCheck
            // 
            manCheck.AutoSize = true;
            manCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manCheck.ForeColor = Color.White;
            manCheck.Location = new Point(341, 254);
            manCheck.Name = "manCheck";
            manCheck.Size = new Size(49, 19);
            manCheck.TabIndex = 11;
            manCheck.TabStop = true;
            manCheck.Text = "Man";
            manCheck.UseVisualStyleBackColor = true;
            // 
            // womanCheck
            // 
            womanCheck.AutoSize = true;
            womanCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            womanCheck.ForeColor = Color.White;
            womanCheck.Location = new Point(396, 254);
            womanCheck.Name = "womanCheck";
            womanCheck.Size = new Size(68, 19);
            womanCheck.TabIndex = 12;
            womanCheck.TabStop = true;
            womanCheck.Text = "Woman";
            womanCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 580);
            Controls.Add(womanCheck);
            Controls.Add(manCheck);
            Controls.Add(anyCheck);
            Controls.Add(gender);
            Controls.Add(panel1);
            Controls.Add(signInButton);
            Controls.Add(passBox);
            Controls.Add(mailBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox mailBox;
        private TextBox passBox;
        private Button signInButton;
        private Panel panel1;
        private Label result;
        private Label gender;
        private RadioButton anyCheck;
        private RadioButton manCheck;
        private RadioButton womanCheck;
    }
}
