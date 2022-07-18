using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MainPage
    {
        private readonly UserDataManager r_UserDataManager;
        private readonly bool r_ShowDetailedStatuses;
        private IStatusFormatterStrategy statusFormatterStrategy;



        public MainPage(bool i_ShowDetailedStatuses)
        {
            r_UserDataManager = UserDataManager.Instance;
            r_ShowDetailedStatuses = i_ShowDetailedStatuses;
        }

        public void Logout()
        {
            UserDataManager.Instance.Logout();
        }

        public string RetrieveProfilePicture()
        {
            return r_UserDataManager.RetrieveProfilePicture();
        }

        public string RetrieveUsername()
        {
            return r_UserDataManager.RetrieveUsername();
        }

        public List<string> RetrievePostedStatuses()
        {
            List<string> postedStatuses = new List<string>();

            switch (r_ShowDetailedStatuses)
            {
                case true:
                    statusFormatterStrategy = new DetailedStatusFormat();
                    break;
                case false:
                    statusFormatterStrategy = new BasicStatusFormat();
                    break;
            }

            foreach (Post status in r_UserDataManager.RetrievePostedStatuses())
            {
                postedStatuses.Add(new StatusAdapter(status).GenerateStatusFormat(statusFormatterStrategy));
            }

            return postedStatuses;
        }

        public List<string> RetrieveCommentsForStatus(int i_StatusIndex)
        {
            return r_UserDataManager.RetrieveCommentsForStatus(i_StatusIndex);
        }

        public FacebookObjectCollection<Event> RetrieveEvents()
        {
            return r_UserDataManager.RetrieveEvents();
        }

        public FacebookObjectCollection<Page> RetrievePages()
        {
            return r_UserDataManager.RetrievePages();
        }

        public FacebookObjectCollection<Group> RetrieveGroups()
        {
            return r_UserDataManager.RetrieveGroups();
        }

        public void PostStatus(string i_StatusToPost)
        {
            r_UserDataManager.PostStatus(i_StatusToPost);
        }
    }
}