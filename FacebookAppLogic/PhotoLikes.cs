using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PhotoLikes : IPhotoData
    {
        public List<string> GetData(Photo i_PhotoSource)
        {
            List<string> photoData = new List<string>();
            if (i_PhotoSource.LikedBy != null)
            {
                foreach (User user in i_PhotoSource.LikedBy)
                {
                    photoData.Add(user.Name);
                }
            }
            return photoData;
        }
        public override string ToString()
        {
            return "Liked By";
        }
    }
}
