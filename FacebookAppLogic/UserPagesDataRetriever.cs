using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserPagesDataRetriever : DataRetriever<FacebookObjectCollection<Page>>
    {
        protected override FacebookObjectCollection<Page> GetRelatedData()
        {
            return r_UserDataManager.User.LikedPages;
        }
    }
}