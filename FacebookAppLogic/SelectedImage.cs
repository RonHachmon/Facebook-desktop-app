using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class SelectedImage
    {
        private Photo m_SelectedPhoto = null;
        public Photo Photo
        {
            get
            {
                return m_SelectedPhoto;
            }
            set
            {
                m_SelectedPhoto = value;
                LikesAmount = Photo.LikedBy.Count;
                CommentsAmount = Photo.Comments.Count;
                PhotoURL = Photo.PictureNormalURL;
            }
        }

        public int LikesAmount { get; private set; }

        public int CommentsAmount { get; private set; }

        public string PhotoURL { get; private set; }

        public List<string> FetchSelectedData(IPhotoData i_PhotoData)
        {
           return i_PhotoData.GetData(Photo);
        }
    }
}