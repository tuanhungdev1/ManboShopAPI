using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ManboShopAPI.Application.Common.Response;

namespace ManboShopAPI.Filters
{
	public class ValidationFilterAttribute : ActionFilterAttribute
	{
		public void OnActionExecuting(ActionExecutingContext context)
		{
			var action = context.RouteData.Values["action"];
			var controller = context.RouteData.Values["controller"];

			// Kiểm tra xem có tham số nào chứa "Dto" không
			var param = context.ActionArguments
				.FirstOrDefault(x => x.Value?.ToString()?.Contains("Dto") == true).Value;

			// Nếu action có tham số nhưng không có tham số chứa "Dto", trả về lỗi BadRequest
			if (context.ActionArguments.Count > 0 && param == null)
			{
				context.Result = new BadRequestObjectResult(new ApiResponse<object>
				{
					StatusCode = 400,
					Success = false,
					Message = $"Object is null. Controller: {controller}, action: {action}",
					Errors = new List<string> { "Invalid DTO object" }
				});
				return;
			}

			// Nếu model không hợp lệ, trả về lỗi BadRequest với chi tiết
			if (!context.ModelState.IsValid)
			{
				var errors = context.ModelState.Values
					.SelectMany(v => v.Errors)
					.Select(e => e.ErrorMessage)
					.ToList();

				context.Result = new BadRequestObjectResult(new ApiResponse<object>
				{
					StatusCode = 400,
					Success = false,
					Message = "Thông tin không hợp lệ vui lòng kiểm tra lại.",
					Errors = errors
				});
			}
		}

		public void OnActionExecuted(ActionExecutedContext context) { }
	}
}
