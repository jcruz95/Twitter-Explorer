using System;
using Newtonsoft.Json;

namespace wildwood
{
	public class Tweet : Entity
	{
		[JsonProperty("text")]
		public string Text { get; set; }

		[JsonProperty("user")]
		public TwitterUser User { get; set; }
	}
}
