namespace UrlShortener.Services
{
    public class ShortUrlService : IShortUrlService
    {
        private readonly Random _random = new Random();

        public string GenerateUniqueCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] code = new char[6];

            for (int i = 0; i < 6; i++)
            {
                code[i] = chars[_random.Next(chars.Length)];
            }

            string result = new string(code);
            return result;
        }

        public bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
