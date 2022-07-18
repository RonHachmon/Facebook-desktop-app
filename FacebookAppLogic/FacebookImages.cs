using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookImages
    {
        private List<Photo> m_Photos;
        private Photo m_SelectedPhoto = null;
        private readonly FacebookObjectCollection<Album> r_Albums = null;
        private Filters m_Filters;

        public FacebookImages(User i_User)
        {
            m_Filters = new Filters();
            r_Albums = i_User.Albums;
            m_Photos = new List<Photo>();
        }

        public enum eDataOptions
        {
            Comments = 0,
            LikedBy,
            Tags
        }

        public Photo SelectedPhoto
        {
            get { return m_SelectedPhoto; }
            set { m_SelectedPhoto = value; }
        }
        public Filters Filters
        {
            get { return m_Filters; }
            set { m_Filters = value; }
        }

        public List<Photo> Photos
        {
            get { return m_Photos; }
        }

        public void FetchFilteredPhotos()
        {
            m_Photos.Clear();
            if(Filters.SelectedAlbumIndex == null)
            {
                foreach(Album album in r_Albums)
                {
                    searchInAlbum(album);
                }
            }
            else
            {
                searchInAlbum(r_Albums[(int)Filters.SelectedAlbumIndex]);
            }
        }

        private void searchInAlbum(Album i_Album)
        {
            foreach(Photo photo in i_Album.Photos)
            {
                if(photo.LikedBy.Count >= Filters.MinAmoutOfLikes)
                {
                    if(Filters.TaggedFriend != null)
                    {
                        foreach(PhotoTag tag in photo.Tags)
                        {
                            if(tag.User.Name == Filters.TaggedFriend)
                            {
                                if(Filters.MinCreationDate != null)
                                {
                                    if(photo.CreatedTime >= Filters.MinCreationDate
                                       && photo.CreatedTime <= Filters.MaxCreationDate)
                                    {
                                        m_Photos.Add(photo);
                                    }
                                }
                                else
                                {
                                    m_Photos.Add(photo);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(Filters.MinCreationDate != null)
                        {
                            if(photo.CreatedTime >= Filters.MinCreationDate
                               && photo.CreatedTime <= Filters.MaxCreationDate)
                            {
                                m_Photos.Add(photo);
                            }
                        }
                        else
                        {
                            m_Photos.Add(photo);
                        }
                    }
                }
            }
        }

        public void SortPhotoListByLikes()
        {
            m_Photos = m_Photos.OrderByDescending(o => o.LikedBy.Count).ToList();
        }

        public void SortPhotoListByCreatedTime()
        {
            m_Photos = m_Photos.OrderByDescending(o => o.CreatedTime).ToList();
        }

        public List<string> SelectedImageData(int i_ChosenData)
        {
            List<string> photoData = new List<string>();
            if(SelectedPhoto != null)
            {
                switch((eDataOptions)i_ChosenData)
                {
                    case eDataOptions.Comments:
                        addSelectedImageComments(photoData);
                        break;
                    case eDataOptions.LikedBy:
                        addSelectedImageLikedBy(photoData);
                        break;
                    case eDataOptions.Tags:
                        addSelectedImageTagedUsers(photoData);
                        break;
                }
            }

            return photoData;
        }

        private void addSelectedImageComments(List<string> i_Data)
        {
            if(m_SelectedPhoto.Comments != null)
            {
                foreach(Comment comment in m_SelectedPhoto.Comments)
                {
                    i_Data.Add(comment.Message);
                }
            }
        }

        private void addSelectedImageLikedBy(List<string> i_Data)
        {
            if(m_SelectedPhoto.LikedBy != null)
            {
                foreach(User user in m_SelectedPhoto.LikedBy)
                {
                    i_Data.Add(user.Name);
                }
            }
        }

        private void addSelectedImageTagedUsers(List<string> i_Data)
        {
            if(m_SelectedPhoto.Tags != null)
            {
                foreach(PhotoTag Tag in m_SelectedPhoto.Tags)
                {
                    i_Data.Add(Tag.User.Name);
                }
            }
        }
    }
}