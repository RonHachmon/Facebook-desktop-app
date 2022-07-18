using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserEventsDataRetriever : DataRetriever<FacebookObjectCollection<Event>>
    {
        protected override FacebookObjectCollection<Event> GetRelatedData()
        {
            return r_UserDataManager.User.Events;
        }
    }
}