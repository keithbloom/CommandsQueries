namespace CommandsQueries.Contracts
{
    public class SearchContractsForCompany : IQuery<SearchContractForCompanyViewModel>
    {
        public int CompanyId { get; set; }
    }

    public class SearchContractForCompanyViewModel
    {
        
    }

    public class SearchContractForCompanyHandler : IQueryHandler<SearchContractsForCompany,SearchContractForCompanyViewModel>
    {
        public SearchContractForCompanyViewModel Handle(SearchContractsForCompany request)
        {
            throw new System.NotImplementedException();
        }
    }
}