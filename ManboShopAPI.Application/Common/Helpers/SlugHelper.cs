using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

public static class SlugHelper
{
	public static string ConvertToSlug(string text)
	{
		// Chuyển về chữ thường
		text = text.ToLower();

		// Chuyển đổi các ký tự có dấu thành không dấu
		string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
								  "đ",
								  "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
								  "í","ì","ỉ","ĩ","ị",
								  "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
								  "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
								  "ý","ỳ","ỷ","ỹ","ỵ"};

		string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
								  "d",
								  "e","e","e","e","e","e","e","e","e","e","e",
								  "i","i","i","i","i",
								  "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
								  "u","u","u","u","u","u","u","u","u","u","u",
								  "y","y","y","y","y"};

		// Thay thế từng ký tự có dấu
		for (int i = 0; i < arr1.Length; i++)
		{
			text = text.Replace(arr1[i], arr2[i]);
		}

		// Thay thế khoảng trắng bằng dấu gạch ngang
		text = text.Replace(" ", "-");

		// Loại bỏ các ký tự đặc biệt
		text = Regex.Replace(text, "[^a-z0-9-]", "");

		// Loại bỏ các dấu gạch ngang liên tiếp
		text = Regex.Replace(text, "-+", "-");

		// Loại bỏ dấu gạch ngang ở đầu và cuối
		text = text.Trim('-');

		return text;
	}
}
