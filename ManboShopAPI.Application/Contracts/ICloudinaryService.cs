using Microsoft.AspNetCore.Http;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICloudinaryService
	{
		Task<string> UploadImageAsync(IFormFile file, string folder, string prefix);
		Task DeleteImageAsync(string publicId);
		Task<string> ReplaceImageAsync(IFormFile newFile, string oldPublicId, string folder, string prefix);
		string GetPublicIdFromUrl(string imageUrl);

		Task DeleteImagesAsync(List<string> imageUrls);
	

	}
}
