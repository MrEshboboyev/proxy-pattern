using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    private readonly IImageService _imageService;

    public ImageController()
    {
        _imageService = new ProxyImageService(); // Using proxy instead of real service
    }

    [HttpGet("get")]
    public IActionResult GetImage(string imageUrl, string userRole)
    {
        string result = _imageService.GetImage(imageUrl, userRole);
        return Ok(result);
    }
}
