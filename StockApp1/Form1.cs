using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //change
        
            Series price = new Series("price");
            chart1.Series.Add(price);

            chart1.Series["price"].ChartType = SeriesChartType.Candlestick;

            // Set the style of the open-close marks
            chart1.Series["price"]["OpenCloseStyle"] = "Triangle";

            // Show both open and close marks
            chart1.Series["price"]["ShowOpenClose"] = "Both";

            // Set point width
            chart1.Series["price"]["PointWidth"] = "1.0";

            // Set colors bars
            chart1.Series[0]["PriceUpColor"] = "Green";
            chart1.Series[0]["PriceDownColor"] = "Red";
            
            // adding date and high
            chart1.Series["price"].Points.AddXY("time", 10.5);
            // adding low
            chart1.Series["price"].Points[0].YValues[1] = 8.3;
            //adding open
            chart1.Series["price"].Points[0].YValues[2] = 9;
            // adding close
            chart1.Series["price"].Points[0].YValues[3] = 9.7;
        }
    }
}
