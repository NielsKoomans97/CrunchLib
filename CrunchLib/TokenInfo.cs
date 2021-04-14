using System;

namespace CrunchLib
{
    public class TokenInfo
    {
        #region Public Constructors

        public TokenInfo(string sessionId, DateTime sessionExpires, string authToken, DateTime authExpires, dynamic account)
        {
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
            SessionExpires = sessionExpires;
            AuthToken = authToken ?? throw new ArgumentNullException(nameof(authToken));
            AuthExpires = authExpires;
            Account = account;
        }

        #endregion Public Constructors

        #region Public Properties

        public string SessionId { get; set; }
        public DateTime SessionExpires { get; set; }
        public string AuthToken { get; set; }
        public DateTime AuthExpires { get; set; }
        public dynamic Account { get; set; }

        #endregion Public Properties
    }
}