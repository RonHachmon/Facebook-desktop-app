using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PhotoTags : IPhotoData
    {
        public List<string> GetData(Photo i_PhotoSource)
        {
            List<string> photoData = new List<string>();
            if(i_PhotoSource.Tags != null)
            {
                foreach(PhotoTag Tag in i_PhotoSource.Tags)
                {
                    photoData.Add(Tag.User.Name);
                }
            }

            return photoData;
        }

        public override string ToString()
        {
            return "Tags";
        }
    }
}