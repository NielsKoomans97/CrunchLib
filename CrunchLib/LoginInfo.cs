using Newtonsoft.Json;

namespace CrunchLib
{
    public class LoginInfo
    {
        #region Public Constructors

        public LoginInfo(string account, string password)
        {
            Account = account;
            Password = password;
        }

        #endregion Public Constructors

        #region Public Properties

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        #endregion Public Properties
    }
}