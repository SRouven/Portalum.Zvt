﻿namespace Portalum.Zvt.Responses
{
    public interface IResponseErrorMessage
    {
        string ErrorMessage { get; set; }
        byte ErrorCode { get; set; }
    }
}
