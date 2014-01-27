using System;

namespace CommandsQueries
{
    public interface ICompanyService
    {
        int AddCompany(string name, string address1, int createdByPersonId);

        void DeleteCompany(int id);

        void AddContractForCompany(int companyId, int personAddedById, int clientId, string description, DateTime start);

        void AddUserToCompany(int companyId, UserDto userDto);

        PagedList<ContractListDto> ContractsForCompany(int companyId, int start, int page);

        ContractDetailsDto GetContract(int contractId);

        PagedList<ActiveClients> GetAllActiveClients(int companyId);
    }

    public class UserDto
    {
    }

    public class ActiveClients
    {
    }

    public class ContractDetailsDto
    {
    }

    public class PagedList<T>
    {
    }

    public class ContractListDto    
    {
    }
}