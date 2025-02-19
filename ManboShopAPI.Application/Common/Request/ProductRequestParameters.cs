using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace ManboShopAPI.Application.Common.Request
{
	[ModelBinder(BinderType = typeof(ProductRequestParametersBinder))]
	public class ProductRequestParameters : RequestParameters
	{
        public ICollection<string>? Brands { get; set; } = new List<string>();
        public ICollection<string>? Categories { get; set; } = new List<string>();
        public string? PriceRange { get; set; }  
        public ICollection<string>? Colors { get; set; } = new List<string>();
        public ICollection<string>? Sizes { get; set; } = new List<string>();
    }

    public class PriceRange
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 100000000;
    }

	public class ProductRequestParametersBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			if (bindingContext == null)
			{
				throw new ArgumentNullException(nameof(bindingContext));
			}
			// Lấy giá trị từ query string
			var request = bindingContext.HttpContext.Request;
			var parameters = new ProductRequestParameters();
            Console.WriteLine($"Query: {request.Query}");
            if (request.Query.TryGetValue("SearchTerm", out var searchTerm))
			{
				parameters.SearchTerm = searchTerm.ToString();
			}

			if (request.Query.TryGetValue("PageNumber", out var pageNumber))
			{
				parameters.PageNumber = int.Parse(pageNumber);
			}
			if(request.Query.TryGetValue("OrderBy", out var orderBy))
			{
				parameters.OrderBy = orderBy.ToString();
			}

			if (request.Query.TryGetValue("PageSize", out var pageSize))
			{
				parameters.PageSize = int.Parse(pageSize);
			}
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
