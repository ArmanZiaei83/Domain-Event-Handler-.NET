using System.Reflection;
using Autofac;
using Domain_Event_Handling.EventHandlers;
using MediatR;

namespace Domain_Event_Handling
{
    public class AutofacConfigurations : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(AddOrderForBuyerEventHandler)
                    .GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(NotificationHandler<>));
        }
    }
}