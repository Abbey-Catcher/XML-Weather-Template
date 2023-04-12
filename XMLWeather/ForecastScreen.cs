﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            conditionsLabel.Text = Form1.days[1].condition;
            max1.Text = Form1.days[1].tempHigh;
            min1.Text = Form1.days[1].tempLow;

            date1.Text = Form1.days[2].date;
            conditionsLabel.Text = Form1.days[2].condition;
            max1.Text = Form1.days[2].tempHigh;
            min1.Text = Form1.days[2].tempLow;

            date1.Text = Form1.days[3].date;
            conditionsLabel.Text = Form1.days[3].condition;
            max1.Text = Form1.days[3].tempHigh;
            min1.Text = Form1.days[3].tempLow;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
