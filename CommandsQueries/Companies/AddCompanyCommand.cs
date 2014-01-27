namespace CommandsQueries.Companies
{
    public class AddCompanyCommand : ICommand<int>
    {
        public string Name { get; set; }
        public int CreatedById { get; set; }
    }
}