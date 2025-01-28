namespace ManboShopAPI.Domain.Exceptions.NotFound
{


	public sealed class CategoryNotFoundException : NotFoundException
	{
		public CategoryNotFoundException(int categoryId)
		: base($"Không tìm thấy danh mục với Id: {categoryId} tồn tại trong cơ sở dữ liệu.") 
		{
		}

        public CategoryNotFoundException(string message) : base(message)
        {
            
        }
    }
}
