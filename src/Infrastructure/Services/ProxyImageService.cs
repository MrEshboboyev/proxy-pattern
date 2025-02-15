using Application.Services;
using Domain.Interfaces;

namespace Infrastructure.Services;

public class ProxyImageService : IImageService
{
    private readonly RealImageService _realImageService;
    private readonly ImageAuthorizationService _authService;
    private static readonly Dictionary<string, string> _cache = [];

    public ProxyImageService()
    {
        _realImageService = new RealImageService();
        _authService = new ImageAuthorizationService();
    }

    public string GetImage(string imageUrl, string userRole)
    {
        Console.WriteLine($"🔍 Proxy: Checking access for {imageUrl}");

        // Authorization check
        if (!_authService.IsUserAuthorized(userRole, imageUrl))
        {
            Console.WriteLine("❌ Access Denied: Unauthorized user.");
            return "Access Denied";
        }

        // Check if image is cached
        if (_cache.TryGetValue(imageUrl, out string? value))
        {
            Console.WriteLine($"🗂 Cache Hit: Returning cached image for {imageUrl}");
            return value;
        }

        // Fetch from real service and cache it
        string secureImageUrl = _realImageService.GetImage(imageUrl, userRole);
        _cache[imageUrl] = secureImageUrl;
        return secureImageUrl;
    }
}
