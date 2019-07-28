using Autofac;
using healthscan_BE.Handlers;

namespace healthscan_BE
{
    public static class DependencyInjectionManager
    {
        public static ContainerBuilder RegisterDependencies(ContainerBuilder ContainerBuilder)
        {
            ContainerBuilder.RegisterType<ProductHandler>().As<IProductHandler>().InstancePerLifetimeScope();

            return ContainerBuilder;
        }
    }
}
