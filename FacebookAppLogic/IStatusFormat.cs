namespace FacebookAppLogic
{
    public interface IStatusFormat
    {
        string GenerateStatusFormat(IStatusFormatterStrategy i_Formatter);
    }
}
