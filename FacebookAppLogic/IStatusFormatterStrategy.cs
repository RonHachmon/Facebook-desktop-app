using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IStatusFormatterStrategy
    {
        string GenerateStatusFormat(Post i_PostToConfigure);
    }
}