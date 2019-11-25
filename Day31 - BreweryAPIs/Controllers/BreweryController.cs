using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day31___BreweryAPIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day31___BreweryAPIs.Controllers
{
    public class BreweryController : Controller
    {
        public async Task<IActionResult> BreweryDisplay()
        {
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com");
			client.DefaultRequestHeaders.Add("x-rapidapi-host", "brianiswu-open-brewery-db-v1.p.rapidapi.com");
			client.DefaultRequestHeaders.Add("x-rapidapi-key", "5af33fb94bmsh7aeadc710975fddp1a19b0jsn83b9c278c91c");

			var response = await client.GetAsync("/breweries");
			var brewery = await response.Content.ReadAsAsync<List<Brew>>();

			return View(brewery);
        }
		public async Task<IActionResult> DisplayByState(string state)
		{
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com");
			client.DefaultRequestHeaders.Add("x-rapidapi-host", "brianiswu-open-brewery-db-v1.p.rapidapi.com");
			client.DefaultRequestHeaders.Add("x-rapidapi-key", "5af33fb94bmsh7aeadc710975fddp1a19b0jsn83b9c278c91c");

			var response = await client.GetAsync($"/breweries?by_state={state}");
			var brewery = await response.Content.ReadAsAsync<List<Brew>>();
			
			return View(brewery);
		}
	}
}