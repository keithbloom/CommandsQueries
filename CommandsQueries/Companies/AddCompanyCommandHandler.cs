namespace CommandsQueries.Companies
{
    public class AddCompanyCommandHandler : ICommandHandler<AddCompanyCommand, int>
    {
        readonly IRepository<Company> _companyRepository;
        readonly IAudit _audit;

        public AddCompanyCommandHandler(IRepository<Company> companyRepository, IAudit audit)
        {
            _companyRepository = companyRepository;
            _audit = audit;
        }

        public int Handle(AddCompanyCommand command)
        {
            var company = new Company
                {
                    CompanyName = command.Name
                };
            
            _companyRepository.Add(company);
            _companyRepository.SaveChanges();
            _audit.Audit(string.Format("Company added by with Id {0}",company.Id), command.CreatedById);

            return company.Id;
        }
    }
}