namespace BasicFacebookFeatures
{
    partial class AdvancedImageSearchForm
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
            this.comboBoxShowData = new System.Windows.Forms.ComboBox();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.labelAdvancedImageSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.checkBoxAlbum = new System.Windows.Forms.CheckBox();
            this.checkBoxLikes = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.listBoxPictureData = new System.Windows.Forms.ListBox();
            this.comboBoxAlbumsNames = new System.Windows.Forms.ComboBox();
            this.taggedFriendLabel = new System.Windows.Forms.Label();
            this.fromAlbumLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.m_DateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.minLikesLabel = new System.Windows.Forms.Label();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.checkBoxTaggedFriends = new System.Windows.Forms.CheckBox();
            this.comboBoxTaggedFriend = new System.Windows.Forms.ComboBox();
            this.numericUpDownLikes = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filtersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxShowData
            // 
            this.comboBoxShowData.Enabled = false;
            this.comboBoxShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShowData.FormattingEnabled = true;
            this.comboBoxShowData.Location = new System.Drawing.Point(544, 588);
            this.comboBoxShowData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxShowData.Name = "comboBoxShowData";
            this.comboBoxShowData.Size = new System.Drawing.Size(534, 33);
            this.comboBoxShowData.TabIndex = 45;
            this.comboBoxShowData.Text = "show";
            this.comboBoxShowData.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowData_SelectedIndexChanged);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.backgroundPanel.Controls.Add(this.labelAdvancedImageSearch);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Location = new System.Drawing.Point(3, 2);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1112, 126);
            this.backgroundPanel.TabIndex = 44;
            // 
            // labelAdvancedImageSearch
            // 
            this.labelAdvancedImageSearch.AutoSize = true;
            this.labelAdvancedImageSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.28F);
            this.labelAdvancedImageSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdvancedImageSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdvancedImageSearch.Location = new System.Drawing.Point(160, 55);
            this.labelAdvancedImageSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdvancedImageSearch.Name = "labelAdvancedImageSearch";
            this.labelAdvancedImageSearch.Size = new System.Drawing.Size(560, 57);
            this.labelAdvancedImageSearch.TabIndex = 0;
            this.labelAdvancedImageSearch.Text = "Advanced Image Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Location = new System.Drawing.Point(51, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 100);
            this.panel2.TabIndex = 54;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.FBSmallLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(-24, -2);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(108, 100);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 15;
            this.logoPictureBox.TabStop = false;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Enabled = false;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Creation Date",
            "Likes"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(15, 474);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(178, 33);
            this.comboBoxSortBy.TabIndex = 41;
            this.comboBoxSortBy.Text = "Sort by:";
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // checkBoxAlbum
            // 
            this.checkBoxAlbum.AutoSize = true;
            this.checkBoxAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxAlbum.Location = new System.Drawing.Point(15, 286);
            this.checkBoxAlbum.Name = "checkBoxAlbum";
            this.checkBoxAlbum.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAlbum.TabIndex = 40;
            this.checkBoxAlbum.UseVisualStyleBackColor = true;
            this.checkBoxAlbum.CheckedChanged += new System.EventHandler(this.checkBoxAlbum_CheckedChanged);
            // 
            // checkBoxLikes
            // 
            this.checkBoxLikes.AutoSize = true;
            this.checkBoxLikes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxLikes.Location = new System.Drawing.Point(15, 243);
            this.checkBoxLikes.Name = "checkBoxLikes";
            this.checkBoxLikes.Size = new System.Drawing.Size(22, 21);
            this.checkBoxLikes.TabIndex = 39;
            this.checkBoxLikes.UseVisualStyleBackColor = true;
            this.checkBoxLikes.CheckedChanged += new System.EventHandler(this.checkBoxLikes_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxDate.Location = new System.Drawing.Point(15, 198);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDate.TabIndex = 38;
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // listBoxPictureData
            // 
            this.listBoxPictureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPictureData.FormattingEnabled = true;
            this.listBoxPictureData.ItemHeight = 25;
            this.listBoxPictureData.Location = new System.Drawing.Point(544, 634);
            this.listBoxPictureData.Name = "listBoxPictureData";
            this.listBoxPictureData.Size = new System.Drawing.Size(534, 179);
            this.listBoxPictureData.TabIndex = 37;
            // 
            // comboBoxAlbumsNames
            // 
            this.comboBoxAlbumsNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAlbumsNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAlbumsNames.DisplayMember = "(none)";
            this.comboBoxAlbumsNames.Enabled = false;
            this.comboBoxAlbumsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlbumsNames.FormattingEnabled = true;
            this.comboBoxAlbumsNames.Location = new System.Drawing.Point(348, 274);
            this.comboBoxAlbumsNames.Name = "comboBoxAlbumsNames";
            this.comboBoxAlbumsNames.Size = new System.Drawing.Size(157, 33);
            this.comboBoxAlbumsNames.TabIndex = 36;
            // 
            // taggedFriendLabel
            // 
            this.taggedFriendLabel.AutoSize = true;
            this.taggedFriendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.taggedFriendLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.taggedFriendLabel.Location = new System.Drawing.Point(44, 329);
            this.taggedFriendLabel.Name = "taggedFriendLabel";
            this.taggedFriendLabel.Size = new System.Drawing.Size(133, 25);
            this.taggedFriendLabel.TabIndex = 33;
            this.taggedFriendLabel.Text = "Tagged friend";
            // 
            // fromAlbumLabel
            // 
            this.fromAlbumLabel.AutoSize = true;
            this.fromAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromAlbumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fromAlbumLabel.Location = new System.Drawing.Point(42, 285);
            this.fromAlbumLabel.Name = "fromAlbumLabel";
            this.fromAlbumLabel.Size = new System.Drawing.Size(115, 25);
            this.fromAlbumLabel.TabIndex = 32;
            this.fromAlbumLabel.Text = "From album";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toLabel.Location = new System.Drawing.Point(282, 192);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(36, 25);
            this.toLabel.TabIndex = 31;
            this.toLabel.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFrom.Location = new System.Drawing.Point(44, 197);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(57, 25);
            this.labelFrom.TabIndex = 30;
            this.labelFrom.Text = "From";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Enabled = false;
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(348, 188);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(158, 30);
            this.dateTimePickerToDate.TabIndex = 29;
            // 
            // m_DateTimePickerFromDate
            // 
            this.m_DateTimePickerFromDate.Enabled = false;
            this.m_DateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_DateTimePickerFromDate.Location = new System.Drawing.Point(106, 192);
            this.m_DateTimePickerFromDate.MaxDate = new System.DateTime(2039, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.Name = "m_DateTimePickerFromDate";
            this.m_DateTimePickerFromDate.Size = new System.Drawing.Size(158, 30);
            this.m_DateTimePickerFromDate.TabIndex = 28;
            // 
            // minLikesLabel
            // 
            this.minLikesLabel.AutoSize = true;
            this.minLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLikesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minLikesLabel.Location = new System.Drawing.Point(42, 242);
            this.minLikesLabel.Name = "minLikesLabel";
            this.minLikesLabel.Size = new System.Drawing.Size(185, 25);
            this.minLikesLabel.TabIndex = 27;
            this.minLikesLabel.Text = "Min amount of likes:";
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(546, 188);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(534, 338);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImage.TabIndex = 25;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(16, 377);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(492, 75);
            this.buttonSearch.TabIndex = 35;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 47;
            this.label7.Text = "Filters:";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.Location = new System.Drawing.Point(570, 529);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(64, 25);
            this.labelLikes.TabIndex = 48;
            this.labelLikes.Text = "Likes:";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(894, 529);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(113, 25);
            this.labelComments.TabIndex = 49;
            this.labelComments.Text = "Comments:";
            // 
            // checkBoxTaggedFriends
            // 
            this.checkBoxTaggedFriends.AutoSize = true;
            this.checkBoxTaggedFriends.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxTaggedFriends.Location = new System.Drawing.Point(15, 331);
            this.checkBoxTaggedFriends.Name = "checkBoxTaggedFriends";
            this.checkBoxTaggedFriends.Size = new System.Drawing.Size(22, 21);
            this.checkBoxTaggedFriends.TabIndex = 50;
            this.checkBoxTaggedFriends.UseVisualStyleBackColor = true;
            this.checkBoxTaggedFriends.CheckedChanged += new System.EventHandler(this.checkBoxTaggedFriends_CheckedChanged);
            // 
            // comboBoxTaggedFriend
            // 
            this.comboBoxTaggedFriend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTaggedFriend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTaggedFriend.DisplayMember = "(none)";
            this.comboBoxTaggedFriend.Enabled = false;
            this.comboBoxTaggedFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaggedFriend.FormattingEnabled = true;
            this.comboBoxTaggedFriend.Location = new System.Drawing.Point(350, 318);
            this.comboBoxTaggedFriend.Name = "comboBoxTaggedFriend";
            this.comboBoxTaggedFriend.Size = new System.Drawing.Size(157, 33);
            this.comboBoxTaggedFriend.TabIndex = 51;
            // 
            // numericUpDownLikes
            // 
            this.numericUpDownLikes.Enabled = false;
            this.numericUpDownLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLikes.Location = new System.Drawing.Point(348, 232);
            this.numericUpDownLikes.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownLikes.Name = "numericUpDownLikes";
            this.numericUpDownLikes.Size = new System.Drawing.Size(158, 30);
            this.numericUpDownLikes.TabIndex = 52;
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(16, 517);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(492, 345);
            this.flowLayoutPanelImages.TabIndex = 53;
            // 
            // selectedImageBindingSource
            // 
            this.selectedImageBindingSource.DataSource = typeof(FacebookAppLogic.SelectedImage);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // filtersBindingSource
            // 
            this.filtersBindingSource.DataSource = typeof(FacebookAppLogic.Filters);
            // 
            // AdvancedImageSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 935);
            this.Controls.Add(this.flowLayoutPanelImages);
            this.Controls.Add(this.numericUpDownLikes);
            this.Controls.Add(this.comboBoxTaggedFriend);
            this.Controls.Add(this.checkBoxTaggedFriends);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxShowData);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.checkBoxAlbum);
            this.Controls.Add(this.checkBoxLikes);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.listBoxPictureData);
            this.Controls.Add(this.comboBoxAlbumsNames);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.taggedFriendLabel);
            this.Controls.Add(this.fromAlbumLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.m_DateTimePickerFromDate);
            this.Controls.Add(this.minLikesLabel);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Name = "AdvancedImageSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Image Search";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShowData;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label labelAdvancedImageSearch;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.CheckBox checkBoxAlbum;
        private System.Windows.Forms.CheckBox checkBoxLikes;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.ListBox listBoxPictureData;
        private System.Windows.Forms.ComboBox comboBoxAlbumsNames;
        private System.Windows.Forms.Label taggedFriendLabel;
        private System.Windows.Forms.Label fromAlbumLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker m_DateTimePickerFromDate;
        private System.Windows.Forms.Label minLikesLabel;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.CheckBox checkBoxTaggedFriends;
        private System.Windows.Forms.ComboBox comboBoxTaggedFriend;
        private System.Windows.Forms.NumericUpDown numericUpDownLikes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource selectedImageBindingSource;
        private System.Windows.Forms.BindingSource filtersBindingSource;
    }
}