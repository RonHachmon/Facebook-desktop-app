using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserGroupsDataRetriever : DataRetriever<FacebookObjectCollection<Group>>
    {
        protected override FacebookObjectCollection<Group> GetRelatedData()
        {
            return r_UserDataManager.User.Groups;
        }
    }
}