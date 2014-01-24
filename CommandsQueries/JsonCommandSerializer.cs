using System;
using System.IO;
using Newtonsoft.Json;

namespace CommandsQueries
{
    public class JsonCommandSerializer : ICommandPostHandleInspector
    {
        TextWriter _textWriter;

        public JsonCommandSerializer(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }


        public bool InterestedIn(ICommand command)
        {
            return true;
        }

        public void Inspect(ICommand command)
        {
            var type = command.GetType();

            var result = JsonConvert.SerializeObject(command, type, new JsonSerializerSettings());

            _textWriter.WriteLine();
            
            _textWriter.WriteLine("{0}_{1}.txt",DateTime.UtcNow.Ticks, type);
            _textWriter.Write(result);


        }
    }
}