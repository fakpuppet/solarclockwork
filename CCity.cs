using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solar_ClockWork
{
	public class CCity
	{
		private string _cityName;
		private decimal _latitude;
		private decimal _longitude;

		public string CityName { get { return _cityName; } set { _cityName = value; } }
		public string Country { get; set; }

		public CCity(string city, string country)
		{
			this.CityName = city;
			this.Country = country;
		}

		public override string ToString()
		{
			return _cityName;
		}
	}
}
