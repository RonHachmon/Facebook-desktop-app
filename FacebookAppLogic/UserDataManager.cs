using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public sealed class UserDataManager
    {
        private static UserDataManager s_Instance = null;
        private FacebookObjectCollection<Album> m_Albums = null;
        private static object s_LockObj = new Object();
        private string m_ProfilePictureURL = null;
        private string m_UserName = null;
        private FacebookObjectCollection<User> m_FriendsList = null;
        private FacebookObjectCollection<Post> m_StatusesList = null;
        private FacebookObjectCollection<Page> m_PagesList = null;
        private FacebookObjectCollection<Event> m_EventsList = null;
        private FacebookObjectCollection<Group> m_GroupsList = null;

        private UserDataManager()
        {
        }

        public static UserDataManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserDataManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User User { get; private set; }

        public bool IsAuthenticated { get; private set; }

        public FacebookObjectCollection<Album> RetrieveUserAlbums()
        {
            return new UserAlbumsDataRetriever().Retrieve(m_Albums);
        }

        public void Login()
        {
            IsAuthenticated = false;
            LoginResult loginResult = FacebookService.Login(
                "973153713605868",
                "user_likes",
                "user_photos",
                "user_posts",
                "user_friends",
                "user_birthday",
                "user_gender",
                "user_videos",
                "user_link",
                "user_events",
                "user_hometown",
                "user_location",
                "groups_access_member_info",
                "email");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                IsAuthenticated = true;
                User = loginResult.LoggedInUser;
            }
        }

        public void Logout()
        {
            IsAuthenticated = false;
            FacebookService.Logout(null);
            User = null;
        }

        public string RetrieveProfilePicture()
        {
            try
            {
                if (m_ProfilePictureURL == null)
                {
                    m_ProfilePictureURL = User.PictureNormalURL;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve profile picture");
            }

            return m_ProfilePictureURL;
        }

        public string RetrieveUsername()
        {
            try
            {
                if (m_UserName == null)
                {
                    m_UserName = User.FirstName + ' ' + User.LastName;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve username");
            }

            return m_UserName;
        }

        public FacebookObjectCollection<User> RetrieveFriends()
        {
            return new UserFriendsDataRetriever().Retrieve(m_FriendsList);
        }

        public FacebookObjectCollection<Post> RetrievePostedStatuses()
        {
            return new UserStatusesDataRetriever().Retrieve(m_StatusesList);
        }

        public List<string> RetrieveCommentsForStatus(int i_IndexForRelatedStatus)
        {
            List<string> commentsRelated = new List<string>();

            try
            {
                foreach (Comment commentOnStatus in User.Posts[i_IndexForRelatedStatus].Comments)
                {
                    commentsRelated.Add(commentOnStatus.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to retrieve comments");
            }

            return commentsRelated;
        }

        public FacebookObjectCollection<Event> RetrieveEvents()
        {
            return new UserEventsDataRetriever().Retrieve(m_EventsList);
        }

        public FacebookObjectCollection<Page> RetrievePages()
        {
            return new UserPagesDataRetriever().Retrieve(m_PagesList);
        }

        public FacebookObjectCollection<Group> RetrieveGroups()
        {
            return new UserGroupsDataRetriever().Retrieve(m_GroupsList);

        }

        public void PostStatus(string i_StatusToPost)
        {
            try
            {
                User.PostStatus(i_StatusToPost);
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to post status");
            }
        }
    }
}