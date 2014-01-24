namespace CommandsQueries
{
    public interface ICommandHandler<in TCommand, out TResult> where TCommand : ICommand<TResult>
    {
        TResult Handle(TCommand command);
    }

    public interface ICommand{}

    public interface ICommand<out TResult> : ICommand
    {

    }

    public sealed class UnitType
    {
        public static readonly UnitType Default = new UnitType();

        private UnitType() {}
    }

    public abstract class CommmandHanlder<TMessage> : ICommandHandler<TMessage, UnitType>
        where TMessage : ICommand<UnitType>
    {
        public UnitType Handle(TMessage command)
        {
            HandleCore(command);

            return UnitType.Default;
        }

        public abstract void HandleCore(TMessage command);
    }

    public class AddNewContractCommand : ICommand<UnitType>
    {
        
    }

    public class AddNewContractHandler : CommmandHanlder<AddNewContractCommand>
    {
        public override void HandleCore(AddNewContractCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AddNewCompanyCommand : ICommand<int>
    {
        
    }

    public class AddNewCompanyCommandHandler : ICommandHandler<AddNewCompanyCommand, int>
    {
        public int Handle(AddNewCompanyCommand command)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IMediator
    {
        TResult Send<TResult>(ICommand<TResult> command);
    }
}