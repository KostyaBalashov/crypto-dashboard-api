using System.Security.Cryptography;
using System.Text;

namespace CryptoDashboard.Datalayer.Coinbase.Signer
{
    internal class CoinbaseApiKeySigner : IApiKeySigner
    {
        public string Signe(string epoch, string httpMethod, string requestPath, string body, string secret)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
            var t = hmac.ComputeHash(Encoding.UTF8.GetBytes(epoch + httpMethod + requestPath + body));
            return Convert.ToHexString(t).ToLowerInvariant();
        }
    }
}
