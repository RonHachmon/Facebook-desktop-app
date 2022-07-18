using System;

namespace FacebookAppLogic
{
    public abstract class DataRetriever<T>
    {
        protected readonly UserDataManager r_UserDataManager;

        public DataRetriever()
        {
            r_UserDataManager = UserDataManager.Instance;
        }

        public T Retrieve(T io_DataComponent)
        {
            try
            {
                if (io_DataComponent == null)
                {
                    io_DataComponent = GetRelatedData();
                }
            }
            catch (Exception exception)
            {
                throw new Exception($"Error, Failed to data from server - {exception.Message}");
            }

            return io_DataComponent;
        }

        protected abstract T GetRelatedData();
    }
}