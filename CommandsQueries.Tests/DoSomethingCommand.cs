namespace CommandsQueries.Tests
{
    public class DoSomethingCommand : ICommand<UnitType>
    {
        public string Name { get; set; }
        public int NumberOfTimes { get; set; }
    }

   
}