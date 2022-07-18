using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IStatusFormatStrategy
    {
        string GenerateStatusFormat(Post i_PostToFormat);
    }
}