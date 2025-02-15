using Domain.Interfaces;

namespace Infrastructure.Services;

public class RealImageService : IImageService
{
    public string GetImage(string imageUrl, string userRole)
    {
        Console.WriteLine($"📷 Fetching image from server: {imageUrl}");
        return $"https://secure-cdn.com/{imageUrl}";
    }
}
