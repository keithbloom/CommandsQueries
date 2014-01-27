using System;
using System.Collections.Generic;
using CommandsQueries.Contracts;

namespace CommandsQueries.Companies
{
    public class Company
    {
        public Company()
        {
            AccountingEntity = new SomeAccountingEntity();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public IEnumerable<Contract> Contracts { get; set; }

        public SomeAccountingEntity AccountingEntity { get; private set; }

    }

    public class SomeAccountingEntity
    {
        public DateTime CalculateNextYearEnd()
        {
            return DateTime.UtcNow;
        }
    }
}