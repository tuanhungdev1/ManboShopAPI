using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
