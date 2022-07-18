using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookFilteredImages:IEnumerable<Photo>
    {
        public FacebookFilteredImages()
        {
            Filters = new Filters();
            Albums = null;
            FilteredPhotos = new List<Photo>();
            Count = 0;
        }

        public Filters Filters { get; set; }

        private FacebookObjectCollection<Album> Albums {  get;  set; }

        private List<Photo> FilteredPhotos { get;  set; }
        public int Count { get;private set; } 

        public void CreateFilteredPhotos()
        {
            FilteredPhotos.Clear();
            if (Albums == null)
            {
                Albums = UserDataManager.Instance.RetrieveUserAlbums();
            }

            if (Filters.SelectedAlbumIndex == null)
            {
                foreach (Album album in Albums)
                {
                    searchInAlbum(album);
                }
            }
            else
            {
                searchInAlbum(Albums[(int)Filters.SelectedAlbumIndex]);
            }
            Count = FilteredPhotos.Count;
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
                                filterByDate(photo);
                            }
                        }
                    }
                    else
                    {
                        filterByDate(photo);
                    }
                }
            }
        }

        private void filterByDate(Photo i_Photo)
        {
            if(Filters.MinCreationDate != null)
            {
                if(i_Photo.CreatedTime >= Filters.MinCreationDate && i_Photo.CreatedTime <= Filters.MaxCreationDate)
                {
                    FilteredPhotos.Add(i_Photo);
                }
            }
            else
            {
                FilteredPhotos.Add(i_Photo);
            }
        }

        public void SortPhotoListByLikes()
        {
            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.LikedBy.Count).ToList();
        }

        public void SortPhotoListByCreatedTime()
        {
            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.CreatedTime).ToList();
        }
        
        public IEnumerator<Photo> GetEnumerator()
        {
            foreach (Photo photo in FilteredPhotos)
            {
                yield return photo;
                                
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }        
    }
}