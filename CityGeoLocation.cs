using System.Xml;
using System.Web;
using System.Windows.Forms;
using System.Globalization;

namespace Solar_ClockWork
{
	static class CityGeoLocation
	{
		public static decimal GoogleQuery(CCity city)
		{
			XmlDocument xDoc = new XmlDocument();

			xDoc.Load("http://maps.googleapis.com/maps/api/geocode/xml?address=" + city.CityName + "," + city.Country + "&sensor=false");

			NumberStyles style;
			CultureInfo culture;
			decimal number = 0;

			// Parse currency value using en-GB culture. 
			style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
			culture = CultureInfo.CreateSpecificCulture("en-GB");
			decimal.TryParse(xDoc.SelectSingleNode("GeocodeResponse/result/geometry/location/lat").InnerText, style, culture, out number);
		
			return number;
		}

		private static string GeocoderKey()
		{
			return "AIzaSyCJVayoUGMkcRghSUxWxgslI7noa0st0qQ";
		}
	}
}
