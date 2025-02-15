namespace Application.Services;

public class ImageAuthorizationService
{
    private readonly HashSet<string> _restrictedImages = 
        ["premium-product.jpg", "exclusive-item.png"];

    public bool IsUserAuthorized(string userRole, string imageUrl)
    {
        if (userRole == "admin") return true;

        if (_restrictedImages.Contains(imageUrl))
        {
            Console.WriteLine($"🚨 Unauthorized Access Attempt: {imageUrl} requires premium access.");
            return false;
        }

        return true;
    }
}
