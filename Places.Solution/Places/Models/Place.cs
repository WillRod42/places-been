using System;
using System.Collections.Generic;

namespace Places.Models
{
	public class Place
	{
		public string CityName { get; }
		public int DaysStayed { get; }
		public string JournalEntry { get; }

		private static List<Place> _places = new List<Place>();
		private static HashSet<string> _cityNames = new HashSet<string>();

		public Place(string cityName, int daysStayed, string journalEntry)
		{
			CityName = cityName;
			DaysStayed = daysStayed;
			JournalEntry = journalEntry;
			_places.Add(this);
			_cityNames.Add(cityName);
		}

		public static List<Place> GetPlaces()
		{
			return _places;
		}

		public static List<Place> Find(string cityName)
		{
			List<Place> places = new List<Place>();
			foreach (Place place in _places)
			{
				if (place.CityName == cityName)
				{
					places.Add(place);
				}
			}

			return places;
		}

		public static HashSet<string> GetCityNames()
		{
			return _cityNames;
		}
	}
}
