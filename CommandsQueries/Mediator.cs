using System;
using System.Reflection;
using StructureMap;

namespace CommandsQueries
{
    public class Mediator : IMediator
    {
        readonly IContainer _container;

        public Mediator(IContainer container)
        {
            _container = container;
        }

        public Response<TResponseData> Send<TResponseData>(ICommand<TResponseData> command)
        {
            var response = new Response<TResponseData>();

            var postProcessors = _container.GetAllInstances<ICommandPostHandleInspector>();

            try
            {
                var plan = new MediatorPlan<TResponseData>(typeof(ICommandHandler<,>), "Handle", command.GetType(), _container);

                response.Data = plan.Invoke(command);
            }
            catch (Exception e)
            {
                response.Exception = e;
            }

            foreach (var commandPostHandleInspector in postProcessors)
            {
                if (commandPostHandleInspector.InterestedIn(command))
                {
                    commandPostHandleInspector.Inspect(command);
                }
            }

            return response;
        }

        class MediatorPlan<TResult>
        {
            readonly MethodInfo HandleMethod;
            readonly Func<object> HandlerInstanceBuilder;

            public MediatorPlan(Type handlerTypeTemplate, string handlerMethodName, Type messageType, IContainer container)
            {
                var handlerType = handlerTypeTemplate.MakeGenericType(messageType, typeof(TResult));

                HandleMethod = GetHandlerMethod(handlerType, handlerMethodName, messageType);

                HandlerInstanceBuilder = () => container.GetInstance(handlerType);
            }

            MethodInfo GetHandlerMethod(Type handlerType, string handlerMethodName, Type messageType)
            {
                return handlerType
                    .GetMethod(handlerMethodName,
                        BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                        null, CallingConventions.HasThis,
                        new[] { messageType },
                        null);
            }

            public TResult Invoke(object message)
            {
                return (TResult)HandleMethod.Invoke(HandlerInstanceBuilder(), new[] { message });
            }

            
        }
    }


}