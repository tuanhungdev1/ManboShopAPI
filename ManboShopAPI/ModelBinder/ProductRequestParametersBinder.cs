using ManboShopAPI.Application.Common.Request;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace ManboShopAPI.ModelBinder
{
	public class ProductRequestParametersBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			if (bindingContext == null)
			{
				throw new ArgumentNullException(nameof(bindingContext));
			}

			var request = bindingContext.HttpContext.Request;
			var parameters = new ProductRequestParameters();

			// Lấy giá trị từ query string
			if (request.Query.TryGetValue("Categories", out var categories))
			{
				parameters.Categories = categories.ToString().Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
			}

			if (request.Query.TryGetValue("Colors", out var colors))
			{
				parameters.Colors = colors.ToString().Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
			}

			if (request.Query.TryGetValue("Brands", out var brands))
			{
				parameters.Brands = brands.ToString().Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
			}

			if (request.Query.TryGetValue("Sizes", out var sizes))
			{
				parameters.Sizes = sizes.ToString().Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
			}

			// Xử lý PriceRange (min-max)
			if (request.Query.TryGetValue("PriceRange", out var priceRangeString))
			{
				var rangeParts = priceRangeString.ToString().Split('-');
				if (rangeParts.Length == 2 && int.TryParse(rangeParts[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out int min) && int.TryParse(rangeParts[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out int max))
				{
					parameters.PriceRange = $"{min}-{max}";
				}
			}

			bindingContext.Result = ModelBindingResult.Success(parameters);
			return Task.CompletedTask;
		}
	}

}
