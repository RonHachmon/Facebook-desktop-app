using System;

namespace FacebookAppLogic
{
    public class Filters
    {
        private DateTime? m_MinCreationDate;
        private DateTime? m_MaxCreationDate;
        private int m_MinAmoutOfLikes;
        private int? m_SelectedAlbumIndex;
        private string m_TaggedFriend;

        public Filters()
        {
            ResetFilter();
        }

        public void ResetFilter()
        {
            this.MinAmoutOfLikes = 0;
            this.MaxCreationDate = null;
            this.MinCreationDate = null;
            this.SelectedAlbumIndex = null;
            this.TaggedFriend = null;
        }

        public DateTime? MinCreationDate
        {
            get { return m_MinCreationDate; }
            set { m_MinCreationDate = value; }
        }
        public DateTime? MaxCreationDate
        {
            get { return m_MaxCreationDate; }
            set { m_MaxCreationDate = value; }
        }
        public int MinAmoutOfLikes
        {
            get { return m_MinAmoutOfLikes; }
            set { m_MinAmoutOfLikes = value; }
        }
        public int? SelectedAlbumIndex
        {
            get { return m_SelectedAlbumIndex; }
            set { m_SelectedAlbumIndex = value; }
        }
        public string TaggedFriend
        {
            get { return m_TaggedFriend; }
            set { m_TaggedFriend = value; }
        }
    }
}