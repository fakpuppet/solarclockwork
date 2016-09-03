namespace Solar_ClockWork
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.dateCurrent = new System.Windows.Forms.DateTimePicker();
			this.chartDayLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.txtLatitude = new System.Windows.Forms.TextBox();
			this.lstGL = new System.Windows.Forms.CList();
			this.btnFindGeoposition = new System.Windows.Forms.Button();
			this.cbCity = new System.Windows.Forms.CImageComboBox();
			((System.ComponentModel.ISupportInitialize)(this.chartDayLength)).BeginInit();
			this.SuspendLayout();
			// 
			// dateCurrent
			// 
			this.dateCurrent.Location = new System.Drawing.Point(829, 12);
			this.dateCurrent.Name = "dateCurrent";
			this.dateCurrent.Size = new System.Drawing.Size(200, 20);
			this.dateCurrent.TabIndex = 1;
			this.dateCurrent.ValueChanged += new System.EventHandler(this.dateCurrent_ValueChanged);
			// 
			// chartDayLength
			// 
			this.chartDayLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
			chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
			chartArea3.AxisX.IsLabelAutoFit = false;
			chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea3.AxisX.LabelStyle.Interval = 0D;
			chartArea3.AxisX.LabelStyle.TruncatedLabels = true;
			chartArea3.AxisX.LineColor = System.Drawing.Color.DimGray;
			chartArea3.AxisX.MajorGrid.Interval = 120D;
			chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
			chartArea3.AxisX.MajorTickMark.Interval = 30D;
			chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
			chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea3.AxisX.MinorTickMark.Enabled = true;
			chartArea3.AxisX.MinorTickMark.Interval = 30D;
			chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea3.AxisX2.MajorGrid.Interval = 1D;
			chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
			chartArea3.AxisY.IsLabelAutoFit = false;
			chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea3.AxisY.LineColor = System.Drawing.Color.DimGray;
			chartArea3.AxisY.MajorGrid.Interval = 1D;
			chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
			chartArea3.AxisY.MajorTickMark.Interval = 1D;
			chartArea3.AxisY.MaximumAutoSize = 5F;
			chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
			chartArea3.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea3.IsSameFontSizeForAllAxes = true;
			chartArea3.Name = "CA";
			this.chartDayLength.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chartDayLength.Legends.Add(legend3);
			this.chartDayLength.Location = new System.Drawing.Point(148, 42);
			this.chartDayLength.Name = "chartDayLength";
			this.chartDayLength.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			this.chartDayLength.Size = new System.Drawing.Size(881, 564);
			this.chartDayLength.TabIndex = 2;
			this.chartDayLength.Text = "Dnevni ciklus";
			// 
			// txtLatitude
			// 
			this.txtLatitude.Location = new System.Drawing.Point(12, 15);
			this.txtLatitude.Name = "txtLatitude";
			this.txtLatitude.Size = new System.Drawing.Size(130, 20);
			this.txtLatitude.TabIndex = 3;
			this.txtLatitude.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLatitude_KeyUp);
			// 
			// lstGL
			// 
			this.lstGL.Data = null;
			this.lstGL.DontRefreshViewOnAddData = false;
			this.lstGL.FullRowSelect = true;
			this.lstGL.IconFormatter = null;
			this.lstGL.Location = new System.Drawing.Point(12, 42);
			this.lstGL.Name = "lstGL";
			this.lstGL.RowHeight = 32;
			this.lstGL.Rows = ((System.Collections.Generic.List<System.Windows.Forms.ListViewItem>)(resources.GetObject("lstGL.Rows")));
			this.lstGL.ShowHorizontalScrollbar = false;
			this.lstGL.Size = new System.Drawing.Size(130, 564);
			this.lstGL.SpringColumn = null;
			this.lstGL.TabIndex = 5;
			this.lstGL.UseCompatibleStateImageBehavior = false;
			this.lstGL.View = System.Windows.Forms.View.Details;
			this.lstGL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstGL_KeyUp);
			this.lstGL.Layout += new System.Windows.Forms.LayoutEventHandler(this.lstGL_Layout);
			// 
			// btnFindGeoposition
			// 
			this.btnFindGeoposition.Location = new System.Drawing.Point(359, 11);
			this.btnFindGeoposition.Name = "btnFindGeoposition";
			this.btnFindGeoposition.Size = new System.Drawing.Size(165, 23);
			this.btnFindGeoposition.TabIndex = 6;
			this.btnFindGeoposition.Text = "Dodaj geografsku sirinu";
			this.btnFindGeoposition.UseVisualStyleBackColor = true;
			this.btnFindGeoposition.Click += new System.EventHandler(this.btnFindGeoposition_Click);
			// 
			// cbCity
			// 
			this.cbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCity.FormattingEnabled = true;
			this.cbCity.ImageList = null;
			this.cbCity.Keyword = null;
			this.cbCity.Location = new System.Drawing.Point(148, 13);
			this.cbCity.Name = "cbCity";
			this.cbCity.Size = new System.Drawing.Size(205, 21);
			this.cbCity.TabIndex = 7;
			this.cbCity.TextAlign = System.Drawing.StringAlignment.Near;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1041, 664);
			this.Controls.Add(this.cbCity);
			this.Controls.Add(this.btnFindGeoposition);
			this.Controls.Add(this.lstGL);
			this.Controls.Add(this.txtLatitude);
			this.Controls.Add(this.chartDayLength);
			this.Controls.Add(this.dateCurrent);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Solar ClockWork";
			((System.ComponentModel.ISupportInitialize)(this.chartDayLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateCurrent;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDayLength;
		private System.Windows.Forms.TextBox txtLatitude;
		private System.Windows.Forms.CList lstGL;
		private System.Windows.Forms.Button btnFindGeoposition;
		private System.Windows.Forms.CImageComboBox cbCity;
	}
}

