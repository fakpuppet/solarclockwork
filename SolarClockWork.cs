using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solar_ClockWork
{

	public class SolarClockWork
	{
		private DateTime m_currentDate;
		private TimeSpan m_dayLength;
		private double m_latitude;
		private double m_radianLatitude;
		private double m_radialVelocity = 2 * Math.PI / 365.24; 
		private double m_axisTilt = (23.79/180) * Math.PI;
		private double m_phi;

		public SolarClockWork(double latitude)
		{
			m_latitude = latitude;
			m_radianLatitude = Math.PI * (latitude / 180);

			m_phi = Math.Tan(m_radianLatitude) * Math.Tan(m_axisTilt);

			m_phi = m_phi * m_phi;
		}

		public double Latitude
		{
			get { return m_latitude; }
			set {
				m_latitude = value;
				m_radianLatitude = Math.PI * (value / 180);
				m_phi = Math.Tan(m_radianLatitude) * Math.Tan(m_axisTilt);
				m_phi = m_phi * m_phi;

			}
		}

		public DateTime CurrentDate
		{
			get { return m_currentDate; }
			set { m_currentDate = value; }
		}

		public TimeSpan DayLength(DateTime curdate)
		{
			double t = 0;
			double timeFromLongest = (curdate - new DateTime(curdate.Year - 1, 6, 21)).TotalDays;


			t = 24 - (24 / (2 * Math.PI)) * Math.Acos(m_phi - 1 + m_phi * Math.Cos(2 * m_radialVelocity * timeFromLongest));

			if (Math.Cos(m_radialVelocity * timeFromLongest) <= 0)
			{
				t = 24 - t;
			}

			if (!double.IsNaN(t))
			{
				return TimeSpan.FromHours(t);
			}
			else
			{
				return TimeSpan.FromHours((double)-1);
			}
		}
	}
}
