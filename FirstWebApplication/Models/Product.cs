using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstWebApplication.Models
{
	public class Player
	{
		public required string Id { get; set; }
		public required string Name { get; set; }
		[JsonPropertyName("img")]
		public required string Image { get; set; }
		public required string Country { get; set; }
		public required string Role { get; set; }
		public required string Description { get; set; }
		public required  string Url { get; set; }
		public override string ToString() => JsonSerializer.Serialize<Player>(this);

	}
}