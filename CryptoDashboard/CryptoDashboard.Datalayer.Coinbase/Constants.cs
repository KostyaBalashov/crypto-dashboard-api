namespace CryptoDashboard.Datalayer.Coinbase
{
    internal static class Constants
    {
        #region CONFIGURATION
        public const string COINBASE_SECTION = "CoinbaseApiKeyConfiguration";

        public const string COIBASE_KEY = $"{COINBASE_SECTION}:key";

        public const string COINBASE_SECRET = $"{COINBASE_SECTION}:secret";

        public const string COINBASE_BASE_URL = $"{COINBASE_SECTION}:baseUrl";

        public const string COINBASE_API_VERSION = $"{COINBASE_SECTION}:version";
        #endregion

        #region SEGMENTS
        public const string TIME_SEGMENT = "time";

        public const string ACCOUNTS_SEGMENT = "accounts"; 
        #endregion

    }
}
