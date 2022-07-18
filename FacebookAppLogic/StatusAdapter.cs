using System;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class StatusAdapter : IStatusFormat
    {
        private readonly Post r_OldFormatPost;

        public StatusAdapter(Post i_PostToFormat)
        {
            r_OldFormatPost = i_PostToFormat;
        }

        public string GenerateStatusFormat(IStatusFormatterStrategy i_StatusFormatterStrategy)
        {
            try
            {
                return i_StatusFormatterStrategy.GenerateStatusFormat(r_OldFormatPost);
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to format user's posts");
            }
        }
    }
}