using System.Security.Cryptography;
using System.Text;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Signer
{
    internal class CoinbaseApiKeySigner : IApiKeySigner
    {
        public string Signe(string epoch, string httpMethod, string requestPath, string body, string secret)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(epoch + httpMethod + requestPath + body));

            return Convert.ToHexString(computedHash).ToLowerInvariant();
        }
    }
}
