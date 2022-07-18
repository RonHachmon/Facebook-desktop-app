using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace BasicFacebookFeatures
{
    public class GridPhoto: PictureBox
    {
        public Photo Photo { get; set; }
        public GridPhoto(Photo i_Photo)
        {
            Photo = i_Photo;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WaitOnLoad = false;
            this.LoadAsync(i_Photo.PictureAlbumURL);
        }
    }
}
