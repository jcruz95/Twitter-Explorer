using System;
using Newtonsoft.Json;

namespace wildwood
{
	public class Entity
	{
		[JsonProperty("id_str")]
		public string Id { get; set; }
	}
}
