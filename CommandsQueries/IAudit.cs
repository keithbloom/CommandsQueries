namespace CommandsQueries
{
    public interface IAudit
    {
        void Audit(string companyAddedBy, int createdById);
    }
}