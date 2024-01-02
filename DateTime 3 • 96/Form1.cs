using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_3___96
{
    public partial class Form1 : Form
    {
        DateTime bugun = DateTime.Now; //Global olarak tanımladık.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            lblDate.Text = bugun.Date.ToString();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            lblMonth.Text = bugun.Month.ToString();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            lblDay.Text = bugun.Day.ToString();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            lblYear.Text = bugun.Year.ToString();
        }

        private void btnDayOfWeek_Click(object sender, EventArgs e)
        {
            lblDayOfWeek.Text = bugun.DayOfWeek.ToString();
        }

        private void btnDayOfYear_Click(object sender, EventArgs e)
        {
            lblDayOfYear.Text = bugun.DayOfYear.ToString();
        }

        private void btnTimeOfDay_Click(object sender, EventArgs e)
        {
            lblTimeOfDay.Text = bugun.TimeOfDay.ToString();
        }

        private void btnHour_Click(object sender, EventArgs e)
        {
            lblHour.Text = bugun.Hour.ToString();
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            lblMinute.Text = bugun.Minute.ToString();
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            lblSecond.Text = bugun.Second.ToString();
        }

        private void btnMilliSecond_Click(object sender, EventArgs e)
        {
            lblMilliSecond.Text = bugun.Millisecond.ToString();
        }

        private void btnTicks_Click(object sender, EventArgs e)
        {
            lblTicks.Text = bugun.Ticks.ToString();
        }
    }
}
