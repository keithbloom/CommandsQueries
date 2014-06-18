using System.IO;

namespace CommandsQueries.Contracts
{
    public class AddContractToCompanyCommandHandler : AbstractCommmandHandler<AddContractToCompanyCommand>
    {
        TextWriter _textWriter;

        public AddContractToCompanyCommandHandler(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public override void HandleCore(AddContractToCompanyCommand command)
        {
            _textWriter.WriteLine("Hello, I'm adding a contract for {0}", command.Title);
        }
    }
}