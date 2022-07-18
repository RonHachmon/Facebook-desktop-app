
namespace BasicFacebookFeatures
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.friendsGameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AdvancedImageSearch = new System.Windows.Forms.Button();
            this.headlineBluePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainFormHeadLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.groupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.headlineBluePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).BeginInit();
            this.groupBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(11, 60);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.profilePictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // friendsGameButton
            // 
            this.friendsGameButton.Location = new System.Drawing.Point(14, 229);
            this.friendsGameButton.Name = "friendsGameButton";
            this.friendsGameButton.Size = new System.Drawing.Size(88, 23);
            this.friendsGameButton.TabIndex = 1;
            this.friendsGameButton.Text = "Friends Quiz";
            this.friendsGameButton.UseVisualStyleBackColor = true;
            this.friendsGameButton.Click += new System.EventHandler(this.friendsGameButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(14, 258);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(11, 163);
            this.usernameLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvancedImageSearch
            // 
            this.AdvancedImageSearch.Location = new System.Drawing.Point(14, 200);
            this.AdvancedImageSearch.Name = "AdvancedImageSearch";
            this.AdvancedImageSearch.Size = new System.Drawing.Size(88, 23);
            this.AdvancedImageSearch.TabIndex = 4;
            this.AdvancedImageSearch.Text = "Image Search";
            this.AdvancedImageSearch.UseVisualStyleBackColor = true;
            this.AdvancedImageSearch.Click += new System.EventHandler(this.AdvancedImageSearch_Click);
            // 
            // headlineBluePanel
            // 
            this.headlineBluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.headlineBluePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headlineBluePanel.Controls.Add(this.panel2);
            this.headlineBluePanel.Controls.Add(this.mainFormHeadLabel);
            this.headlineBluePanel.Location = new System.Drawing.Point(0, 0);
            this.headlineBluePanel.Name = "headlineBluePanel";
            this.headlineBluePanel.Size = new System.Drawing.Size(691, 55);
            this.headlineBluePanel.TabIndex = 14;
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
            // mainFormHeadLabel
            // 
            this.mainFormHeadLabel.AutoSize = true;
            this.mainFormHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mainFormHeadLabel.ForeColor = System.Drawing.Color.White;
            this.mainFormHeadLabel.Location = new System.Drawing.Point(212, 21);
            this.mainFormHeadLabel.Name = "mainFormHeadLabel";
            this.mainFormHeadLabel.Size = new System.Drawing.Size(278, 29);
            this.mainFormHeadLabel.TabIndex = 15;
            this.mainFormHeadLabel.Text = "Facebook - On Windows";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(135, 89);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(525, 108);
            this.listBoxPosts.TabIndex = 15;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(135, 62);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(444, 20);
            this.statusTextBox.TabIndex = 16;
            this.statusTextBox.Text = "What\'s on your mind?";
            this.statusTextBox.Click += new System.EventHandler(this.statusTextBox_Click);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(585, 60);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 17;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.DisplayMember = "Comments";
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(135, 206);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(525, 82);
            this.listBoxComments.TabIndex = 18;
            this.listBoxComments.ValueMember = "Comments";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(14, 315);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(201, 147);
            this.listBoxEvents.TabIndex = 41;
            this.listBoxEvents.ValueMember = "AttendingCount";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "Name", true));
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(460, 315);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(201, 147);
            this.listBoxGroups.TabIndex = 42;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // listBoxPages
            // 
            this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(237, 315);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(201, 147);
            this.listBoxPages.TabIndex = 43;
            this.listBoxPages.ValueMember = "AccessToken";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(12, 299);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(43, 13);
            this.eventsLabel.TabIndex = 44;
            this.eventsLabel.Text = "Events:";
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Location = new System.Drawing.Point(234, 299);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(40, 13);
            this.pagesLabel.TabIndex = 45;
            this.pagesLabel.Text = "Pages:";
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Location = new System.Drawing.Point(457, 299);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(44, 13);
            this.groupsLabel.TabIndex = 46;
            this.groupsLabel.Text = "Groups:";
            // 
            // groupBindingNavigator
            // 
            this.groupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupBindingNavigator.BindingSource = this.groupBindingSource;
            this.groupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupBindingNavigatorSaveItem});
            this.groupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupBindingNavigator.Name = "groupBindingNavigator";
            this.groupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupBindingNavigator.Size = new System.Drawing.Size(691, 25);
            this.groupBindingNavigator.TabIndex = 48;
            this.groupBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBindingNavigatorSaveItem
            // 
            this.groupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBindingNavigatorSaveItem.Enabled = false;
            this.groupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupBindingNavigatorSaveItem.Image")));
            this.groupBindingNavigatorSaveItem.Name = "groupBindingNavigatorSaveItem";
            this.groupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.groupBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.Controls.Add(this.groupBindingNavigator);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.pagesLabel);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.headlineBluePanel);
            this.Controls.Add(this.AdvancedImageSearch);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.friendsGameButton);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.headlineBluePanel.ResumeLayout(false);
            this.headlineBluePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).EndInit();
            this.groupBindingNavigator.ResumeLayout(false);
            this.groupBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button friendsGameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button AdvancedImageSearch;
        private System.Windows.Forms.Panel headlineBluePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label mainFormHeadLabel;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingNavigator groupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton groupBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
    }
}