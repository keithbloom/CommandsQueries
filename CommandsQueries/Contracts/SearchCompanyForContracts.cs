namespace CommandsQueries.Contracts
{
    public class SearchCompanyForContracts : IQuery<CompanyContractsViewModel>
    {
        public int CompanyId { get; set; }
    }

    public class CompanyContractsViewModel
    {
        
    }

    public class SearchContractForCompanyHandler : IQueryHandler<SearchCompanyForContracts,CompanyContractsViewModel>
    {
        public CompanyContractsViewModel Handle(SearchCompanyForContracts request)
        {
            throw new System.NotImplementedException();
        }
    }
}