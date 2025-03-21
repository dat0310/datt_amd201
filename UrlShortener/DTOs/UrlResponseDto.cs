namespace UrlShortener.DTOs
{
    public class UrlResponseDto
    {
        public string OriginalUrl { get; set; } = null!;
        public string ShortUrl { get; set; } = null!;
    }
}