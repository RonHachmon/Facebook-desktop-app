using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PhotoComments : IPhotoData
    {
        public List<string> GetData(Photo i_PhotoSource)
        {
            List<string> photoData = new List<string>();
            if(i_PhotoSource.Comments != null)
            {
                foreach(Comment comment in i_PhotoSource.Comments)
                {
                    photoData.Add(comment.Message);
                }
            }

            return photoData;
        }

        public override string ToString()
        {
            return "Comments";
        }
    }
}