
namespace BasicFacebookFeatures
{
    partial class FriendsQuizForm
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
            this.randomizeFriendButton = new System.Windows.Forms.Button();
            this.randomFriendNameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.relationshipTextBox = new System.Windows.Forms.TextBox();
            this.relationshipLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsQuizHeadLabel = new System.Windows.Forms.Label();
            this.randomFriendPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // randomizeFriendButton
            // 
            this.randomizeFriendButton.Location = new System.Drawing.Point(12, 252);
            this.randomizeFriendButton.Name = "randomizeFriendButton";
            this.randomizeFriendButton.Size = new System.Drawing.Size(120, 23);
            this.randomizeFriendButton.TabIndex = 0;
            this.randomizeFriendButton.Text = "Pick Random Friend";
            this.randomizeFriendButton.UseVisualStyleBackColor = true;
            this.randomizeFriendButton.Click += new System.EventHandler(this.randomizeFriendButton_Click);
            // 
            // randomFriendNameLabel
            // 
            this.randomFriendNameLabel.AutoSize = true;
            this.randomFriendNameLabel.Location = new System.Drawing.Point(22, 187);
            this.randomFriendNameLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.randomFriendNameLabel.Name = "randomFriendNameLabel";
            this.randomFriendNameLabel.Size = new System.Drawing.Size(100, 13);
            this.randomFriendNameLabel.TabIndex = 2;
            this.randomFriendNameLabel.Text = "Friend\'s Name";
            this.randomFriendNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(194, 60);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(71, 13);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Birthday Date";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Enabled = false;
            this.birthdayTextBox.Location = new System.Drawing.Point(169, 76);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(120, 20);
            this.birthdayTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(217, 99);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(169, 115);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(120, 20);
            this.cityTextBox.TabIndex = 7;
            // 
            // relationshipTextBox
            // 
            this.relationshipTextBox.Enabled = false;
            this.relationshipTextBox.Location = new System.Drawing.Point(169, 193);
            this.relationshipTextBox.Name = "relationshipTextBox";
            this.relationshipTextBox.Size = new System.Drawing.Size(120, 20);
            this.relationshipTextBox.TabIndex = 11;
            // 
            // relationshipLabel
            // 
            this.relationshipLabel.AutoSize = true;
            this.relationshipLabel.Location = new System.Drawing.Point(180, 177);
            this.relationshipLabel.Name = "relationshipLabel";
            this.relationshipLabel.Size = new System.Drawing.Size(98, 13);
            this.relationshipLabel.TabIndex = 10;
            this.relationshipLabel.Text = "Relationship Status";
            this.relationshipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Enabled = false;
            this.countryTextBox.Location = new System.Drawing.Point(169, 154);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(120, 20);
            this.countryTextBox.TabIndex = 9;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(208, 138);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 8;
            this.countryLabel.Text = "Country";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(169, 252);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(120, 23);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.friendsQuizHeadLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 55);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 45);
            this.panel2.TabIndex = 16;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.FBSmallLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(-2, -5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // friendsQuizHeadLabel
            // 
            this.friendsQuizHeadLabel.AutoSize = true;
            this.friendsQuizHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.friendsQuizHeadLabel.ForeColor = System.Drawing.Color.White;
            this.friendsQuizHeadLabel.Location = new System.Drawing.Point(90, 24);
            this.friendsQuizHeadLabel.Name = "friendsQuizHeadLabel";
            this.friendsQuizHeadLabel.Size = new System.Drawing.Size(150, 29);
            this.friendsQuizHeadLabel.TabIndex = 15;
            this.friendsQuizHeadLabel.Text = "Friends Quiz";
            // 
            // randomFriendPictureBox
            // 
            this.randomFriendPictureBox.Location = new System.Drawing.Point(12, 74);
            this.randomFriendPictureBox.Name = "randomFriendPictureBox";
            this.randomFriendPictureBox.Size = new System.Drawing.Size(120, 100);
            this.randomFriendPictureBox.TabIndex = 1;
            this.randomFriendPictureBox.TabStop = false;
            // 
            // FriendsQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(309, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.relationshipTextBox);
            this.Controls.Add(this.relationshipLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.randomFriendNameLabel);
            this.Controls.Add(this.randomFriendPictureBox);
            this.Controls.Add(this.randomizeFriendButton);
            this.Name = "FriendsQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friends Quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFriendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomizeFriendButton;
        private System.Windows.Forms.PictureBox randomFriendPictureBox;
        private System.Windows.Forms.Label randomFriendNameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox relationshipTextBox;
        private System.Windows.Forms.Label relationshipLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label friendsQuizHeadLabel;
        private System.Windows.Forms.Panel panel2;
    }
}