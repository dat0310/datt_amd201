namespace UrlShortener.Services
{
    public interface IShortUrlService
    {
        string GenerateUniqueCode();
        bool IsValidUrl(string url);
    }
}
