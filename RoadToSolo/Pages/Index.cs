using Microsoft.AspNetCore.Components;
using RoadToSolo.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class Index
    {
        [Inject]
        private CalculationService _calculationService { get; set; } = default;

        private double daysLeftAtWork;
        private string revenue;
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
            daysLeftAtWork = _calculationService.GetDaysLeftAtWork();
        }

        private void InitializeRevenue()
        {
            revenue = _calculationService.GetRevenue();
        }

        private void InitializeRunway()
        {
            runway = _calculationService.GetRunwayDays();
        }
    }
}
