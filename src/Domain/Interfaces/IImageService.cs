namespace Domain.Interfaces;

public interface IImageService
{
    string GetImage(string imageUrl, string userRole);
}
