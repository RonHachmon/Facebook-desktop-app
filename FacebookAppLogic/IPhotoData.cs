using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IPhotoData
    {
        List<string> GetData(Photo i_PhotoSource);
    }
}