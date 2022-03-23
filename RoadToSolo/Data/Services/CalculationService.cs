using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Services
{
    public class CalculationService
    {
        private DateTime leaveWorkDate = new DateTime(2022, 10, 01);
        private double daysLeftAtWork;

        private string revenue = "£0k";

        private decimal savings;
        private decimal currentSavings = 9500;
        private decimal monthlySavings = 1500;
        private double runway;

        public CalculationService()
        {
            
        }

        public double GetDaysLeftAtWork()
        {
            daysLeftAtWork = Math.Round((leaveWorkDate - DateTime.Now).TotalDays);

            return daysLeftAtWork;
        }

        public string GetRevenue()
        {
            return revenue;
        }

        public double GetRunwayDays()
        {
            var runwayDecimal = GetSavings() / 1250;
            var rightDecimal = runwayDecimal % 1;
            var leftDecimal = decimal.ToInt16(runwayDecimal);
            var dayPercentage = decimal.ToInt16(rightDecimal * 100);
            decimal dayDivision = 30m / 100m;
            var dayAmount = decimal.ToInt16(dayDivision * dayPercentage);

            var newDate = leaveWorkDate.AddMonths(leftDecimal).AddDays(dayAmount);

           runway = Math.Round((newDate - leaveWorkDate).TotalDays);

            return runway;
        }

        public decimal GetSavings()
        {
            var startDate = new DateTime(2022, 03, 25);

            var currentDate = DateTime.Now;

            var monthsSaved = startDate.Month - currentDate.Month;

            var savingsAmount = monthlySavings * monthsSaved;

            savings = currentSavings + savingsAmount;

            return savings;
        }
    }
}
