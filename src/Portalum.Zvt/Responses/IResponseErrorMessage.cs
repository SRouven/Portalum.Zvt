namespace Portalum.Zvt.Responses
{
    public interface IResponseErrorMessage
    {
        string ErrorMessage { get; set; }
        int ErrorCode { get; set; }
    }
}
