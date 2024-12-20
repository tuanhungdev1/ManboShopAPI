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

		// New multiple image methods
		Task<IEnumerable<string>> UploadImagesAsync(IEnumerable<IFormFile> files, string folder, string prefix);
		Task DeleteImagesAsync(IEnumerable<string> publicIds);
		Task<IEnumerable<string>> ReplaceImagesAsync(IEnumerable<IFormFile> newFiles, IEnumerable<string> oldPublicIds, string folder, string prefix);
	}
}
