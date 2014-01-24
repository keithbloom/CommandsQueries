using System;

namespace CommandsQueries.Contracts
{
    public class AddContractToCompanyCommand : ICommand<UnitType>
    {
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}