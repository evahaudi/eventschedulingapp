namespace Schedulingproject
{
    partial class LoginForm
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
            WelcomeText = new Label();
            label2 = new Label();
            label3 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeText.Location = new Point(214, 25);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.RightToLeft = RightToLeft.Yes;
            WelcomeText.Size = new Size(152, 35);
            WelcomeText.TabIndex = 0;
            WelcomeText.Text = "Welcome";
            WelcomeText.TextAlign = ContentAlignment.TopCenter;
            WelcomeText.Click += Welcome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 186);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 97);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Location = new Point(198, 97);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(295, 27);
            UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(198, 179);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(291, 27);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginButton.Location = new Point(198, 303);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(291, 35);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(WelcomeText);
            Name = "LoginForm";
            Text = "==";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeText;
        private Label label2;
        private Label label3;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}
