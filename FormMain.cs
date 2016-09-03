using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Solar_ClockWork
{
	public partial class FormMain : Form
	{
		private SolarClockWork m_scw = new SolarClockWork(45);

		public FormMain()
		{
			InitializeComponent();
			this.Font = SystemInformation.MenuFont;
			m_extremumi = new List<DataPoint>();
			LoadCities();
			AddDayGraph(45);
			lstGL.AddColumn("colGeografskaSirina", "Geografska Širina", 30).IsSpringColumn = true;
		}

		private void LoadCities()
		{
			cbCity.Add(new CCity("Belgrade", "Serbia"));
			cbCity.Add(new CCity("London", "UK"));
			cbCity.Add(new CCity("Los Angeles", "USA"));
		}

		private void AddDayGraph(double latitude)
		{
			Series ser = new Series();
			ser.Font = new Font(this.Font.FontFamily, 7.0f);
			
			chartDayLength.Series.Add(ser);
			lstGL.Items.Add(latitude.ToString()).Tag = ser;

			ser.LegendToolTip = "Dnevni ciklus za geografsku širinu: " + latitude.ToString();
			ser.LegendText = string.Format("GŠ {0} stepeni", latitude);
			
			ser.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
			ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			DateTime startDate = new DateTime(2014, 1, 1);

			for (int i = 1; i <= 2 * 365; i++)
			{
				double daylen = m_scw.DayLength(startDate.AddDays(i)).TotalHours;

				if (daylen > -1)
				{
					// int pnt = ser.Points.AddXY(startDate.AddDays(i).ToString("dd.MM.yyyy"), daylen);
					int pnt = ser.Points.AddXY(i, daylen);
				}
			}

			for (int i = 1; i < ser.Points.Count - 1; i++)
			{
				var pt = ser.Points[i];
				double yval = pt.YValues[0];
				var ts = TimeSpan.FromHours((double)yval);

				if (yval > ser.Points[i - 1].YValues[0] && yval > ser.Points[i + 1].YValues[0])
				{
					//if (!m_extremumi.Contains(pt))
					m_extremumi.Add(pt);

					pt.MarkerStyle = MarkerStyle.Circle;
					pt.MarkerSize = 10;
					pt.Label = string.Format("Najduži dan - {0} sati {1} minuta", ts.Hours, ts.Minutes);
					pt.ToolTip = string.Format("Najduži dan {2:dd.MM.yyyy}, {0} sati {1} minuta", ts.Hours, ts.Minutes, new DateTime(2014, 1, 1).AddDays(pt.XValue));
				}
				else if (yval < ser.Points[i - 1].YValues[0] && yval < ser.Points[i + 1].YValues[0])
				{
					//if (!m_extremumi.Contains(pt))
					m_extremumi.Add(pt);

					pt.MarkerStyle = MarkerStyle.Circle;
					pt.MarkerColor = Color.Red;
					pt.MarkerSize = 10;
					pt.Label = string.Format("Najkraći dan - {0} sati {1} minuta", ts.Hours, ts.Minutes);
					pt.ToolTip = string.Format("Najkraći dan {2:dd.MM.yyyy}, {0} sati {1} minuta", ts.Hours, ts.Minutes, new DateTime(2014, 1, 1).AddDays(pt.XValue));
				}
			}
		}

		int m_day;
		Series m_lastSeries;
		List<DataPoint> m_extremumi;

		private void AddSingleDayGraph(DateTime date)
		{
			if (m_lastSeries != null)
				chartDayLength.Series.Remove(m_lastSeries);

			foreach (Series se in chartDayLength.Series)
			{
				if (!m_extremumi.Contains(se.Points[m_day]))
					se.Points[m_day].SetDefault(true);
			}

			m_lastSeries = null;
			Series s = new Series();
			s.Font = new System.Drawing.Font(this.Font.FontFamily, 7.0f);

			s.ChartType = SeriesChartType.BoxPlot;

			int day = date.DayOfYear;
			TimeSpan ts = m_scw.DayLength(date);
			int pt = s.Points.AddXY(day, ts.TotalHours);

			DataPoint p = s.Points[pt];
			p.MarkerStyle = MarkerStyle.Star10;
			p.MarkerSize = 10;
			//p.Label = string.Format("Dužina dana {2:dd.MM.yyyy} - {0} sati {1} minuta", ts.Hours, ts.Minutes, date);

			m_lastSeries = s;

			foreach (Series se in chartDayLength.Series)
			{
				DataPoint po = se.Points[day - 1];
				if (!m_extremumi.Contains(se.Points[day - 1]))
				{
					po.MarkerStyle = MarkerStyle.Star10;
					po.MarkerSize = 10;
					po.Label = string.Format("Dužina dana {1:dd.MM.yyyy} - {0}", TimeSpan.FromHours(po.YValues[0]).ToString("hh\\:mm"), date);
				}
			}
			
			m_day = day-1;

			chartDayLength.Series.Add(s);
		}

		private void dateCurrent_ValueChanged(object sender, EventArgs e)
		{
			//lblDuration.Text = m_scw.DayLength(dateCurrent.Value).TotalHours.ToString();
			AddSingleDayGraph(dateCurrent.Value);
		}

		private void btnAddLatitude_Click(object sender, EventArgs e)
		{
			m_scw.Latitude = Convert.ToDouble(txtLatitude.Text);
			AddDayGraph(m_scw.Latitude);
			// txtLatitude.Text = "";
		}

		private void lstGL_Layout(object sender, LayoutEventArgs e)
		{

		}

		private void lstGL_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Da li da obrisem", "Potvrda", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes) return;
				if (lstGL.SelectedItems.Count > 0)
				{
					ListViewItem it = lstGL.SelectedItems[0];
					chartDayLength.Series.Remove(it.Tag as Series);
					it.Remove();
				}
			}
		}

		private void txtLatitude_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				btnAddLatitude_Click(null, null);
		}

		private void btnFindGeoposition_Click(object sender, EventArgs e)
		{
			txtLatitude.Text =  CityGeoLocation.GoogleQuery(cbCity.SelectedDropdownItem.Value as CCity).ToString();
			btnAddLatitude_Click(null, null);
		}
	}
}
