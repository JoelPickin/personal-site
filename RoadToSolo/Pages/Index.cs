using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Index
    {
        private DateTime leaveWorkDate = new DateTime(2022, 10, 01);
        private double daysLeftAtWork;

        private string revenue;

        private decimal savings = 7000;
        private double runway;

        protected override Task OnInitializedAsync()
        {
            InitializeDaysLeftAtWork();
            InitializeRevenue();
            InitializeRunway();

            return base.OnInitializedAsync();
        }

        public void InitializeDaysLeftAtWork()
        {
            daysLeftAtWork = Math.Round((leaveWorkDate - DateTime.Now).TotalDays);
        }

        private void InitializeRevenue()
        {
            revenue = "£0k";
        }

        private void InitializeRunway()
        {
            var runwayDecimal = savings / 1250;
            var rightDecimal = runwayDecimal % 1;
            var leftDecimal = decimal.ToInt16(runwayDecimal);
            var dayPercentage = decimal.ToInt16(rightDecimal * 100);
            decimal dayDivision = 30m / 100m;
            var dayAmount = decimal.ToInt16(dayDivision * dayPercentage);
            var monthCount = leaveWorkDate.Month + leftDecimal;
            var month = monthCount % 12;

            var newDate = new DateTime(leaveWorkDate.Year, month, leaveWorkDate.Day + dayAmount);

            runway = Math.Round((leaveWorkDate - newDate).TotalDays);        
        }
    }
}
