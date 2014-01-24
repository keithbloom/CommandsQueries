using StructureMap;

namespace CommandsQueries
{
    public class Bootstrapper
    {
        public void Boot()
        {
            ObjectFactory.Initialize(i => i.Scan(s =>
            {
                s.AssemblyContainingType<IMediator>();
                s.TheCallingAssembly();
                s.WithDefaultConventions();
                s.AddAllTypesOf(typeof (ICommandHandler<,>));
                s.AddAllTypesOf<ICommandPostHandleInspector>();
            }));

            
        } 

        public IContainer GetContainer()
        {
            return ObjectFactory.Container;
        }
    }
}