using System;
using Newtonsoft.Json;

namespace wildwood
{
	public class TwitterUser : Entity
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("screen_name")]
		public string ScreenName { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("profile_image_url")]
		public string ProfileImageUrl { get; set; }
	}
}
