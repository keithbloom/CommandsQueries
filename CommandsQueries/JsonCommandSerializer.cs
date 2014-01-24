using System.IO;
using Newtonsoft.Json;

namespace CommandsQueries
{
    public class JsonCommandSerializer : ICommandPostHandleInspector
    {
        private StringWriter stringWriter;

        public JsonCommandSerializer(StringWriter stringWriter)
        {
            this.stringWriter = stringWriter;
        }


        public bool InterestedIn(ICommand command)
        {
            return true;
        }

        public void Inspect(ICommand command)
        {
            var type = command.GetType();

            var result = JsonConvert.SerializeObject((object) command, type, new JsonSerializerSettings());

            stringWriter.Write(result);


        }
    }
}