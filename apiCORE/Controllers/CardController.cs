using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiCORE.Models;

namespace apiCORE.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NewDeck() //Started with Deck, stumbled into drawing a new hand instead.
        {
            //Two actions in one.

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://deckofcardsapi.com");

            var response = await client.GetAsync("/api/deck/new");

            Deck values = await response.Content.ReadAsAsync<Deck>();

            response = await client.GetAsync($"/api/deck/{values.deck_id}/draw/?count=5");

            Card handoffive = await response.Content.ReadAsAsync<Card>();

            return View(handoffive);
        }

        public async Task<IActionResult> Draw5(string deck_id)
        {
            //If I wanted to draw 5 when button pressed.
            return View();
        }
    }
}
