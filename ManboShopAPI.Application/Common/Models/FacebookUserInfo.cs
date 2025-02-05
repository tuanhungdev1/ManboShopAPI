using Newtonsoft.Json;

namespace ManboShopAPI.Application.Common.Models
{
	public class FacebookCredential
	{
		[JsonProperty("accessToken")]
		public string AccessToken { get; set; }

		[JsonProperty("userID")]
		public string UserId { get; set; }

		[JsonProperty("expiresIn")]
		public int ExpiresIn { get; set; }
	}

	public class FacebookUserInfo
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("picture")]
		public FacebookPicture Picture { get; set; }
	}

	public class FacebookPicture
	{
		[JsonProperty("data")]
		public FacebookPictureData Data { get; set; }
	}

	public class FacebookPictureData
	{
		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
