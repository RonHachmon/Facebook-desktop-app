using System;
using System.Text;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    public partial class FriendsQuizForm : Form
    {
        private const string k_QuizCheckError = "You should run a new quiz to do that";

        private readonly QuizPage r_QuizPage;
        private string m_FriendsBirthday;
        private string m_FriendsCity;
        private string m_FriendsCountry;
        private string m_FriendsRelationshipStatus;
        private bool m_QuizInProgress;

        public FriendsQuizForm()
        {
            InitializeComponent();
            r_QuizPage = new QuizPage();
            m_QuizInProgress = false;
        }

        private void randomizeFriendButton_Click(object sender, EventArgs e)
        {
            pickAndShowRandomFriend();
            retrieveAnswersForQuiz();
            enableAndClearAnswersTextBoxes();
            m_QuizInProgress = true;
        }

        private void pickAndShowRandomFriend()
        {
            r_QuizPage.PickRandomFriend();
            randomFriendPictureBox.ImageLocation = r_QuizPage.RetrieveFriendProfilePic();
            randomFriendNameLabel.Text = r_QuizPage.RetrieveFriendName();
        }

        private void retrieveAnswersForQuiz()
        {
            retrieveFriendsBirthday();
            retrieveFriendsCity();
            retrieveFriendsCountry();
            retrieveFriendsRelationshipStatus();
        }

        private void enableAndClearAnswersTextBoxes()
        {
            birthdayTextBox.Enabled = true;
            birthdayTextBox.Text = "";
            cityTextBox.Enabled = true;
            cityTextBox.Text = "";
            countryTextBox.Enabled = true;
            countryTextBox.Text = "";
            relationshipTextBox.Enabled = true;
            relationshipTextBox.Text = "";
        }

        private void disableAnswersTextBoxes()
        {
            birthdayTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            countryTextBox.Enabled = false;
            relationshipTextBox.Enabled = false;
            m_QuizInProgress = false;
        }

        private void retrieveFriendsBirthday()
        {
            try
            {
                m_FriendsBirthday = r_QuizPage.RetrieveFriendBirthday();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error - failed to retrieve friend's birthday");
            }
        }

        private void retrieveFriendsCity()
        {
            try
            {
                m_FriendsCity = r_QuizPage.RetrieveFriendsCity();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error - failed to retrieve friend's city");
            }
        }

        private void retrieveFriendsCountry()
        {
            try
            {
                m_FriendsCountry = r_QuizPage.RetrieveFriendsCountry();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error - failed to retrieve friend's country");
            }
        }

        private void retrieveFriendsRelationshipStatus()
        {
            try
            {
                m_FriendsRelationshipStatus = r_QuizPage.RetrieveFriendsRelationshipStatus();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error - failed to retrieve friend's relationship status");
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(m_QuizInProgress)
            {
                disableAnswersTextBoxes();
                MessageBox.Show(getQuizAnswersMessage());
            }
            else
            {
                MessageBox.Show(k_QuizCheckError);
            }
        }

        private string getQuizAnswersMessage()
        {
            StringBuilder answers = new StringBuilder();

            answers.AppendLine(string.Format("{0} has born in {1}", randomFriendNameLabel.Text, m_FriendsBirthday));
            answers.AppendLine(string.Format("in the city {0} that's in {1}", m_FriendsCity, m_FriendsCountry));
            answers.AppendLine(string.Format("relationship status: {0}", m_FriendsRelationshipStatus));

            return answers.ToString();
        }
    }
}