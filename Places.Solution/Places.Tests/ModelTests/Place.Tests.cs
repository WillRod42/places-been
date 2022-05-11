using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System;
using System.Collections.Generic;

namespace Places.Tests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void Place_CreateNewInstanceOfClass_NewPlace()
		{
			Place newPlace = new Place();
			Assert.AreEqual(typeof(Place),  newPlace.GetType());
		}
	}
}
