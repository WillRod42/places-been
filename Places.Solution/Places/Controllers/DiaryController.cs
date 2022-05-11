using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
	public class DiaryController : Controller
	{
		[HttpGet("/diary")]
		public ActionResult Index()
		{
			List<Place> allPlaces = Place.GetPlaces();
			return View(allPlaces);
		}

		[HttpGet("/diary/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/diary")]
		public ActionResult Create(string cityname, int days, string journal)
		{
			new Place(cityname, days, journal);
			return RedirectToAction("Index");
		}

		[HttpGet("/diary/{cityName}")]
		public ActionResult Show(string cityName)
		{
			List<Place> places = Place.Find(cityName);
			return View(places);
		}
	}
}
