using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp.DevTools.Database;
using System.Threading;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private const string k_EmptyDataRetrieved = "No data to show";
        private const string k_DefaultStatusText = "What's on your mind?";
        private const string k_ErrorForTryingToPostEmptyStatus = "Error - can't post empty status";

        private readonly LoginForm r_LoginForm;
        private readonly MainPage r_MainPage;

        public MainForm(LoginForm i_LoginForm,bool i_ShowDetailedStatuses)
        {
            r_MainPage = new MainPage(i_ShowDetailedStatuses);
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            r_LoginForm = i_LoginForm;
            r_LoginForm.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            r_MainPage.Logout();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            retrieveUserProfileData();
        }

        private void retrieveUserProfileData()
        {
            profilePictureBox.ImageLocation = r_MainPage.RetrieveProfilePicture();
            usernameLabel.Text = r_MainPage.RetrieveUsername();
            new Thread(showUserStatuses).Start();
            new Thread(showUserGroups).Start();
            new Thread(showUserEvents).Start();
            new Thread(showUserPages).Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            r_LoginForm.Visible = true;
            Close();
        }

        private void friendsGameButton_Click(object sender, EventArgs e)
        {
            FriendsQuizForm friendQuizForm = new FriendsQuizForm();
            friendQuizForm.ShowDialog();
        }

        private void AdvancedImageSearch_Click(object sender, EventArgs e)
        {
            AdvancedImageSearchForm form = new AdvancedImageSearchForm();
            form.ShowDialog();
        }

        private void statusTextBox_Click(object sender, EventArgs e)
        {
            bool isDefaultStatus = string.Equals(statusTextBox.Text, k_DefaultStatusText);
            if(isDefaultStatus)
            {
                statusTextBox.Clear();
            }

            postButton.Enabled = true;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            bool isStatusEmpty = string.IsNullOrEmpty(statusTextBox.Text);

            try
            {
                if(isStatusEmpty)
                {
                    MessageBox.Show(k_ErrorForTryingToPostEmptyStatus);
                }

                r_MainPage.PostStatus(statusTextBox.Text);
                listBoxPosts.Items.Add(statusTextBox.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                postButton.Enabled = false;
                statusTextBox.Text = k_DefaultStatusText;
            }
        }

        private void showUserStatuses()
        {
            try
            {
                List<string> userPostedStatuses = r_MainPage.RetrievePostedStatuses();

                if(userPostedStatuses.Count > 0)
                {
                    foreach(string status in userPostedStatuses)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(status)));
                    }
                }
                else
                {
                    listBoxPosts.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> commentsForStatus = r_MainPage.RetrieveCommentsForStatus(listBoxPosts.SelectedIndex);
                listBoxComments.Items.Clear();
                if(commentsForStatus.Count > 0)
                {
                    foreach(string comment in commentsForStatus)
                    {
                        listBoxComments.Items.Add(comment);
                    }
                }
                else
                {
                    listBoxComments.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserEvents()
        {
            try
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = r_MainPage.RetrieveEvents()));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserPages()
        {
            try
            {
                listBoxPages.Invoke(new Action(() => pageBindingSource.DataSource = r_MainPage.RetrievePages()));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserGroups()
        {
            try
            {
                listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = r_MainPage.RetrieveGroups()));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void commentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}