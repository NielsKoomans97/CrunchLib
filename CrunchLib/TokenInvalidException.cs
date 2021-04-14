using System;

namespace CrunchLib
{
    public class TokenInvalidException : Exception
    {
        #region Public Constructors

        public TokenInvalidException(string errorMessage, int errorCode)
        {
            ErrorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
            ErrorCode = errorCode;
        }

        #endregion Public Constructors

        #region Public Properties

        public string ErrorMessage { get; }
        public int ErrorCode { get; }

        #endregion Public Properties
    }
}