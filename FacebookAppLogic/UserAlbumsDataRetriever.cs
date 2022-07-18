using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserAlbumsDataRetriever : DataRetriever<FacebookObjectCollection<Album>>
    {
        protected override FacebookObjectCollection<Album> GetRelatedData()
        {
            return r_UserDataManager.User.Albums;
        }
    }
}