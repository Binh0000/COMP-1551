using System.Windows.Forms;

namespace Coursework
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginFormPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginImagePanel = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.loginFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPanel.Controls.Add(this.loginFormPanel);
            this.loginPanel.Controls.Add(this.loginImagePanel);
            this.loginPanel.Location = new System.Drawing.Point(200, 90);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1200, 675);
            this.loginPanel.TabIndex = 0;
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.BackColor = System.Drawing.Color.DimGray;
            this.loginFormPanel.Controls.Add(this.signupBtn);
            this.loginFormPanel.Controls.Add(this.loginButton);
            this.loginFormPanel.Controls.Add(this.passwordTextBox);
            this.loginFormPanel.Controls.Add(this.emailTextBox);
            this.loginFormPanel.Controls.Add(this.label1);
            this.loginFormPanel.Location = new System.Drawing.Point(48, 42);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(663, 585);
            this.loginFormPanel.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(105, 317);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(205, 54);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login\r\n";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(105, 246);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(299, 28);
            this.passwordTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(105, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(299, 28);
            this.emailTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Login\r\n";
            // 
            // loginImagePanel
            // 
            this.loginImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginImagePanel.BackgroundImage")));
            this.loginImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginImagePanel.Location = new System.Drawing.Point(770, 0);
            this.loginImagePanel.Name = "loginImagePanel";
            this.loginImagePanel.Size = new System.Drawing.Size(430, 675);
            this.loginImagePanel.TabIndex = 1;
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupBtn.Location = new System.Drawing.Point(105, 405);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(205, 54);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "Sign-Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1594, 865);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginFormPanel.ResumeLayout(false);
            this.loginFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel loginFormPanel;

        private System.Windows.Forms.Panel loginImagePanel;

        private System.Windows.Forms.Panel loginPanel;

        #endregion

        private Button signupBtn;
    }
}