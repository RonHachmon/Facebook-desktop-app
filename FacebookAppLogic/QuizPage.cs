using System;

namespace FacebookAppLogic
{
    public class QuizPage
    {
        private readonly FacebooksFriends r_UserfacebooksFriends;

        public QuizPage()
        {
            r_UserfacebooksFriends = new FacebooksFriends();
        }

        public void PickRandomFriend()
        {
            r_UserfacebooksFriends.PickRandomFriend();
        }

        public string RetrieveFriendProfilePic()
        {
            return r_UserfacebooksFriends.RandomFriend.PictureNormalURL;
        }

        public string RetrieveFriendName()
        {
            return r_UserfacebooksFriends.RandomFriend.FirstName + ' ' + r_UserfacebooksFriends.RandomFriend.LastName;
        }

        public string RetrieveFriendBirthday()
        {
            return r_UserfacebooksFriends.RandomFriend.Birthday;
        }

        public string RetrieveFriendsCity()
        {
            try
            {
                return r_UserfacebooksFriends.RandomFriend.Location.Location.City;
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve friend's city");
            }
        }

        public string RetrieveFriendsCountry()
        {
            try
            {
                return r_UserfacebooksFriends.RandomFriend.Location.Location.Country;
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve friend's country");
            }
        }

        public string RetrieveFriendsRelationshipStatus()
        {
            try
            {
                return r_UserfacebooksFriends.RandomFriend.RelationshipStatus.ToString();
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve friend's relationship status");
            }
        }
    }
}