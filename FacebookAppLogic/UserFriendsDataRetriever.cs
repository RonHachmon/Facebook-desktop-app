using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserFriendsDataRetriever : DataRetriever<FacebookObjectCollection<User>>
    {
        protected override FacebookObjectCollection<User> GetRelatedData()
        {
            return r_UserDataManager.User.Friends;
        }
    }
}