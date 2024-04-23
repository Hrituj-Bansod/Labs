using FirstWebApplication.Models;
using FirstWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApplication.Pages
{
    public class IndexModel( JsonFileProductService jsonfileproductservice) : PageModel
    {
        public JsonFileProductService ProductService { get; set; } = jsonfileproductservice;
        public IEnumerable<Player>? Players { get; private set; }

		public void OnGet()
        {
            Players = ProductService.GetPlayers();
        }
    }
}
