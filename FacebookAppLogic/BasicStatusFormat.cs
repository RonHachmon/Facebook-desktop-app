using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class BasicStatusFormat : IStatusFormatterStrategy
    {
        public string GenerateStatusFormat(Post i_PostToFormat)
        {
            try
            {
                return (i_PostToFormat.Message == null)? i_PostToFormat.Message: i_PostToFormat.Description;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error, access post failed - {exception}");
            }
        }
    }
}