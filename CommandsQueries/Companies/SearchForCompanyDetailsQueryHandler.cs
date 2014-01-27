using System.Linq;

namespace CommandsQueries.Companies
{
    public class SearchForCompanyDetailsQueryHandler : 
        IQueryHandler<SearchForCompanyDetails, CompanyDetailsViewModel>
    {
        readonly IRepository<Company> _companyRepository;

        public SearchForCompanyDetailsQueryHandler(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public CompanyDetailsViewModel Handle(SearchForCompanyDetails request)
        {
            var results = _companyRepository
                            .All()
                            .Where(x => x.Id == request.CompanyId)
                            .Select(x => new CompanyDetailsViewModel
                                {
                                    Name = x.CompanyName,
                                    NextYearEnd = x.AccountingEntity.CalculateNextYearEnd(),
                                    NumberOfContracts = x.Contracts.Count()
                                })
                             .FirstOrDefault();

            return results;
        }
    }
}