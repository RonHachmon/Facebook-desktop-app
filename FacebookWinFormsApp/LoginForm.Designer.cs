namespace BasicFacebookFeatures
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.headlineBluePanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.logoBackgroundPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.formatedStatusesCheckBox = new System.Windows.Forms.CheckBox();
            this.headlineBluePanel.SuspendLayout();
            this.logoBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(47, 102);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 30);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(175, 102);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 52;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // headlineBluePanel
            // 
            this.headlineBluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.headlineBluePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headlineBluePanel.Controls.Add(this.loginLabel);
            this.headlineBluePanel.Controls.Add(this.logoBackgroundPanel);
            this.headlineBluePanel.Location = new System.Drawing.Point(0, 0);
            this.headlineBluePanel.Name = "headlineBluePanel";
            this.headlineBluePanel.Size = new System.Drawing.Size(309, 55);
            this.headlineBluePanel.TabIndex = 53;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(126, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(73, 29);
            this.loginLabel.TabIndex = 15;
            this.loginLabel.Text = "Login";
            // 
            // logoBackgroundPanel
            // 
            this.logoBackgroundPanel.BackColor = System.Drawing.Color.White;
            this.logoBackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoBackgroundPanel.Controls.Add(this.logoPictureBox);
            this.logoBackgroundPanel.Location = new System.Drawing.Point(3, 5);
            this.logoBackgroundPanel.Name = "logoBackgroundPanel";
            this.logoBackgroundPanel.Size = new System.Drawing.Size(45, 45);
            this.logoBackgroundPanel.TabIndex = 16;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.FBSmallLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(-5, -6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // formatedStatusesCheckBox
            // 
            this.formatedStatusesCheckBox.AllowDrop = true;
            this.formatedStatusesCheckBox.AutoSize = true;
            this.formatedStatusesCheckBox.Location = new System.Drawing.Point(47, 149);
            this.formatedStatusesCheckBox.Name = "formatedStatusesCheckBox";
            this.formatedStatusesCheckBox.Size = new System.Drawing.Size(135, 17);
            this.formatedStatusesCheckBox.TabIndex = 54;
            this.formatedStatusesCheckBox.Text = "Show detailed statuses";
            this.formatedStatusesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formatedStatusesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 182);
            this.Controls.Add(this.formatedStatusesCheckBox);
            this.Controls.Add(this.headlineBluePanel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.headlineBluePanel.ResumeLayout(false);
            this.headlineBluePanel.PerformLayout();
            this.logoBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel headlineBluePanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel logoBackgroundPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.CheckBox formatedStatusesCheckBox;
    }
}