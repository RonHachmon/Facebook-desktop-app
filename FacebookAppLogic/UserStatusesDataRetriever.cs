using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserStatusesDataRetriever : DataRetriever<FacebookObjectCollection<Post>>
    {
        protected override FacebookObjectCollection<Post> GetRelatedData()
        {
            return r_UserDataManager.User.Posts;
        }
    }
}