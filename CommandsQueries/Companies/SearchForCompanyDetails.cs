namespace CommandsQueries.Companies
{
    public class SearchForCompanyDetails : IQuery<CompanyDetailsViewModel>
    {
        public int CompanyId { get; set; }
    }
}