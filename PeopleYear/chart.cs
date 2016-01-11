using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PeopleYear
{
    public partial class chart : Form
    {
        int numberOfPeople;
        int yearAlive;
        public chart()
        {
           
            InitializeComponent();
        }
        public chart(int num, int year)
        {
            numberOfPeople = num;
            yearAlive = year;
            InitializeComponent();
        }

        private void chart1_Load(object sender, EventArgs e)
        {
           
            var listOfPeople = new People().GetPopleFromTextFile();
            var list = new List<int>();
          // chart1.BackColor=System.Drawing.Color.Black; 
            chart1.Titles.Add("People Alive");
            foreach (var person in listOfPeople)
            {
                 list.Add(person.end);
                // Add point.
                
            }
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Age",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Bar
            };
              this.chart1.Series.Add(series1);
          
            foreach (var person in listOfPeople)
            {
                int age = person.end - person.Birth;

                series1.Points.AddXY(person.end, age);
                              
            }
     
        }
    }
}
