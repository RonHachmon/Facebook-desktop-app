using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AdvanceImageSearch
    {
        private readonly FacebookFilteredImages r_FacebookFilteredImages;
        private SelectedImage m_SelectedImage;
        private readonly UserDataManager r_UserDataManager;

        public AdvanceImageSearch()
        {
            r_FacebookFilteredImages = new FacebookFilteredImages();
            m_SelectedImage = new SelectedImage();
            r_UserDataManager = UserDataManager.Instance;
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            return r_FacebookFilteredImages.GetEnumerator();
        }
 
        public int FacebookFilteredImagesCount()
        {
            return r_FacebookFilteredImages.Count;
        }
        public PhotoTags GetTagsDataType()
        {
            return new PhotoTags();
        }

        public PhotoLikes GetLikesDataType()
        {
            return new PhotoLikes();
        }

        public PhotoComments GetCommentDataType()
        {
            return new PhotoComments();
        }

        public void SetSelectedImage(Photo i_Photo)
        {
            m_SelectedImage.Photo = i_Photo;
        }

        public int GetAmountOfLikesOfSelectedPhoto()
        {
            return m_SelectedImage.LikesAmount;
        }

        public int GetAmountOfCommentsOfSelectedPhoto()
        {
            return m_SelectedImage.CommentsAmount;
        }

        public string GetURLOfSlectedPhoto()
        {
            return m_SelectedImage.PhotoURL;
        }

        public List<string> GetDataOfSelectedImage(IPhotoData i_DataType)
        {
            return m_SelectedImage.FetchSelectedData(i_DataType);
        }
        public void CreateFilteredImages()
        {
             r_FacebookFilteredImages.CreateFilteredPhotos();
        }
        public Filters GetFilters()
        {
            return r_FacebookFilteredImages.Filters;
        }

        public void SortByLikes()
        {
             r_FacebookFilteredImages.SortPhotoListByLikes();
        }

        public void SortByCreatedTime()
        {
             r_FacebookFilteredImages.SortPhotoListByCreatedTime();
        }

        public FacebookObjectCollection<Album> RetrieveUserAlbums()
        {
            return r_UserDataManager.RetrieveUserAlbums();
        }

        public FacebookObjectCollection<User> RetrieveUserFriends()
        {
            return r_UserDataManager.User.Friends;
        }
    }
}