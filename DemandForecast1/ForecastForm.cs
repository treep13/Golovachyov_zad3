using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace DemandForecast // ← Исправил!
{
    public partial class ForecastForm : Form
    {
        public ForecastForm()
        {
            InitializeComponent();
        }

        private void ForecastForm_Load(object sender, EventArgs e)
        {
            var plotView = new PlotView
            {
                Dock = DockStyle.Fill
            };

            var model = new PlotModel { Title = "Прогноз спроса по месяцам" };

            var lineSeries = new LineSeries
            {
                Title = "Спрос",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Blue
            };

            lineSeries.Points.Add(new DataPoint(0, 100));
            lineSeries.Points.Add(new DataPoint(1, 120));
            lineSeries.Points.Add(new DataPoint(2, 150));
            lineSeries.Points.Add(new DataPoint(3, 170));
            lineSeries.Points.Add(new DataPoint(4, 200));

            model.Series.Add(lineSeries);
            plotView.Model = model;

            this.Controls.Add(plotView);
        }
    }
}
