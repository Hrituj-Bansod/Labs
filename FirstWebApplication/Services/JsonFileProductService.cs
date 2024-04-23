using FirstWebApplication.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace FirstWebApplication.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Players.json"); }
        }

        public IEnumerable<Player> GetPlayers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {

#pragma warning disable CS8603 // Possible null reference return.
				return JsonSerializer.Deserialize<Player[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
#pragma warning restore CS8603 // Possible null reference return.

			}
        }
    }
}
