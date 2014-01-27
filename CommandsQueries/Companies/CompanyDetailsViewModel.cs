using System;
using System.ComponentModel;

namespace CommandsQueries.Companies
{
    public class CompanyDetailsViewModel
    {
        [DisplayName("Company name")]
        public string Name { get; set; }

        [DisplayName("Number of contracts")]
        public int NumberOfContracts { get; set; }

        [DisplayName("Next year end")]
        public DateTime NextYearEnd { get; set; }
    }
}