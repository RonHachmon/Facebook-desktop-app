using System;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class DetailedStatusFormat : IStatusFormatterStrategy
    {
        public string GenerateStatusFormat(Post i_PostToFormat)
        {
            try
            {
                StringBuilder newStatusFormat = new StringBuilder();

                newStatusFormat.Append(string.Format("({0}) - {1} - Num of Comments: {2}",
                    i_PostToFormat.CreatedTime.ToString(),
                    i_PostToFormat.Type.ToString(),
                    i_PostToFormat.Comments.Count));
                newStatusFormat.AppendLine(string.Format("{0}", i_PostToFormat.Message));

                return newStatusFormat.ToString();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error, access post failed - {exception.Message}");
            }
        }
    }
}